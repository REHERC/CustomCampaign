#pragma warning disable IDE0059, IDE0060
using Harmony;
using UnityEngine;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(AdventureMode), "GetDisplayTime")]
    internal static class GetAdventureModeDisplayedTime
    {
        public static bool Prefix(AdventureMode __instance, ref double __result)
        {
            string path = Utils.Common.LevelFile;

            bool flag = Utils.Campaign.IsCustomCampaignLevel(path) && Utils.Campaign.GetLevelCountdown(path) == 0;
            if (flag)
            {
                if (__instance.paused_)
                {
                    __result = __instance.pauseTime_;
                }
                else
                {
                    __result = Mathf.Max((float)Timex.ModeTime_, 0.0f);
                }
                return false;
            }

            return true;
        }
    }
}
