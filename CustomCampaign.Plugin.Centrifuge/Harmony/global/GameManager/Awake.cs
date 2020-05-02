using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(GameManager), "Awake")]
    public static class GameManager_Awake
    {
        public static void Postfix(GameManager __instance)
        {
            Events.Managers.GameManagerLoaded.Broadcast(new Events.Managers.GameManagerLoaded.Data(__instance));
        }
    }
}