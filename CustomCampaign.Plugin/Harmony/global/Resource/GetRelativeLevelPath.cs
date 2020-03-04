using CustomCampaign.Storage;
using Harmony;
using System;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(Resource), "GetRelativeLevelPath", new Type[] { typeof(string), typeof(bool) })]
    internal static class GetRelativeLevelPath
    {
        internal static bool Prefix(ref string absoluteLevelPath, ref string __result)
        {
            if (Campaigns.LevelPaths?.Contains(absoluteLevelPath) == true)
            {
                __result = absoluteLevelPath;
                return false;
            }
            return true;
        }
    }
}
