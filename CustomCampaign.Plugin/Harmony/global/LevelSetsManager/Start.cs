using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelSetsManager), "Start")]
    internal static class LevelSetsManagerStart
    {
        internal static void Postfix(LevelSetsManager __instance)
        {
            foreach (var path in Campaigns.LevelPaths)
            {
                __instance.allLevelPaths_.Add(path);
                __instance.myLevelsLevelFilePaths_.Add(path);
                LevelInfo info = Util.LevelInfoFromPath(path);
                __instance.AddLevelNameAndPathPair(path, info, __instance.allLevelNameAndPathPairs_);
                __instance.AddLevelNameAndPathPair(path, info, __instance.myLevelsLevelNameAndPathPairs_);
            }
        }
    }
}
