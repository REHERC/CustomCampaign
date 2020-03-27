using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(SectorPosterLogic), "Start")]
    internal static class StartSectorPosterLogic
    {
        internal static bool Prefix()
        {
            return !Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile);
        }
    }
}
