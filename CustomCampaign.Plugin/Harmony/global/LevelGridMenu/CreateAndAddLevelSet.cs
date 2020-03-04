using CustomCampaign.Storage;
using Harmony;
using System;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateAndAddLevelSet", new Type[] { typeof(LevelSet), typeof(string), typeof(LevelGridMenu.PlaylistEntry.Type), typeof(LevelGroupFlags) })]
    internal static class CreateAndAddLevelSet
    {
        public static void Prefix(
            ref LevelSet set, ref LevelGridMenu.PlaylistEntry.Type type)
        {
            if (type != LevelGridMenu.PlaylistEntry.Type.Campaign)
            {
                foreach (var level in set.GetAllLevelNameAndPathPairs())
                {
                    if (Campaigns.LevelPaths.Contains(level.levelPath_.NormPath(true)))
                    {
                        set.RemoveLevel(level.levelPath_.Normalize());
                    }
                }
            }
        }
    }
}
