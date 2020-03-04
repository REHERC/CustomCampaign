using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(PauseMenuLogic), "Update")]
    internal static class PauseMenuLogicUpdate
    {
        public static void Postfix(PauseMenuLogic __instance)
        {
            string path = Util.LevelFile.NormPath(true);
            if (G.Sys.GameManager_.PauseMenuOpen_ && Util.IsCustomCampaignLevel(path))
            {
                __instance.gameMode_.text = Util.GetCampaignName(path);
                __instance.gameModeDescription_.text = Util.GetCampaignDescription(path) + "...";
                __instance.upperRightGroup_.SetActive(false);
                __instance.levelName_.text = "[AAAAAA]Level:[-] [FFFFFF]" + G.Sys.GameManager_.LevelName_;
            }
        }
    }
}
