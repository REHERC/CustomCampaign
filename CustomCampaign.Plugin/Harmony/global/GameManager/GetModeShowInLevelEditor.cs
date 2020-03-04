using Harmony;
using System.Linq;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(GameManager), "GetModeShowInLevelEditor")]
    internal static class GetModeShowInLevelEditor
    {
        public static readonly GameModeID[] Modes = new GameModeID[] {
            GameModeID.Challenge,
            GameModeID.ReverseTag,
            GameModeID.Adventure,
            GameModeID.Sprint,
            GameModeID.Stunt,
            GameModeID.LostToEchoes,
            GameModeID.MainMenu,
            GameModeID.Nexus
        };

        public static void Postfix(ref bool __result, GameModeID ID)
        {
            __result |= Modes.Contains(ID);
        }
    }
}
