using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(Resource), "GetLevelType")]
    internal static class GetLevelType
    {
        internal static bool Prefix(string normalizedLevelPath, ref LevelType __result)
        {
            if (Campaigns.LevelPaths.Contains(normalizedLevelPath))
            {
                __result = LevelType.My;
                return false;
            }
            return true;
        }
    }
}