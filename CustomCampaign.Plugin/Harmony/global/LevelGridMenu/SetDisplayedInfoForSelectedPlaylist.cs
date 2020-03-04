﻿using CustomCampaign.Storage;
using Harmony;
using System;

#if !LIMITED_COMPATIBILITY
namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(LevelGridMenu), "SetDisplayedInfoForSelectedPlaylist")]
    internal static class LevelGridMenuSetDisplayedInfoForSelectedPlaylist
    {
        public static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.isCampaignMode_;
            if (flag_campaignmode && __instance.isActiveAndEnabled)
            {
                try
                {
                    LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
                    string level = playlist.GetLevelSet()[0].levelPath_.NormPath(true);
                    if (Util.IsCustomCampaignLevel(level))
                    {
                        __instance.modeDescription_.text = __instance.gridDescription_.text = Util.GetCampaignDescription(level);
                        __instance.campaignLogo_.mainTexture = Util.GetCampaignLogo(level);
                    }
                }
                catch (NullReferenceException nre)
                {
                    Plugin.Log.Exception(nre);
                }
            }
        }
    }
}
#endif