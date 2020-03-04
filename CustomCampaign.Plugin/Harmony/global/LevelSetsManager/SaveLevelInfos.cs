using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelSetsManager), "SaveLevelInfos")]
    internal static class SaveLevelInfos
    {
        internal static bool Prefix(ref LevelSetsManager __instance)
        {
            if (!__instance.communityLevelInfos_)
            {
                return true;
            }
            LevelInfos temp = LevelInfos.Create();
            foreach (var level in __instance.communityLevelInfos_.LevelPathsToLevelInfos_)
            {
                if (!Campaigns.LevelPaths.Contains(level.Key))
                {
                    temp.levelPathsToLevelInfos_.Add(level.Key, level.Value);
                }
            }

            temp.SavePersonalLevelInfos();
            temp.Destroy();
            return false;
        }
    }
}
