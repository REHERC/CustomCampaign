using System;
using System.Collections.Generic;
using System.IO;
using Harmony;
using Serializers;
using Spectrum.API.Storage;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("CreateEntries")]
    public class LevelGridMenu__CreateEntries__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");

            FileSystem fs = new FileSystem();
            string path = $@"{fs.RootDirectory}/Data/Campaigns/";


            if (flag_campaignmode)
            {
                foreach (string campaignroot in Directory.GetDirectories(path))
                {
                    Console.WriteLine("folder : " + campaignroot);
                    Campaign c = new Campaign();
                    string pakfile = Path.GetFullPath(campaignroot + "/Campaign.pak");
                    Console.WriteLine(pakfile);
                    Console.WriteLine("exists : " + File.Exists(pakfile));
                    Console.WriteLine("validated : " + c.Validate(pakfile));
                    if (File.Exists(pakfile)
                    && c.Validate(pakfile))
                    {
                        c.Load(pakfile);
                        
                        Console.WriteLine("campaign : " + c.Name);
                        LevelSet set = new LevelSet();

                        foreach (Campaign.Level level in c.Levels)
                        {
                            string levelpath = Path.GetFullPath(campaignroot + Path.DirectorySeparatorChar + level.file);
                            CampaignLevelInfo info = SharedResources.LevelFilesAndInfo[levelpath];
                            Console.WriteLine("adding level to set : " + levelpath);
                            set.AddLevel(info.name, levelpath, LevelType.Official);
                        }

                        GameModeID mode = GameModeID.Nexus;
                        LevelGridMenu.PlaylistEntry.UnlockStyle unlock = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                        
                        __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set,  c.Name, true, unlock, mode);
                        __instance.buttonList_.SortAndUpdateVisibleButtons();
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager))]
    [HarmonyPatch("SetupLevelPaths")]
    public class LevelSetsManager__SetupLevelPaths__Patch
    {
        static void Postfix(LevelSetsManager __instance)
        {
            FileSystem fs = new FileSystem();
            string path = $@"{fs.RootDirectory}/Data/Campaigns/";

            foreach (string campaignroot in Directory.GetDirectories(path))
            {
                Campaign c = new Campaign();
                string pakfile = Path.GetFullPath(campaignroot + "/Campaign.pak");
                if (File.Exists(pakfile)
                && c.Validate(pakfile))
                {
                    c.Load(pakfile);
                    foreach (Campaign.Level level in c.Levels)
                    {
                        string levelpath = Path.GetFullPath(campaignroot + Path.DirectorySeparatorChar + level.file);
                        
                        LevelNameAndPathPair levelpathpair = new LevelNameAndPathPair(level.levelname.GetForwardPath(), levelpath);
                        
                        LevelSettings levelsettings = LevelSettings.CreateAndLoadFromPath(levelpath.GetForwardPath(), out bool settingsvalidlevelpath);
                        
                        LevelInfo levelinfo = LevelInfo.Create(levelpath.GetForwardPath(), levelsettings);
                        levelinfo.fileNameWithoutExtension_ = levelpath;
                        levelinfo.levelType_ = LevelType.Official;

                        Console.WriteLine("adding level to internal registry : " + levelpath);
                        Console.WriteLine("invalid file path : " + settingsvalidlevelpath);

                        Console.WriteLine("levelsettings : " + levelsettings is null ? "null" : "instantiated");
                        Console.WriteLine("levelinfo : " + levelinfo is null ? "null" : "instantiated");

                        UnityEngine.Debug.LogError("Level : " + levelsettings.levelName_);
                        UnityEngine.Debug.LogError("        " + levelinfo.fileNameWithoutExtension_);
                        UnityEngine.Debug.LogError("        " + levelpathpair.levelPath_);

                        //__instance.AllLevelPaths_.Add(levelpath);
                        //__instance.AllLevelsLevelNameAndPathPairs_.Add(levelpathpair);

                        //__instance.OfficialLevelFilePaths_.Add(levelpath);
                        //__instance.OfficialLevelInfosList_.Add(levelinfo);
                        //__instance.OfficialLevelNameAndPathPairs_.Add(levelpathpair);

                        __instance.AddOrUpdateLevelUsingLevelInfo(levelpath.GetForwardPath().Normalize(), levelinfo, false);

                        SharedResources.LevelFilesAndInfo.Add(levelpath, new CampaignLevelInfo(level.levelname, level.levelname_sub, level.loading_wallpaper));
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager))]
    [HarmonyPatch("CanLevelBeLoadedInEditor")]
    public class LevelSetsManager__CanLevelBeLoadedInEditor__Patch
    {
        void Postfix(bool __result, string normalizedAboluteLevelPath)
        {
            __result |= SharedResources.LevelFilesAndInfo.ContainsKey(normalizedAboluteLevelPath);
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager))]
    [HarmonyPatch("LevelExists")]
    public class LevelSetsManager__LevelExists__Patch
    {
        void Postfix(bool __result, string normalizedAboluteLevelPath)
        {
            __result |= SharedResources.LevelFilesAndInfo.ContainsKey(normalizedAboluteLevelPath);
        }
    }

    [HarmonyPatch(typeof(BinaryDeserializer), "LoadFromFile", new Type[] { typeof(string)})]
    public class BinaryDeserializer__ctor_string__Patch
    {
        void Postfix(string path)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BinaryDeserializer::LoadFromFile");
            Console.WriteLine(path);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
