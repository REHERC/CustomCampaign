#pragma warning disable IDE0059, IDE0060
using Harmony;
using UnityEngine;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(AdventureMode), "GetDisplayTime")]
    internal static class GetAdventureModeDisplayTime
    {
        public static bool Prefix(AdventureMode __instance, double __result)
        {
            string path = Utils.Common.LevelFile;

            if (G.Sys.GameManager_.ModeID_ is GameModeID.Adventure && Utils.Campaign.IsCustomCampaignLevel(path) && Utils.Campaign.GetLevelCountdown(path) == 0)
            {
                if (__instance.paused_)
                {
                    __result = __instance.pauseTime_;
                }
                __result = Mathf.Max((float)Timex.ModeTime_, 0.0f);
                return false;
            }

            return true;
        }
    }
}
