using CustomCampaign.Storage;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelEditorLevelNameSelectMenuLogic.LevelPathEntry), "Create")]
    internal static class CreateLevelPathEntry
    {
        internal static void Postfix(string absoluteLevelPath, ref LevelEditorLevelNameSelectMenuLogic.LevelPathEntry __result)
        {
            if (Campaigns.LevelPaths.Contains(absoluteLevelPath))
            {
                __result.labelText_ = $"CustomCampaignLevel/{__result.labelText_}";
                __result.relativeLevelPath_ = absoluteLevelPath;
                __result.color_ = Colors.yellow;
            }
        }
    }
}
