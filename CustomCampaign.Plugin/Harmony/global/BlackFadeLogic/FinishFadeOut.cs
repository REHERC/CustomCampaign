using Harmony;
using UnityEngine;

#if !LIMITED_COMPATIBILITY
namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(BlackFadeLogic), "FinishFadeOut")]
    internal static class BlackFadeLogicFinishFadeOut
    {
        public static void Postfix(BlackFadeLogic __instance)
        {
            string path = G.Sys.GameManager_.NextLevelPath_;
            if (Utils.Campaign.IsCustomCampaignLevel(path) && __instance.storedSceneToLoad_ != "MainMenu")
            {
                Texture background = Utils.Campaign.GetLevelWallpaper(path);
                if (background != null)
                {
                    __instance.menu_.loadingTexture_.mainTexture = background;
                }
                if (Utils.Campaign.GetLevelLoadingTextState(path))
                {
                    __instance.menu_.loadingLabel_.text = Utils.Campaign.GetLevelLoadingText(path);
                }
            }
        }
    }
}
#endif