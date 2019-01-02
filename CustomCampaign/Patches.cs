using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
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
                GameModeID mode = GameModeID.Nexus;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlock = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                foreach (Storage.CampaignInfo campaign in Storage.Campaigns)
                {
                    __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", campaign.Levels, campaign.Name, true, unlock, mode);
                    __instance.buttonList_.SortAndUpdateVisibleButtons();
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("SetDisplayedInfoForSelectedPlaylist")]
    public class LevelGridMenu__SetDisplayedInfoForSelectedPlaylist__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            LevelPlaylist levels = __instance.DisplayedEntry_.Playlist_;
            List<LevelNameAndPathPair> levellist = levels.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            if (firstpath.NormPath().StartsWith(workshoppath))
            {
                string reducedpath = firstpath.Substring(workshoppath.Length);
                string campaignname = reducedpath.Substring(0, reducedpath.NormPath().IndexOf("/"));

                Console.WriteLine(campaignname);
                var linq_query = from c in Storage.Campaigns where c.DirectoryName.ToLower() == campaignname.ToLower() select c;
                foreach (var campaign in linq_query)
                {
                    Console.WriteLine(campaign.Description);
                    __instance.modeDescription_.text = __instance.gridDescription_.text = campaign.Description;
                }
            }
        }
    }
}
