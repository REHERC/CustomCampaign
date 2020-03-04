﻿
using Harmony;
using System.Linq;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(AchievementManager), "Unlock")]
    internal static class UnlockAchievement
    {
        internal static readonly EAchievements[] blocked_achievements = new EAchievements[]
        {
            EAchievements.Adventurer,
            EAchievements.BlastFromThePast,
            EAchievements.CheatTheSystem,
            EAchievements.FlightlessDeparture,
            EAchievements.MovingForward,
            EAchievements.PumpkinKing,
            EAchievements.SpeedRunner,
            EAchievements.StillAlive,
            EAchievements.TheOtherSide,
            EAchievements.VendorBender,
            EAchievements.Worthy
        };

        internal static bool Prefix(EAchievements a)
        {
            if (Util.IsCustomCampaignLevel(Util.LevelFile) || Util.IsCustomCampaignLevel(Util.LastLevelFile))
            {
                if (blocked_achievements.Contains(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
