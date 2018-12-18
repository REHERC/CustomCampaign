using System;
using System.IO;
using Harmony;
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

            if (flag_campaignmode)
            {
                string ResourcesFolder = SharedResources.GetResourcesFolder().Replace(@"\", "/");
                string LevelsFolder = SharedResources.GetLevelsFolder().Replace(@"\", "/");


                LevelSet set = new LevelSet();

                /*
                set.AddLevel("Instantiation", $"{ResourcesFolder}/Levels/Instantiation.bytes", LevelType.Official);
                set.AddLevel("Lost Society", $"{ResourcesFolder}/Levels/Lost Society.bytes", LevelType.Official);
                set.AddLevel("Long Ago", $"{ResourcesFolder}/Levels/Long Ago.bytes", LevelType.Official);
                
                */
                Console.WriteLine(LevelsFolder);
                set.AddLevel("Broken Symmetry", $@"{ResourcesFolder}/Levels/Broken Symmetry.bytes", LevelType.Official);
                set.AddLevel("Factory Reset", $@"{LevelsFolder}/factory reset.bytes", LevelType.Official);
                set.AddLevel("Test", $@"C:/Users/amaury/Documents/my games/Distance/Levels/MyLevels/Folder/test.bytes", LevelType.Official);

                FileSystem fs = new FileSystem();

                string path = $@"{fs.RootDirectory}/Data/Levels";

                foreach (string level in Directory.GetFiles(path, "*.bytes"))
                {
                    set.AddLevel("Level name", level.Replace(@"\", "/"), LevelType.Official);
                }

                GameModeID gameModeID = GameModeID.LostToEchoes;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlockStyle = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;

                __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set, "Pieces of the Past", true, unlockStyle, gameModeID);

                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }
        }
    }

    [HarmonyPatch(typeof(LevelSetsManager))]
    [HarmonyPatch("SetupLevelPaths")]
    public class LevelSetsManager__SetupLevelPaths__Patch
    {
        static void Postfix(LevelSetsManager __instance)
        {
            //__instance.AllLevelPaths_.Add("C:/Users/amaury/Documents/my games/Distance/Levels/MyLevels/Folder/test.bytes");

            FileSystem fs = new FileSystem();

            string path = $@"{fs.RootDirectory}/Data/Levels";

            foreach (string level in Directory.GetFiles(path, "*.bytes")) {
                __instance.AllLevelPaths_.Add(level.Replace(@"\", "/"));
            }
        }
    }


            /*
            [HarmonyPatch(typeof(BinaryDeserializer))]
            [HarmonyPatch("LoadFromFile", new Type[] { typeof(string) })]
            public class BinaryDeserializer__StartReading__Patch
            {
                static bool Prefix(BinaryDeserializer __instance, ref string fileName)
                {
                    if (fileName.StartsWith("Assets/"))
                    {
                        TextAsset level = SharedResources.EmbeddedResources.Bundle.LoadAsset<TextAsset>(fileName);

                        if ((UnityEngine.Object)level != (UnityEngine.Object)null)
                        {
                            __instance.CallPrivateMethod("Initialize", (Dictionary<uint, object>)null);
                            __instance.CallPrivateMethod("StartReading", new MemoryStream(level.bytes));
                        }
                        return false;
                    }
                    return true;
                }
            }
            */
        }
