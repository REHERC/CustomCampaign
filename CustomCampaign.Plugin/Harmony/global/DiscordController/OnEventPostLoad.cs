
using CustomCampaign.Data;
using Harmony;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(DiscordController), "OnEventPostLoad")]
    internal static class OnEventPostLoad
    {
        public static bool Prefix(DiscordController __instance)
        {
            bool rpc_overwrite = !Utils.Common.IsInLevelEditor() && Utils.Campaign.IsCustomCampaignLevel(Utils.Common.LevelFile);
            if (G.Sys.GameManager_.IsLevelEditorMode_ || !rpc_overwrite)
            {
                return true;
            }

            CampaignInfo info = Utils.Campaign.GetCampaign(Utils.Common.LevelFile);

            string rpc_imagekey = G.Sys.GameManager_.ModeID_ == GameModeID.Sprint ? "community_level" : "official_level";
            string rpc_mode = rpc_imagekey == "community_level" ? "Sprint" : info.Name;

            __instance.presence.state = "Custom Campaign";
            __instance.presence.largeImageKey = rpc_imagekey;

            __instance.presence.startTimestamp = 0L;
            __instance.presence.endTimestamp = 0L;
            __instance.presence.partySize = 0;
            __instance.presence.partyMax = 0;
            __instance.presence.smallImageKey = string.Empty;
            __instance.presence.smallImageText = string.Empty;
            __instance.presence.largeImageText = string.Empty;

            if (true || rpc_imagekey == "official_level")
            {
                __instance.presence.details = $"{rpc_mode} | {__instance.GetGameTypeString()}";
            }

            DiscordRpc.UpdatePresence(ref __instance.presence);

            return false;
        }
    }
}
