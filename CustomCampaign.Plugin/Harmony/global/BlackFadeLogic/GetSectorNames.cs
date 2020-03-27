using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(BlackFadeLogic), "GetSectorNames")]
    internal static class GetSectorNames
    {
        internal static bool Prefix(ref string[] __result)
        {
           if (Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile))
           {
                int index = G.Sys.GameManager_.GetCurrentPlaylistIndex();

                string[] sectors = new string[index + 1];

                for (int i = 0; i < sectors.Length; i++)
                {
                    sectors[i] = ":";
                }

                __result = sectors;
                return false;
           }
            return true;
        }
    }
}
