using Harmony;
using System.IO;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(Resource), "GetAbsoluteLevelPath")]
    internal static class GetAbsoluteLevelPath
    {
        internal static bool Prefix(string relativeLevelPath, ref string __result)
        {
            if (!string.IsNullOrEmpty(relativeLevelPath))
            {
                FileInfo info = new FileInfo(relativeLevelPath);
                if (info.Exists)
                {
                    __result = Resource.NormalizePath(relativeLevelPath);
                    return false;
                }
            }
            return true;
        }
    }
}
