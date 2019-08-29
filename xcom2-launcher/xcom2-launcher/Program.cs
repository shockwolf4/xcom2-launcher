﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;
using Sentry;
using Sentry.Protocol;
using XCOM2Launcher.Classes.Steam;
using XCOM2Launcher.Forms;
using XCOM2Launcher.Mod;
using XCOM2Launcher.XCOM;

namespace XCOM2Launcher
{
    internal static class Program
    {
        public static readonly bool IsDebugBuild;

        static Program()
        {
            #if DEBUG
                IsDebugBuild = true;
            #else
                IsDebugBuild = false;
            #endif
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!IsDebugBuild)
            {
                // Capture all unhandled Exceptions
                AppDomain.CurrentDomain.UnhandledException += (sender, args) => HandleUnhandledException(args.ExceptionObject as Exception, "UnhandledException");
                Application.ThreadException += (sender, args) => HandleUnhandledException(args.Exception, "ThreadException");
            }

            IDisposable sentrySdkInstance = null;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                InitAppSettings();
                sentrySdkInstance = InitSentry();

                if (!CheckDotNet4_7_2())
                {
                    var result = MessageBox.Show("This program requires Microsoft .NET Framework v4.7.2 or newer. Do you want to open the download page now?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                        Process.Start("https://dotnet.microsoft.com/download/dotnet-framework");

                    return;
                }

                if (!SteamAPIWrapper.Init()) {
                    StringBuilder message = new StringBuilder();
                    message.AppendLine("Please make sure that:");
                    message.AppendLine("- Steam is running");
                    message.AppendLine("- the file steam_appid.txt exists in the AML folder");
                    message.AppendLine("- neither (or both) of Steam and AML are running\n  with admin privileges");
                    MessageBox.Show(message.ToString(), "Error - unable to detect Steam!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load settings
                var settings = InitializeSettings();
                if (settings == null)
                    return;

                // Check for update
                if (!IsDebugBuild && settings.CheckForUpdates)
                {
                    CheckForUpdate();
                }

                // clean up old files
                if (File.Exists(XCOM2.DefaultConfigDir + @"\DefaultModOptions.ini.bak"))
                {
                    // Restore backup
                    File.Copy(XCOM2.DefaultConfigDir + @"\DefaultModOptions.ini.bak", XCOM2.DefaultConfigDir + @"\DefaultModOptions.ini", true);
                    File.Delete(XCOM2.DefaultConfigDir + @"\DefaultModOptions.ini.bak");
                }

                Application.Run(new MainForm(settings));
                SteamAPIWrapper.Shutdown();
            }
            finally
            {
                sentrySdkInstance?.Dispose();
                Properties.Settings.Default.Save();
            }
        }

        static void HandleUnhandledException(Exception e, string source)
        {
            SentrySdk.CaptureException(e);
            File.WriteAllText("error.log", $"Sentry GUID: {Properties.Settings.Default.Guid}\nSource: {source}\nMessage: {e.Message}\n\nStack:\n{e.StackTrace}");
            MessageBox.Show("An unhandled exception occured. See 'error.log' in application folder for additional details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        /// <summary>
        /// Initializes the Sentry environment.
        /// Sentry is an open-source application monitoring platform that help to identify issues.
        /// </summary>
        /// <returns></returns>
        private static IDisposable InitSentry()
        {
            if (!Properties.Settings.Default.IsSentryEnabled || IsDebugBuild)
                return null;

            IDisposable sentrySdkInstance = null;

            try
            {
                sentrySdkInstance = SentrySdk.Init(o =>
                {
                    o.Dsn = new Dsn(Properties.Settings.Default.SentryDsn);
                    o.Release = "AML@" + GetCurrentVersionString();     // prefix because releases are global per organization
                    o.Debug = false;
                    o.Environment = IsDebugBuild ? "Debug" : "Release"; // Maybe use "Beta" for Pre-Release version (new/separate build configuration)
                    o.BeforeSend = sentryEvent =>
                    {
                        sentryEvent.User.Email = null;
                        return sentryEvent;
                    };
                });

                SentrySdk.ConfigureScope(scope =>
                {
                    scope.User = new User
                    {
                        Id = Properties.Settings.Default.Guid,
                        Username = Properties.Settings.Default.Username,
                        IpAddress = null
                    };
                });

                // SentrySdk.CaptureMessage("Sentry test message", SentryLevel.Debug);
            }
            catch (Exception ex)
            {
                // If Sentry wasn't initialized correctly we at least try to send one message to report this.
                // (this won't throw another Ex, even if Init() failed)
                SentrySdk.CaptureException(ex);
                SentrySdk.Close();
                Debug.WriteLine(ex.Message);
            }

            return sentrySdkInstance;
        }


        /// <summary>
        /// Initializes the Properties.Settings .NET applications settings.
        /// Used for all settings that we want to persist, even if the user decides to delete the
        /// json settings file or starts AML from different folders.
        /// </summary>
        private static void InitAppSettings()
        {
            var appSettings = Properties.Settings.Default;

            // Upgrade settings from previous version if required
            if (appSettings.IsSettingsUpgradeRequired) {
                appSettings.Upgrade();
                appSettings.IsSettingsUpgradeRequired = false;

                // Ask user to opt-in for Sentry error reporting on first run or after updating to new version if it is disabled
                if (!appSettings.IsSentryEnabled)
                {
                    var result = MessageBox.Show("Please help us to improve AML, by enabling anonymous error reporting! \n\n" +
                                                 "Critical errors or other potential issues are then automatically " +
                                                 "reported to our X2CommunityCore Sentry.io account. \n" +
                                                 "You can enable/disable this feature at any time in the Settings dialog. \n\n" +
                                                 "Do you want to enable anonymous error reporting now?",
                                                 "Enable/disable AML error reporting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    appSettings.IsSentryEnabled = result == DialogResult.Yes;
                }
            }

            // Initialize GUID (used for error reporting)
            if (string.IsNullOrEmpty(appSettings.Guid))
            {
                appSettings.Guid = Guid.NewGuid().ToString();
            }

            // Version information can be used to perform version specific migrations if required.
            if (appSettings.Version != GetCurrentVersionString()) {
                // IF required at some point
                appSettings.Version = GetCurrentVersionString();
            }

            appSettings.Save();
        }

        /// <summary>
        /// Checks if .Net Framework 4.7.2 or later installed.
        /// Verifies that the method SortedSet.TryGetValue() (which was added with 4.7.2) is available.
        /// </summary>
        /// <returns>true if version 4.7.2 or later is installed</returns>
        private static bool CheckDotNet4_7_2()
        {
            try
            {
                return typeof(SortedSet<>).GetMethod("TryGetValue") != null;
                // return typeof(DateTimeOffset).GetMethod("FromUnixTimeSeconds") != null; // obsolete .NET 4.6 check
            }
            catch (AmbiguousMatchException)
            {
                // ambiguous means there is more than one result
                return true;
            }
        }

        public static Settings InitializeSettings()
        {
            var firstRun = !File.Exists("settings.json");

	        var settings = firstRun ? new Settings() : Settings.Instance;

	        if (settings.ShowUpgradeWarning && !firstRun)
	        {
		        MessageBoxManager.Cancel = "Exit";
		        MessageBoxManager.OK = "Continue";
				MessageBoxManager.Register();
				var choice = MessageBox.Show(
					"WARNING!!\n\nThis launcher is NOT COMPATIBLE with the old 'settings.json' file.\nStop NOW and launch the old version to export a profile of your mods WITH GROUPS!\nOnce that is done, move the old 'settings.json' file to a SAFE PLACE and then proceed.\nAfter loading, import the profile you saved to recover groups.\n\nIf you are not ready to do this, click 'Exit' to leave with no changes.",
					"WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
				if (choice == DialogResult.Cancel) Environment.Exit(0);
				MessageBoxManager.Unregister();
			}

			settings.ShowUpgradeWarning = false;

			// Verify Game Path
			if (!Directory.Exists(settings.GamePath))
                settings.GamePath = XCOM2.DetectGameDir();

            if (settings.GamePath == "")
                MessageBox.Show(@"Could not find XCOM 2 installation path. Please fill it manually in the settings.");

            // Verify Mod Paths
            var pathsToEdit = settings.ModPaths.Where(m => !m.EndsWith("\\")).ToList();
            foreach (var modPath in pathsToEdit)
            {
                settings.ModPaths.Add(modPath + "\\");
                settings.ModPaths.Remove(modPath);
            }

            var oldPaths = settings.ModPaths.Where(modPath => !Directory.Exists(modPath)).ToList();
            foreach (var modPath in oldPaths)
                settings.ModPaths.Remove(modPath);

            foreach (var modPath in XCOM2.DetectModDirs())
            {
                if (!settings.ModPaths.Contains(modPath))
                {
                    if (!settings.ModPaths.Contains(modPath + "\\"))
                    {
                        settings.ModPaths.Add(modPath);
                    }
                }

            }


            if (settings.ModPaths.Count == 0)
                MessageBox.Show(@"Could not find XCOM 2 mod directories. Please fill them in manually in the settings.");

            if (settings.Mods.Entries.Count > 0)
            {
                // Verify categories
                var index = settings.Mods.Entries.Values.Max(c => c.Index);
                foreach (var cat in settings.Mods.Entries.Values.Where(c => c.Index == -1))
                    cat.Index = ++index;

                // Verify Mods 
	            foreach (var mod in settings.Mods.All)
	            {
		            if (!settings.ModPaths.Any(mod.IsInModPath))
						mod.AddState(ModState.NotLoaded);

					if (!Directory.Exists(mod.Path) || !File.Exists(mod.GetModInfoFile()))
                    {
						mod.AddState(ModState.NotInstalled);
                    }
                    else if (!File.Exists(mod.GetModInfoFile()))
                    {
                        string newModInfo = settings.Mods.FindModInfo(mod.Path);
                        if (newModInfo != null)
                            mod.ID = Path.GetFileNameWithoutExtension(newModInfo);
                        else
						    mod.AddState(ModState.NotInstalled);
                    }

	                // tags clean up
	                mod.Tags = mod.Tags.Where(t => settings.Tags.ContainsKey(t.ToLower())).ToList();
	            }

                var newlyBrokenMods = settings.Mods.All.Where(m => (m.State == ModState.NotLoaded || m.State == ModState.NotInstalled) && !m.isHidden).ToList();
                if (newlyBrokenMods.Count > 0)
                {
                    if (newlyBrokenMods.Count == 1)
                        FlexibleMessageBox.Show($"The mod '{newlyBrokenMods[0].Name}' no longer exists and has been hidden.");
                    else
                        FlexibleMessageBox.Show($"{newlyBrokenMods.Count} mods no longer exist and have been hidden:\r\n\r\n" + string.Join("\r\n", newlyBrokenMods.Select(m => m.Name)));

                    foreach (var m in newlyBrokenMods)
                        m.isHidden = true;
				}
            }

            // import mods
            settings.ImportMods();

            return settings;
        }

        public static bool CheckForUpdate()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    client.Headers.Add("User-Agent: Other");
                    GitHub.Release release;

                    if (Settings.Instance.CheckForPreReleaseUpdates)
                    {
                        // fetch all releases including pre-releases and select the first/newest 
                        var jsonAllReleases = client.DownloadString("https://api.github.com/repos/X2CommunityCore/xcom2-launcher/releases");
                        var allReleases = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GitHub.Release>>(jsonAllReleases);
                        release = allReleases.FirstOrDefault();
                    }
                    else
                    {
                        // fetch latest non-pre-release
                        var json = client.DownloadString("https://api.github.com/repos/X2CommunityCore/xcom2-launcher/releases/latest");
                        release = Newtonsoft.Json.JsonConvert.DeserializeObject<GitHub.Release>(json);
                    }

                    if (release == null)
                        return false;

                    var regexVersionNumber = new Regex("[^0-9.]");

                    var currentVersion = GetCurrentVersion();
                    string releaseVersionString = release.tag_name;
                    Version.TryParse(regexVersionNumber.Replace(releaseVersionString, ""), out Version newVersion);

                    if (currentVersion != null && newVersion != null)
                    {
                        if (currentVersion.CompareTo(newVersion) < 0)
                        {
                            // New version available
                            new UpdateAvailableDialog(release, currentVersion, newVersion).ShowDialog();
                            return true;
                        }
                    }
                    else
                    {
                        string message = $"{nameof(CheckForUpdate)}: Error parsing version information '{releaseVersionString}'.";
                        SentrySdk.CaptureMessage(message, SentryLevel.Warning);
                        Debug.Fail(message);
                    }
                }
            }
            catch (System.Net.WebException ex)
            {
                Debug.WriteLine(nameof(CheckForUpdate) + ": " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Returns versions information that was generated by GitVersionTask
        /// </summary>
        /// <returns></returns>
        public static Version GetCurrentVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fields = assembly.GetType("XCOM2Launcher.GitVersionInformation").GetFields();

            int.TryParse(fields.Single(f => f.Name == "Major").GetValue(null).ToString(), out var major);
            int.TryParse(fields.Single(f => f.Name == "Minor").GetValue(null).ToString(), out var minor);
            int.TryParse(fields.Single(f => f.Name == "Patch").GetValue(null).ToString(), out var patch);

            return new Version(major, minor, patch);
        }

        public static string GetCurrentVersionString(bool includeDebugPostfix = false) {
            var ver = GetCurrentVersion();

            var result = $"v{ver.Major}.{ver.Minor}.{ver.Build}";

            if (IsDebugBuild && includeDebugPostfix)
                result += " DEBUG";
            
            return result;
        }
    }
}