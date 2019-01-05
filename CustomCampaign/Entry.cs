﻿using System;
using System.IO;
using System.Reflection;
using Harmony;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Storage;
using static CustomCampaign.Plugin;

namespace CustomCampaign
{
    public class Entry : IPlugin
    {
        public void Initialize(IManager manager, string ipcIdentifier)
        {
            try
            {
                Plugin.Files = new FileSystem();
                Plugin.Init();
                Storage.Init();

                Make();

                HarmonyInstance Harmony = HarmonyInstance.Create($"com.CustomCampaign.{ipcIdentifier}");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Make()
        {
            string WorkshopLevels = Path.GetFullPath($@"{LevelsFolder()}/WorkshopLevels");
            if (!Directory.Exists(WorkshopLevels))
                Directory.CreateDirectory(WorkshopLevels);
            string path = $@"{Plugin.Files.RootDirectory}/Data/Campaigns/";
            foreach (string campaigndir in Directory.GetDirectories(path))
            {
                string pakfile = Path.GetFullPath($"{campaigndir}/Campaign.pak");
                if (File.Exists(pakfile) && Campaign.Validate(pakfile)) {
                    Campaign c = new Campaign();
                    c.Load(pakfile);
                    Storage.CampaignInfo cinfo = new Storage.CampaignInfo(campaigndir,c);
                    string Workspace = cinfo.DirectoryName;
                    string WorkshopRoot = $@"{WorkshopLevels}/{Workspace}";
                    if (!Directory.Exists(WorkshopRoot))
                        Directory.CreateDirectory(WorkshopRoot);
                    foreach (Campaign.Level level in c.Levels)
                    {
                        string Source = Path.GetFullPath(Path.Combine(campaigndir, level.file));
                        string Destination = Path.GetFullPath(Path.Combine(WorkshopRoot, Path.GetFileName(Source)));
                        File.Copy(Source, Destination, true);
                        File.Copy(Source + ".png", Destination + ".png", true);

                        cinfo.Levels.AddLevel("level", Resource.NormalizePath(Destination), LevelType.Official);

                        Storage.Levelnfos.Add(Destination.NormPath(), new CampaignLevelInfo(campaigndir, level));
                    }
                    Storage.Campaigns.Add(cinfo);
                }
            }
        }
    }

    public static partial class Plugin
    {
        public static FileSystem Files;
    }
}
