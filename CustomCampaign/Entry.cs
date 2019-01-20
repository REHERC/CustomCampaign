using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CustomCampaign.SDK.Data;
using Harmony;
using Photon.Serialization;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Storage;
using static CustomCampaign.Plugin;
using static CustomCampaign.Storage;

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
            string CampaignLevels = Path.GetFullPath($@"{LevelsFolder()}/WorkshopLevels");
            if (!Directory.Exists(CampaignLevels))
                Directory.CreateDirectory(CampaignLevels);
            string path = $@"{Plugin.Files.RootDirectory}/Data/Campaigns/";
            foreach (string campaigndir in Directory.GetDirectories(path))
            {
                string pakfile = Path.GetFullPath($"{campaigndir}/Campaign.pak");
                if (File.Exists(pakfile) && Campaign.Validate(pakfile)) {
                    Campaign c = new Campaign();
                    c.Load(pakfile);
                    Storage.CampaignInfo cinfo = new Storage.CampaignInfo(campaigndir,c);
                    string Workspace = cinfo.DirectoryName;
                    string WorkshopRoot = $@"{CampaignLevels}/{Workspace}";
                    if (!Directory.Exists(WorkshopRoot))
                        Directory.CreateDirectory(WorkshopRoot);
                    int index = 1;
                    foreach (Campaign.Level level in c.Levels)
                    {
                        string Source = Path.GetFullPath(Path.Combine(campaigndir, level.file));
                        string Destination = Path.GetFullPath(Path.Combine(WorkshopRoot, Path.GetFileName(Source)));
                        File.Copy(Source, Destination, true);
                        File.Copy(Source + ".png", Destination + ".png", true);
                        cinfo.Levels.AddLevel("level", Resource.NormalizePath(Destination), LevelType.Official);
                        Storage.Levelnfos.Add(Destination.NormPath(), new Storage.CampaignLevelInfo(campaigndir, level, c.LockMode == Campaign.UnlockStyle.Campaign ? index : 1));
                        index++;
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
