using System;
using System.IO;
using UnityEngine;

#pragma warning disable CS0168
namespace CustomCampaign
{
    public static class CampaignUtils
    {
        public static CampaignInfo GetCampaign(string levelfile)
        {
            string file = levelfile.NormPath(true);
            foreach (CampaignInfo campaign in Storage.Campaigns)
                foreach (Campaign.Level level in campaign.Levels)
                    if (level.file.NormPath(true) == file)
                        return campaign;
            return null;
        }

        public static string GetCampaignName(string levelfile)
        {
            return GetCampaign(levelfile)?.Name;
        }

        public static string GetCampaignDescription(string levelfile)
        {
            return GetCampaign(levelfile)?.Description;
        }

        public static Texture GetCampaignLogo(string levelfile)
        {
            return GetCampaign(levelfile)?.Logo;
        }

        public static string GetCampaignId(string levelfile)
        {
            return GetCampaign(levelfile)?.Id;
        }

        public static string[] GetCampaignAuthors(string levelfile)
        {
            return GetCampaign(levelfile)?.Authors;
        }

        public static Campaign.UnlockStyle GetCampaignUnlockMode(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign != null ? campaign.LockMode : Campaign.UnlockStyle.Campaign;
        }

        public static Campaign.Level GetLevelInfo(string levelfile)
        {
            string file = levelfile.NormPath(true);
            CampaignInfo campaign = GetCampaign(levelfile);
            foreach (Campaign.Level level in campaign.Levels)
                if (level.file.NormPath(true) == file)
                    return level;
            return new Campaign.Level();
        }

        public static string GetLevelTitle(string levelfile)
        {
            return GetLevelInfo(levelfile).levelname;
        }

        public static string GetLevelSubTitle(string levelfile)
        {
            return GetLevelInfo(levelfile).levelname_sub;
        }

        public static string GetLevelWallpaperPath(string levelfile)
        {
            return GetLevelInfo(levelfile).loading_wallpaper;
        }

        public static Texture GetLevelWallpaper(string levelfile)
        {
            Texture2D result = null;
            string path = GetLevelWallpaperPath(levelfile);
            if (File.Exists(path))
            {
                byte[] image = File.ReadAllBytes(path);
                result = new Texture2D(2, 2);
                result.LoadImage(image);
            }
            return result;
        }

        public static int GetLevelIndex(string levelfile)
        {
            try
            {
                string file = levelfile.NormPath(true);
                Campaign.Level[] levels = GetCampaign(levelfile)?.Levels.ToArray();
                int index = 0;
                foreach (Campaign.Level level in levels)
                {
                    if (level.file.NormPath(true) == file)
                        return index;
                    index++;
                }
            }
            catch (Exception pizza) { }
            return -1;
        }

        public static bool IsCustomCampaignLevel(string levelfile)
        {
            return GetLevelIndex(levelfile) >= 0;
        }
    }
}
