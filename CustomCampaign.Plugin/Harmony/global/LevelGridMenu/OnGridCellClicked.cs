
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelGridMenu), "OnGridCellClicked")]
    internal static class LevelGridMenuOnGridCellClicked
    {
        public static bool Prefix(LevelGridMenu __instance, ref int index)
        {
            LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
            string level = playlist.Playlist_[index].levelNameAndPath_.levelPath_;
            if (Util.GetCampaignUnlockMode(level) == Models.Campaign.UnlockStyle.LevelSet)
            {
                return true;
            }
            else
            {
                bool flag = Util.IsCustomCampaignLevel(level) && LockingSystem.IsLevelLocked(level);
                if (flag)
                {
                    G.Sys.MenuPanelManager_.ShowTimedOk(10, Constants.Strings.LevelLocked_Message, Constants.Strings.LevelLocked_Title);
                }
                return !flag;
            }
        }
    }
}
