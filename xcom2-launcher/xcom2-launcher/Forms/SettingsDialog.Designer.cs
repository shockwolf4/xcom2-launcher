﻿namespace XCOM2Launcher.Forms
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.modPathsListbox = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gamePathTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.addModPathButton = new System.Windows.Forms.Button();
			this.removeModPathButton = new System.Windows.Forms.Button();
			this.browseGamePathButton = new System.Windows.Forms.Button();
			this.argumentsTextBox = new XCOM2Launcher.UserElements.AutoCompleteTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.showHiddenEntriesCheckBox = new System.Windows.Forms.CheckBox();
			this.autoNumberModIndexesCheckBox = new System.Windows.Forms.CheckBox();
			this.ShowQuickLaunchArgumentsToggle = new System.Windows.Forms.CheckBox();
			this.neverAdoptTagsAndCatFromprofile = new System.Windows.Forms.CheckBox();
			this.useModSpecifiedCategoriesCheckBox = new System.Windows.Forms.CheckBox();
			this.useSentry = new System.Windows.Forms.CheckBox();
			this.closeAfterLaunchCheckBox = new System.Windows.Forms.CheckBox();
			this.searchForUpdatesCheckBox = new System.Windows.Forms.CheckBox();
			this.checkForPreReleaseUpdates = new System.Windows.Forms.CheckBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.allowMutipleInstances = new System.Windows.Forms.CheckBox();
			this.bOK = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(655, 210);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game options";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.modPathsListbox, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.gamePathTextBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.browseGamePathButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.argumentsTextBox, 1, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 181);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 155);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Arguments";
			// 
			// modPathsListbox
			// 
			this.modPathsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modPathsListbox.FormattingEnabled = true;
			this.modPathsListbox.Location = new System.Drawing.Point(103, 53);
			this.modPathsListbox.Name = "modPathsListbox";
			this.modPathsListbox.Size = new System.Drawing.Size(462, 95);
			this.modPathsListbox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 4);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 4, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Base Path";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 54);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 4, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Mod Directories";
			// 
			// gamePathTextBox
			// 
			this.gamePathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gamePathTextBox.Location = new System.Drawing.Point(103, 3);
			this.gamePathTextBox.Name = "gamePathTextBox";
			this.gamePathTextBox.Size = new System.Drawing.Size(462, 20);
			this.gamePathTextBox.TabIndex = 10;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.addModPathButton);
			this.flowLayoutPanel1.Controls.Add(this.removeModPathButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(568, 50);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(73, 101);
			this.flowLayoutPanel1.TabIndex = 12;
			// 
			// addModPathButton
			// 
			this.addModPathButton.Location = new System.Drawing.Point(3, 3);
			this.addModPathButton.Name = "addModPathButton";
			this.addModPathButton.Size = new System.Drawing.Size(67, 24);
			this.addModPathButton.TabIndex = 6;
			this.addModPathButton.Text = "Add";
			this.addModPathButton.UseVisualStyleBackColor = true;
			this.addModPathButton.Click += new System.EventHandler(this.AddModPathButtonOnClick);
			// 
			// removeModPathButton
			// 
			this.removeModPathButton.Location = new System.Drawing.Point(3, 33);
			this.removeModPathButton.Name = "removeModPathButton";
			this.removeModPathButton.Size = new System.Drawing.Size(67, 24);
			this.removeModPathButton.TabIndex = 8;
			this.removeModPathButton.Text = "Remove";
			this.removeModPathButton.UseVisualStyleBackColor = true;
			this.removeModPathButton.Click += new System.EventHandler(this.RemoveModPathButtonOnClick);
			// 
			// browseGamePathButton
			// 
			this.browseGamePathButton.Location = new System.Drawing.Point(571, 3);
			this.browseGamePathButton.Name = "browseGamePathButton";
			this.browseGamePathButton.Size = new System.Drawing.Size(67, 24);
			this.browseGamePathButton.TabIndex = 14;
			this.browseGamePathButton.Text = "Browse";
			this.browseGamePathButton.UseVisualStyleBackColor = true;
			this.browseGamePathButton.Click += new System.EventHandler(this.BrowseGamePathButtonOnClick);
			// 
			// argumentsTextBox
			// 
			this.argumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argumentsTextBox.Location = new System.Drawing.Point(103, 154);
			this.argumentsTextBox.Name = "argumentsTextBox";
			this.argumentsTextBox.Size = new System.Drawing.Size(462, 20);
			this.argumentsTextBox.TabIndex = 15;
			this.argumentsTextBox.Values = new string[0];
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.tableLayoutPanel3);
			this.groupBox2.Location = new System.Drawing.Point(12, 307);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(655, 78);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Usability";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this.showHiddenEntriesCheckBox, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.autoNumberModIndexesCheckBox, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.ShowQuickLaunchArgumentsToggle, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.neverAdoptTagsAndCatFromprofile, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.useModSpecifiedCategoriesCheckBox, 0, 2);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 20);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(641, 52);
			this.tableLayoutPanel3.TabIndex = 6;
			// 
			// showHiddenEntriesCheckBox
			// 
			this.showHiddenEntriesCheckBox.AutoSize = true;
			this.showHiddenEntriesCheckBox.Location = new System.Drawing.Point(3, 3);
			this.showHiddenEntriesCheckBox.Name = "showHiddenEntriesCheckBox";
			this.showHiddenEntriesCheckBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.showHiddenEntriesCheckBox.Size = new System.Drawing.Size(119, 20);
			this.showHiddenEntriesCheckBox.TabIndex = 9;
			this.showHiddenEntriesCheckBox.Text = "Show hidden mods";
			this.toolTip.SetToolTip(this.showHiddenEntriesCheckBox, "If enabled, hidden mod entries will \r\nbe shown in the mod list.");
			this.showHiddenEntriesCheckBox.UseVisualStyleBackColor = true;
			// 
			// autoNumberModIndexesCheckBox
			// 
			this.autoNumberModIndexesCheckBox.AutoSize = true;
			this.autoNumberModIndexesCheckBox.Location = new System.Drawing.Point(216, 3);
			this.autoNumberModIndexesCheckBox.Name = "autoNumberModIndexesCheckBox";
			this.autoNumberModIndexesCheckBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.autoNumberModIndexesCheckBox.Size = new System.Drawing.Size(151, 20);
			this.autoNumberModIndexesCheckBox.TabIndex = 14;
			this.autoNumberModIndexesCheckBox.Text = "Auto-number mod indexes";
			this.toolTip.SetToolTip(this.autoNumberModIndexesCheckBox, "Auto-number mod indexes, when \r\none is changed (turn off to edit manually).");
			this.autoNumberModIndexesCheckBox.UseVisualStyleBackColor = true;
			// 
			// ShowQuickLaunchArgumentsToggle
			// 
			this.ShowQuickLaunchArgumentsToggle.AutoSize = true;
			this.ShowQuickLaunchArgumentsToggle.Location = new System.Drawing.Point(216, 29);
			this.ShowQuickLaunchArgumentsToggle.Name = "ShowQuickLaunchArgumentsToggle";
			this.ShowQuickLaunchArgumentsToggle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.ShowQuickLaunchArgumentsToggle.Size = new System.Drawing.Size(172, 20);
			this.ShowQuickLaunchArgumentsToggle.TabIndex = 17;
			this.ShowQuickLaunchArgumentsToggle.Text = "Show quick launch arguments";
			this.toolTip.SetToolTip(this.ShowQuickLaunchArgumentsToggle, "Displays a combo-box that allows \r\nto quickly toggle different launch \r\narguments" +
        " on the main screen.");
			this.ShowQuickLaunchArgumentsToggle.UseVisualStyleBackColor = true;
			// 
			// neverAdoptTagsAndCatFromprofile
			// 
			this.neverAdoptTagsAndCatFromprofile.AutoSize = true;
			this.neverAdoptTagsAndCatFromprofile.Location = new System.Drawing.Point(429, 3);
			this.neverAdoptTagsAndCatFromprofile.Name = "neverAdoptTagsAndCatFromprofile";
			this.neverAdoptTagsAndCatFromprofile.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.neverAdoptTagsAndCatFromprofile.Size = new System.Drawing.Size(185, 20);
			this.neverAdoptTagsAndCatFromprofile.TabIndex = 16;
			this.neverAdoptTagsAndCatFromprofile.Text = "Never import tags and categories";
			this.toolTip.SetToolTip(this.neverAdoptTagsAndCatFromprofile, "If enabled, currently assigned tags and categories\r\nwill always be preserved when" +
        " importing profiles.");
			this.neverAdoptTagsAndCatFromprofile.UseVisualStyleBackColor = true;
			// 
			// useModSpecifiedCategoriesCheckBox
			// 
			this.useModSpecifiedCategoriesCheckBox.AutoSize = true;
			this.useModSpecifiedCategoriesCheckBox.Location = new System.Drawing.Point(3, 29);
			this.useModSpecifiedCategoriesCheckBox.Name = "useModSpecifiedCategoriesCheckBox";
			this.useModSpecifiedCategoriesCheckBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.useModSpecifiedCategoriesCheckBox.Size = new System.Drawing.Size(168, 20);
			this.useModSpecifiedCategoriesCheckBox.TabIndex = 15;
			this.useModSpecifiedCategoriesCheckBox.Text = "Use mod-specified categories";
			this.toolTip.SetToolTip(this.useModSpecifiedCategoriesCheckBox, "Toggle whether new mods appear in their specified \r\ndefault category (turn off to" +
        " have all mods appear in Unsorted).");
			this.useModSpecifiedCategoriesCheckBox.UseVisualStyleBackColor = true;
			// 
			// useSentry
			// 
			this.useSentry.AutoSize = true;
			this.useSentry.Location = new System.Drawing.Point(429, 3);
			this.useSentry.Name = "useSentry";
			this.useSentry.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.useSentry.Size = new System.Drawing.Size(170, 20);
			this.useSentry.TabIndex = 17;
			this.useSentry.Text = "Send anonymous error reports";
			this.toolTip.SetToolTip(this.useSentry, "If enabled, critical errors or other \r\npotential issues are automatically reporte" +
        "d to\r\nour X2CommunityCore Sentry.io account.");
			this.useSentry.UseVisualStyleBackColor = true;
			// 
			// closeAfterLaunchCheckBox
			// 
			this.closeAfterLaunchCheckBox.AutoSize = true;
			this.closeAfterLaunchCheckBox.Location = new System.Drawing.Point(216, 29);
			this.closeAfterLaunchCheckBox.Name = "closeAfterLaunchCheckBox";
			this.closeAfterLaunchCheckBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.closeAfterLaunchCheckBox.Size = new System.Drawing.Size(114, 20);
			this.closeAfterLaunchCheckBox.TabIndex = 7;
			this.closeAfterLaunchCheckBox.Text = "Close after launch";
			this.toolTip.SetToolTip(this.closeAfterLaunchCheckBox, "Close the launcher after launching the game.");
			this.closeAfterLaunchCheckBox.UseVisualStyleBackColor = true;
			// 
			// searchForUpdatesCheckBox
			// 
			this.searchForUpdatesCheckBox.AutoSize = true;
			this.searchForUpdatesCheckBox.Location = new System.Drawing.Point(3, 3);
			this.searchForUpdatesCheckBox.Name = "searchForUpdatesCheckBox";
			this.searchForUpdatesCheckBox.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.searchForUpdatesCheckBox.Size = new System.Drawing.Size(116, 20);
			this.searchForUpdatesCheckBox.TabIndex = 10;
			this.searchForUpdatesCheckBox.Text = "Check for updates";
			this.toolTip.SetToolTip(this.searchForUpdatesCheckBox, "Check if a new Version is available on startup.");
			this.searchForUpdatesCheckBox.UseVisualStyleBackColor = true;
			this.searchForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.searchForUpdatesCheckBox_CheckedChanged);
			// 
			// checkForPreReleaseUpdates
			// 
			this.checkForPreReleaseUpdates.AutoSize = true;
			this.checkForPreReleaseUpdates.Location = new System.Drawing.Point(216, 3);
			this.checkForPreReleaseUpdates.Name = "checkForPreReleaseUpdates";
			this.checkForPreReleaseUpdates.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.checkForPreReleaseUpdates.Size = new System.Drawing.Size(193, 20);
			this.checkForPreReleaseUpdates.TabIndex = 18;
			this.checkForPreReleaseUpdates.Text = "Include Pre-Release/Beta updates";
			this.toolTip.SetToolTip(this.checkForPreReleaseUpdates, "Enabled this option, if you wold like to be notified about Pre-Release versions.");
			this.checkForPreReleaseUpdates.UseVisualStyleBackColor = true;
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 10000;
			this.toolTip.InitialDelay = 300;
			this.toolTip.IsBalloon = true;
			this.toolTip.ReshowDelay = 100;
			// 
			// allowMutipleInstances
			// 
			this.allowMutipleInstances.AutoSize = true;
			this.allowMutipleInstances.Location = new System.Drawing.Point(3, 29);
			this.allowMutipleInstances.Name = "allowMutipleInstances";
			this.allowMutipleInstances.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.allowMutipleInstances.Size = new System.Drawing.Size(140, 20);
			this.allowMutipleInstances.TabIndex = 19;
			this.allowMutipleInstances.Text = "Allow multiple instances";
			this.toolTip.SetToolTip(this.allowMutipleInstances, "If enabled, multiple instances of AML can be run in parallel.");
			this.allowMutipleInstances.UseVisualStyleBackColor = true;
			// 
			// bOK
			// 
			this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bOK.Location = new System.Drawing.Point(453, 394);
			this.bOK.Name = "bOK";
			this.bOK.Size = new System.Drawing.Size(104, 24);
			this.bOK.TabIndex = 12;
			this.bOK.Text = "OK";
			this.bOK.UseVisualStyleBackColor = true;
			this.bOK.Click += new System.EventHandler(this.bOK_Click);
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(563, 394);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(104, 24);
			this.bCancel.TabIndex = 11;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.tableLayoutPanel1);
			this.groupBox3.Location = new System.Drawing.Point(12, 224);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(655, 77);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Application";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.searchForUpdatesCheckBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.checkForPreReleaseUpdates, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.useSentry, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.allowMutipleInstances, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.closeAfterLaunchCheckBox, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 52);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 430);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.bOK);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = global::XCOM2Launcher.Properties.Resources.xcom;
			this.Name = "SettingsDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Shown += new System.EventHandler(this.SettingsDialog_Shown);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        private void PropertyGrid1_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox closeAfterLaunchCheckBox;
        private System.Windows.Forms.CheckBox searchForUpdatesCheckBox;
        private System.Windows.Forms.CheckBox showHiddenEntriesCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button browseGamePathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox modPathsListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gamePathTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addModPathButton;
        private System.Windows.Forms.Button removeModPathButton;
        private UserElements.AutoCompleteTextBox argumentsTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox autoNumberModIndexesCheckBox;
        private System.Windows.Forms.CheckBox useModSpecifiedCategoriesCheckBox;
        private System.Windows.Forms.CheckBox neverAdoptTagsAndCatFromprofile;
        private System.Windows.Forms.CheckBox ShowQuickLaunchArgumentsToggle;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bOK;
		private System.Windows.Forms.CheckBox checkForPreReleaseUpdates;
		private System.Windows.Forms.CheckBox useSentry;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckBox allowMutipleInstances;
	}
}