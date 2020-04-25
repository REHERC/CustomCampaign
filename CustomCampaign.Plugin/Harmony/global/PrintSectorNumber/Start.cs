using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(PrintSectorNumber), "Start")]
    internal static class StartPrintSectorNumber
    {
        internal static bool Prefix()
        {
            return !Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile) || Utils.Common.IsInLevelEditor();
        }
    }
}
