using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    internal static class UpdateLevelIntroTitleLogic
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            string level = Utils.Common.LevelFile;
            TextDecodeInLogic[] decode = __instance.GetComponentsInChildren<TextDecodeInLogic>(true);
            if (Utils.Campaign.IsCustomCampaignLevel(level) && !Utils.Campaign.CampaignUsesOldLevelIntro(level) && decode.Length is 0)
            {
                __instance.titleLabel_.gameObject.SetActive(true);
                __instance.titleLabel_.text = Utils.Campaign.GetLevelTitle(level).Space(1);
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.text = Utils.Campaign.GetLevelSubTitle(level).Space(1);
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
            }
        }
    }
}
