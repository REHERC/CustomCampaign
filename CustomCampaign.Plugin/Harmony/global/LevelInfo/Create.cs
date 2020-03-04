
using CustomCampaign.Storage;
using Harmony;
using System.IO;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelInfo), "Create")]
    internal static class CreateLevelInfo
    {
        internal static void Postfix(string levelPath, ref LevelInfo __result)
        {
            if (Campaigns.LevelPaths.Contains(levelPath))
            {
                __result.relativePath_ = levelPath;
                __result.fileNameWithoutExtension_ = Path.GetFileNameWithoutExtension(levelPath);
                __result.levelType_ = LevelType.My;
            }
        }
    }
}
