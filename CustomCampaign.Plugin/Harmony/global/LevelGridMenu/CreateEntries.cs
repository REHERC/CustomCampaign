using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    internal static class LevelGridMenuCreateEntries
    {
        public const LevelGridMenu.PlaylistEntry.UnlockStyle unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
        public const LevelGridMenu.PlaylistEntry.UnlockStyle sprint_unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.SprintCampaign;

        public static void Postfix(LevelGridMenu __instance)
        {
            if (__instance.DisplayType_ == LevelSelectMenuAbstract.DisplayType.GameLobby)
            {
                return;
            }

            LockingSystem.CreateProfile();
            if (__instance.isCampaignMode_)
            {
                foreach (var campaign in Campaigns.Items)
                {
                    if (campaign.Value.Enabled)
                    {
                        __instance.CreateAndAddCampaignLevelSet(campaign.Value.GetLevelSet(campaign.Value.GameMode, false), campaign.Value.Name, true, unlock_mode, campaign.Value.GameMode);
                    }
                }
            }
            else if (__instance.modeID_ == GameModeID.Sprint)
            {
                foreach (var campaign in Campaigns.Items)
                {
                    if (campaign.Value.Enabled && campaign.Value.ShowInArcade)
                    {
                        LevelSet set = campaign.Value.GetLevelSet(GameModeID.Sprint, true);

                        LevelPlaylist playlist = LevelPlaylist.Create(set, $"{Constants.Strings.CampaignEntry_Color}{campaign.Value.Name}[-]");

                        bool unlocked = LockingSystem.IsCampaignComplete(campaign.Value.Id);
                        __instance.CreateAndAddEntry(playlist, LevelGridMenu.PlaylistEntry.Type.Campaign, unlocked, sprint_unlock_mode);
                    }
                }
            }
            __instance.buttonList_.SortAndUpdateVisibleButtons();
        }
    }
}
