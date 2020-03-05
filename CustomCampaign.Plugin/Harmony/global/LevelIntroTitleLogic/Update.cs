using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    internal static class UpdateLevelIntroTitleLogic
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            TextDecodeInLogic[] decode = __instance.GetComponentsInChildren<TextDecodeInLogic>(true);
            string path = G.Sys.GameManager_.LevelPath_;
            if (Utils.Campaign.IsCustomCampaignLevel(path) && decode.Length is 0)
            {
                __instance.titleLabel_.text = Utils.Campaign.GetLevelTitle(path).Space(1);
                __instance.subtitleText_.text = Utils.Campaign.GetLevelSubTitle(path).Space(1);
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
            }
        }
    }
}
