using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
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

                set.AddLevel("Broken Symmetry", "Resources/Levels/Broken Symmetry.bytes", LevelType.Official);
                set.AddLevel("Lost Society", "Resources/Levels/Lost Society.bytes", LevelType.Official);
                
                GameModeID gameModeID = GameModeID.LostToEchoes;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlockStyle = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                
                __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", set, "Pieces of the Past", true, unlockStyle, gameModeID);

                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }
        }
    }
}
