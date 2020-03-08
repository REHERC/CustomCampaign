using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Awake")]
    public static class LevelIntroAwake
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            if (Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile) && __instance.adventureFinal_)
            {
                __instance.gameObject.SetActive(true);
            }
        }
    }
}
