﻿using Events;
using Harmony;
using UnityEngine;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(AdventureMode), "UpdateMode")]
    internal static class UpdateAdventureMode
    {
        public static bool Prefix(AdventureMode __instance)
        {
            string path = Utils.Common.LevelFile;

            __instance.UpdateRaceModeDistanceToFinish();
            if (__instance.hasEnded_ || __instance.GetDisplayTime(0) > 0.0 || __instance.campaignPlusEnabled_)
            {
                return false;
            }
            __instance.hasEnded_ = true;
            if (!__instance.countdownDisabled_)
            {
                int currentPlaylistIndex = __instance.gameMan_.GetCurrentPlaylistIndex();
                PlayerDataLocal firstLocalPlayer = PlayerDataLocal.FirstLocalPlayer_;

                bool flag = !Utils.Campaign.IsCustomCampaignLevel(path) && (currentPlaylistIndex == 0 || currentPlaylistIndex == __instance.gameMan_.LevelPlaylist_.Count_ - 1);

                if (flag || __instance.HasFinished(firstLocalPlayer) || firstLocalPlayer is null || (firstLocalPlayer.Car_ is null || __instance.finishTriggerObj_ is null))
                {
                    return false;
                }

                if (Utils.Campaign.IsCustomCampaignLevel(path) && Utils.Campaign.GetLevelCountdown(path) == 0)
                {
                    return false;
                }
                __instance.finishTriggerObj_.transform.position = firstLocalPlayer.Car_.transform.position;
                __instance.finishTriggerObj_.SetActive(true);
            }
            else
            {
                StaticEvent<ZEvent.Data>.Broadcast(new ZEvent.Data("AdventureModeClockHitZero", true));
            }

            return false;
        }
    }
}
