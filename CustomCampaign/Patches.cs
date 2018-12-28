using System;
using Harmony;
using Serializers;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("CreateEntries")]
    public class LevelGridMenu__CreateEntries__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_") | true;

            GameModeID mode = GameModeID.LostToEchoes;
            LevelType context = LevelType.Official;
            LevelGridMenu.PlaylistEntry.UnlockStyle unlock = LevelGridMenu.PlaylistEntry.UnlockStyle.None;

            LevelPlaylist playlist = new LevelPlaylist
            {
                Name_ = "Custom Campaign"
            };


            playlist.Add(new LevelPlaylist.ModeAndLevelInfo(mode, "Terminus", "OfficialLevels/Terminus.bytes"));
            playlist.Add(new LevelPlaylist.ModeAndLevelInfo(mode, "Terminus", "OfficialLevels/01.bytes"));
            playlist.Add(new LevelPlaylist.ModeAndLevelInfo(mode, "Factory Reset", "MyLevels/factory reset.bytes"));

            LevelSet set = new LevelSet();
            foreach (var level in playlist.GetLevelSet())
                set.AddLevel(level.levelName_, level.levelPath_, context);
                        
            __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set, playlist.Name_, true, unlock, mode);
            __instance.buttonList_.SortAndUpdateVisibleButtons();
        }
    }


    [HarmonyPatch(typeof(LevelSetsManager))]
    [HarmonyPatch("SetupLevelPaths")]
    public class LevelSetsManager__SetupLevelPaths__Patch
    {
        static void Postfix(LevelSetsManager __instance)
        {
            
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
