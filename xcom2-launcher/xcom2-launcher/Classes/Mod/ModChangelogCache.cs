﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XCOM2Launcher.Mod
{
    public static class ModChangelogCache
    {
        private static Dictionary<long, string> changelogDict = new Dictionary<long, string>();

        public static async Task<string> GetChangeLogAsync(long workshopID)
        {
            if (changelogDict.ContainsKey(workshopID))
            {
               return changelogDict[workshopID];
            }
            else
            {
                WebClient changelogdownload = new WebClient();

                string changelograw = await changelogdownload.DownloadStringTaskAsync(new Uri("https://steamcommunity.com/sharedfiles/filedetails/changelog/" + workshopID));
                Regex rgx = new Regex("<div class=\"detailBox workshopAnnouncement noFooter\">[\\s]*<div class=\"headline\">[\\s]*(.*)[\\s]*</div>[\\s]*<p id=\"[0-9]+\">(.*)</p>");
                string changelogFormatted = "";
                foreach (Match m in rgx.Matches(changelograw))
                {
                    Regex htmlstrip = new Regex("<.*?>", RegexOptions.Compiled);
                    string desc = m.Groups[2].ToString();
                    changelogFormatted += m.Groups[1].ToString() + "\n" + htmlstrip.Replace(desc, "") + "\n\n";
                }
                changelogdownload.Dispose();
                if (changelogDict.ContainsKey(workshopID) == false)
                    changelogDict.Add(workshopID, changelogFormatted);
                return changelogDict[workshopID];

            }
        }
    }
}