using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(PauseMenuLogic), "Update")]
    internal static class PauseMenuLogicUpdate
    {
        public static void Postfix(PauseMenuLogic __instance)
        {
            if (Utils.Common.IsInLevelEditor())
            {
                return;
            }

            string path = Utils.Common.LevelFile.NormPath(true);

            if (G.Sys.GameManager_.PauseMenuOpen_ && Utils.Campaign.IsCustomCampaignLevel(path))
            {
                __instance.gameMode_.text = Utils.Campaign.GetCampaignName(path);
                __instance.gameModeDescription_.text = Utils.Campaign.GetCampaignDescription(path) + "...";
                __instance.upperRightGroup_.SetActive(false);
                __instance.levelName_.text = "[AAAAAA]Level:[-] [FFFFFF]" + G.Sys.GameManager_.LevelName_;
            }
        }
    }
}
