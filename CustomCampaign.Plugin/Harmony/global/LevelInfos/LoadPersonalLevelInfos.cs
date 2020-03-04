using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelInfos), "LoadPersonalLevelInfos")]
    internal static class LoadPersonalLevelInfos
    {
        internal static void Postfix(ref LevelInfos __result)
        {
            foreach (var path in Campaigns.LevelPaths)
            {
                if (__result.LevelPathsToLevelInfos_.ContainsKey(path))
                {
                    __result.LevelPathsToLevelInfos_.Remove(path);
                }
                __result.LevelPathsToLevelInfos_.Add(path, Util.LevelInfoFromPath(path));
            }
        }
    }
}
