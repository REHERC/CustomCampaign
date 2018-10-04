using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("CreateAndAddCampaignLevelSet")]
    public class LevelGridMenu__CreateAndAddCampaignLevelSet__Patch
    {
        static void Prefix(LevelGridMenu __instance, string name)
        {
            Console.WriteLine($"Campaing level set: {name}");
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("CreateEntries")]
    public class LevelGridMenu__CreateEntries__Patch
    {
        static void Prefix(LevelGridMenu __instance)
        {
            //Console.WriteLine(G.Sys.ProfileManager_.CurrentProfile_.MainMenuLevelRelativePath_);

            GameObject PLAYLIST_GAMEOBJECT = new GameObject("CustomLevelPlaylist");

            LevelPlaylist PLAYLIST_COMPONENT = PLAYLIST_GAMEOBJECT.AddComponent<LevelPlaylist>();

            PLAYLIST_COMPONENT.Add(new LevelPlaylist.ModeAndLevelInfo(GameModeID.Sprint, "Echoes", "OfficialLevels/Echoes.bytes"));
            //PLAYLIST_COMPONENT.Add(new LevelPlaylist.ModeAndLevelInfo(GameModeID.Sprint, "Forgotten Utopia", "Levels/Forgotten Utopia.bytes"));

            PLAYLIST_COMPONENT.Name_ = "Pieces of the Past";

            PLAYLIST_COMPONENT.RemoveInvalidLevelsFromPlaylist();
            PLAYLIST_COMPONENT.PrintRemainingLevelsInSet();

            bool FLAG_CAMPAIGNMODE = __instance.GetPrivateField<bool>("isCampaignMode_");
            LevelGridMenu.PlaylistEntry.Type PLAYLIST_TYPE = FLAG_CAMPAIGNMODE ? LevelGridMenu.PlaylistEntry.Type.Campaign : LevelGridMenu.PlaylistEntry.Type.Campaign;
            LevelGridMenu.PlaylistEntry.UnlockStyle PLAYLIST_UNLOCK = LevelGridMenu.PlaylistEntry.UnlockStyle.None;

            __instance.CallPrivateMethod("CreateAndAddEntry", PLAYLIST_COMPONENT, PLAYLIST_TYPE, true, PLAYLIST_UNLOCK, GameModeID.Sprint);

            //LevelSet POTP = new LevelSet();
            //POTP_SET.AddLevel("Destination Unknown", "G:/Steam/steamapps/common/Distance/Distance_Data/Resources/Levels/Destination Unknown.bytes", LevelType.Official);
            //POTP_SET.AddLevel("Forgotten Utopia", "G:/Steam/steamapps/common/Distance/Distance_Data/Resources/Levels/Forgotten Utopia.bytes", LevelType.Official);
            //LevelPlaylist POTP_PLAYLIST = LevelPlaylist.Create(POTP, "POTP", GameModeID.Adventure);
            //__instance.CallPrivateMethod("CreateAndAddEntry", POTP_PLAYLIST, LevelGridMenu.PlaylistEntry.Type.Campaign, LevelGridMenu.PlaylistEntry.UnlockStyle.None,String.Empty);
        }

        static void Postfix(LevelGridMenu __instance)
        {

        }
    }
}
