
using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelIntroTitleLogic), "SetIdlePosition")]
    public static class LevelIntroIdlePosition
    {
        public static bool Prefix(LevelIntroTitleLogic __instance)
        {
            if (!Utils.Common.IsInLevelEditor() && Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile) && Utils.Campaign.CampaignUsesOldLevelIntro(Utils.Common.LevelFile))
            {
                if (__instance.gameObject.name == Constants.Strings.LevelIntroPrefabEA_Name)
                {
                    return true;
                }

                __instance.subtitleText_ = __instance.titleText_;
                __instance.subtitleText_.enabled = false;

                __instance.topBar_.alpha = 0;
                __instance.bottomBar_.alpha = 0;
                __instance.titleLabel_.alpha = 0;
                __instance.titleTextE_.alpha = 0;
                __instance.titleText_.alpha = 0;
                __instance.subtitleText_.alpha = 0;

                return false;
            }

            return true;
        }
    }
}
