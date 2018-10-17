using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                LevelSet set = new LevelSet();

                //set.AddLevel("Broken Symmetry", "G:/Steam/steamapps/common/Distance/Distance_Data/Resources/Levels/Broken Symmetry.bytes", LevelType.Official);
                //set.AddLevel("Lost Society", "G:/Steam/steamapps/common/Distance/Distance_Data/Resources/Levels/Lost Society.bytes", LevelType.Official);
                set.AddLevel("Factory Reset", "C:/Users/amaury/Documents/My Games/Distance/Levels/MyLevels/factory reset.bytes", LevelType.Official);
                set.AddLevel("Obscuration", "C:/Users/amaury/Documents/My Games/Distance/Levels/MyLevels/Obscuration.bytes", LevelType.Official);


                GameModeID gameModeID = GameModeID.LostToEchoes;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlockStyle = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;

                __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set, "Pieces of the Past", true, unlockStyle, gameModeID);

                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }
        }
    }

    [HarmonyPatch(typeof(BinaryDeserializer))]
    [HarmonyPatch("StartReading", new Type[] {typeof(string)})]
    public class BinaryDeserializer__StartReading__Patch
    {
        static void Prefix(ref string fileName)
        {
            if (fileName.Contains(".bytes"))
            {
                //Console.WriteLine($"BinaryDeserializer::StartReading<string>(\"{fileName}\");");
            }
        }
    }

    [HarmonyPatch(typeof(File))]
    [HarmonyPatch("Exists", new Type[] { typeof(string) })]
    public class File__Exists__Patch
    {
        /*static bool Prefix(string path)
        {
            if (path.Contains(".bytes"))
            {
                Console.WriteLine($"File::Exists<string>(\"{path}\");");
            }
            return true;
        }*/

        static void Postfix(bool __result, string path)
        {
            if (__result && path.Contains(".bytes"))
            {
                Console.WriteLine($"File::Exists<string>(\"{path}\");");
            }
        }
    }

    [HarmonyPatch(typeof(BlackFadeLogic))]
    [HarmonyPatch("GetSectorNames")]
    public class BlackFadeLogic__GetSectorNames__Patch
    {
        static bool Prefix(BlackFadeLogic __instance, string[] __result)
        {
            if (G.Sys.GameManager_.ModeID_ == GameModeID.LostToEchoes)
            {
                __result = SectorNames.CustomSectors;
                return false;
            }
            return true;
        }
    }


    [HarmonyPatch(typeof(LevelSet))]
    [HarmonyPatch("AddLevel")]
    public class LevelSet__AddLevel__Patch
    {
        static void Prefix(LevelSet __instance, string levelName, string normalizedAbsoluteLevelPath)
        {
            //Console.WriteLine($"Added level to set: \"{levelName}\"@\"{normalizedAbsoluteLevelPath}\"");
        }
    }
}
