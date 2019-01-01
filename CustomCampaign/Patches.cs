using Harmony;
using System;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu))]
    [HarmonyPatch("CreateEntries")]
    public class LevelGridMenu__CreateEntries__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            //TODO: add code to add the level playlist button thing to the campaign menu
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");

            if (flag_campaignmode)
            {
                GameModeID mode = GameModeID.Nexus;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlock = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;

                Console.WriteLine(Storage.Campaigns.Count);

                foreach (Storage.CampaignInfo campaign in Storage.Campaigns)
                {
                    Console.WriteLine(campaign.Name);
                    __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", campaign.Levels, campaign.Name, true, unlock, mode);
                    __instance.buttonList_.SortAndUpdateVisibleButtons();
                }
            }
        }
    }
}
