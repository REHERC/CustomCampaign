using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(AdventureMode), "PostLoadLevel")]
    internal static class AdventureModePostLoadLevel
    {
        public static void Postfix(AdventureMode __instance)
        {
            string path = Utils.Common.LevelFile;
            if (Utils.Campaign.IsCustomCampaignLevel(path)) {
                __instance.countdownDisabled_ = false;
                double countdown = Utils.Campaign.GetLevelCountdown(path);
                __instance.customTime_ = (float)countdown;
                if (countdown == 0)
                {
                    __instance.countdownDisabled_ = true;
                }
            }
        }
    }
}