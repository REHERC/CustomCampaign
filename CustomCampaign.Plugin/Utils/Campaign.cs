using CustomCampaign.Data;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CustomCampaign.Utils
{
    public static class Campaign
    {
        public static CampaignInfo GetCampaign(string levelfile)
        {
            string file = levelfile.NormPath(true);
            foreach (var campaign in Campaigns.Items)
            {
                if (campaign.Value.LevelPaths.Contains(file))
                {
                    return campaign.Value;
                }
            }
            return null;
        }

        public static CampaignInfo GetCampaignByGuid(string guid)
        {
            foreach (var campaign in Campaigns.Items)
            {
                if (campaign.Value.Id == guid)
                {
                    return campaign.Value;
                }
            }
            return null;
        }

        public static CampaignInfo GetCampaign(Assembly source)
        {
            foreach (var assembly in AddonSystem.GetAssemblies())
            {
                if (assembly.Key.Object == source)
                {
                    return GetCampaignByGuid(assembly.Value);
                }
            }
            return null;
        }

        public static CampaignInfo GetCampaignInline() => GetCampaign(Assembly.GetCallingAssembly());

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static CampaignInfo GetCampaign() => GetCampaign(Assembly.GetCallingAssembly());

        public static CampaignInfo GetCampaign(Api.Addon addon) => GetCampaignByGuid(GetAddonId(addon));

        public static string GetAddonId(Api.Addon addon)
        {
            foreach (var item in AddonSystem.GetAddons())
            {
                if (item.Key.Object == addon)
                {
                    return item.Value;
                }
            }
            return string.Empty;
        }

        public static string GetCampaignName(string levelfile) => GetCampaign(levelfile)?.Name;

        public static string GetCampaignName() => GetCampaign(Assembly.GetCallingAssembly())?.Name;

        public static string GetCampaignDescription(string levelfile) => GetCampaign(levelfile)?.Description;

        public static string GetCampaignDescription() => GetCampaign(Assembly.GetCallingAssembly())?.Description;

#if !LIMITED_COMPATIBILITY
        public static Texture GetCampaignLogo(string levelfile) => GetCampaign(levelfile)?.Logo;

        public static Texture GetCampaignLogo() => GetCampaign(Assembly.GetCallingAssembly())?.Logo;
#endif
        public static string GetCampaignId(string levelfile) => GetCampaign(levelfile)?.Id;
        public static string GetCampaignId() => GetCampaign(Assembly.GetCallingAssembly())?.Id;

        public static bool CampaignUsesOldLevelIntro(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign && campaign.UseOldIntro;
        }

        public static bool CampaignAvailableInArcade()
        {
            CampaignInfo campaign = GetCampaign(Assembly.GetCallingAssembly());
            return campaign && campaign.ShowInArcade;
        }

        public static bool CampaignAvailableInArcade(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign && campaign.ShowInArcade;
        }

        public static bool CampaignUsesOldLevelIntro()
        {
            CampaignInfo campaign = GetCampaign(Assembly.GetCallingAssembly());
            return campaign && campaign.UseOldIntro;
        }

        public static string[] GetCampaignAuthors(string levelfile) => GetCampaign(levelfile)?.Authors;

        public static string[] GetCampaignAuthors() => GetCampaign(Assembly.GetCallingAssembly())?.Authors;

        public static Models.Campaign.UnlockStyle GetCampaignUnlockMode(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign?.LockMode ?? Models.Campaign.UnlockStyle.Campaign;
        }

        public static Models.Campaign.UnlockStyle GetCampaignUnlockMode()
        {
            CampaignInfo campaign = GetCampaign(Assembly.GetCallingAssembly());
            return campaign?.LockMode ?? Models.Campaign.UnlockStyle.Campaign;
        }

        public static Models.Level GetLevelInfo(string levelfile)
        {
            string file = levelfile.NormPath(true);
            CampaignInfo campaign = GetCampaign(levelfile);
            foreach (Models.Level level in campaign.Levels)
            {
                if (level.file.NormPath(true) == file)
                {
                    return level;
                }
            }
            return new Models.Level();
        }

        public static string GetLevelTitle(string levelfile) => GetLevelInfo(levelfile).levelname;

        public static string GetLevelSubTitle(string levelfile) => GetLevelInfo(levelfile).levelname_sub;

#if !LIMITED_COMPATIBILITY
        public static string GetLevelWallpaperPath(string levelfile) => GetLevelInfo(levelfile).loading_wallpaper;

        public static Texture GetLevelWallpaper(string levelfile) => Common.LoadTexture(GetLevelWallpaperPath(levelfile));
#endif

        public static bool GetLevelDisplayIntroState(string levelfile) => GetLevelInfo(levelfile).display_intro_title;

        public static bool GetLevelLoadingTextState(string levelfile) => GetLevelInfo(levelfile).overwrite_loading_text;

        public static string GetLevelLoadingText(string levelfile) => GetLevelInfo(levelfile).loading_text;

        public static double GetLevelCountdown(string levelfile) => GetLevelInfo(levelfile).countdown;

        public static int GetLevelIndex(string levelfile)
        {
            try
            {
                string file = levelfile.NormPath(true);
                List<Models.Level> levels = GetCampaign(levelfile)?.Levels;
                int index = 0;
                foreach (Models.Level level in levels ?? new List<Models.Level>())
                {
                    if (level.file.NormPath(true) == file)
                        return index;
                    index++;
                }
                return index;
            }
            catch (NullReferenceException nre)
            {
                Plugin.Log.Exception(nre);
            }
            return -1;
        }

        public static bool IsCustomCampaignLevel(string levelfile) => !(GetCampaign(levelfile) is null);
    }
}
