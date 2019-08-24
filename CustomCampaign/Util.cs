using CustomCampaign.Data;
using CustomCampaign.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

#pragma warning disable CS0168, RCS1001, RCS1206
namespace CustomCampaign
{
    public static class Util
    {
        #region "Campaign Utils"
        public static CampaignInfo GetCampaign(string levelfile)
        {
            string file = levelfile.NormPath(true);
            foreach (var campaign in CampaignDatabase.Campaigns)
                if (campaign.Value.LevelPaths.Contains(file))
                    return campaign.Value;
            return null;
        }

        public static CampaignInfo GetCampaignByGuid(string guid)
        {
            foreach (var campaign in CampaignDatabase.Campaigns)
                if (campaign.Value.Id == guid)
                    return campaign.Value;
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

        public static Models.Campaign.UnlockStyle GetCampaignUnlockMode(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign != null ? campaign.LockMode : Models.Campaign.UnlockStyle.Campaign;
        }

        public static Models.Level GetLevelInfo(string levelfile)
        {
            string file = levelfile.NormPath(true);
            CampaignInfo campaign = GetCampaign(levelfile);
            foreach (Models.Level level in campaign.Levels)
                if (level.file.NormPath(true) == file)
                    return level;
            return new Models.Level();
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
                result = LoadTexture(path) as Texture2D;
            }
            return result;
        }

        public static bool GetLevelDisplayIntroState(string levelfile)
        {
            return GetLevelInfo(levelfile).display_intro_title;
        }

        public static bool GetLevelLoadingTextState(string levelfile)
        {
            return GetLevelInfo(levelfile).overwrite_loading_text;
        }

        public static string GetLevelLoadingText(string levelfile)
        {
            return GetLevelInfo(levelfile).loading_text;
        }

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
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
            return -1;
        }

        public static bool IsCustomCampaignLevel(string levelfile)
        {
            return !(GetCampaign(levelfile) is null);
            //return GetLevelIndex(levelfile) >= 0;
        }
        #endregion

        public static GameObject FindByName(string name)
        {
            foreach (var go in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
                if (go.name == name)
                    return go as GameObject;
            return null;
        }

        public static LevelInfo LevelInfoFromPath(string path)
        {
            LevelSettings settings = LevelSettings.CreateAndLoadFromPath(path, out bool _);
            LevelInfo info = LevelInfo.Create(path, settings);

            return info;
        }

        public static Texture LoadTexture(string filepath)
        {
            Texture2D result = null;
            if (File.Exists(filepath))
            {
                byte[] imagedata = File.ReadAllBytes(filepath);
                result = new Texture2D(2, 2);
                result.LoadImage(imagedata);
            }
            return result;
        }
    }
}
