using System;
using System.Collections.Generic;
using System.IO;
using Harmony;
using Serializers;
using UnityEngine;

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
                set.AddLevel("Test", $@"{LevelsFolder}/Folder/test.bytes", LevelType.Official);



                GameModeID gameModeID = GameModeID.LostToEchoes;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlockStyle = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;

                __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set, "Pieces of the Past", true, unlockStyle, gameModeID);

                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }
        }
    }

    //[HarmonyPatch(typeof(File))]
    //[HarmonyPatch("Exists", new Type[] { typeof(string) })]
    public class File__Exists__Patch
    {
        static bool Prefix(ref string path)
        {
            path.PathNormalize();
            path = path.PluginLevelRedirect();
            return true;
        }
    }

    //[HarmonyPatch(typeof(File))]
    //[HarmonyPatch("Open", new Type[] { typeof(string), typeof(FileMode), typeof(FileAccess) })]
    public class File__Open__Patch
    {
        //static bool Prefix(bool __result, ref string path)
        //{
            
        //}
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
