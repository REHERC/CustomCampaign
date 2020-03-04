using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(Resource), "IsWorkshopLevelPath")]
    internal static class IsWorkshopLevelPath
    {
        internal static bool Prefix(string levelPath, ref bool __result)
        {
            if (Campaigns.LevelPaths.Contains(levelPath))
            {
                __result = false;
                return false;
            }
            return true;
        }
    }
}
