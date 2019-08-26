using CustomCampaign.Data;
using CustomCampaign.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using CustomCampaign.Systems;
using CustomCampaign.Models;
using System.Reflection;
using System.Runtime.CompilerServices;

#pragma warning disable CS0168, RCS1001, RCS1206
namespace CustomCampaign
{
    public static class Util
    {
        #region Game Manager Fields
        public static string LevelFile => G.Sys.GameManager_.Level_.filePath_;
        public static string LastLevelFile => G.Sys.GameManager_.LastLevelPath_;
        public static string NextLevelFile => G.Sys.GameManager_.LastLevelPath_;
        #endregion
        #region Campaign Utils
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
        public static CampaignInfo GetCampaign(Assembly source)
        {
            foreach (var assembly in AddonSystem.GetAssemblies())
                if (assembly.Key.Object == source)
                    return GetCampaignByGuid(assembly.Value);
            return null;
        }
        public static CampaignInfo GetCampaignInline() => GetCampaign(Assembly.GetCallingAssembly());

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static CampaignInfo GetCampaign() => GetCampaign(Assembly.GetCallingAssembly());

        public static CampaignInfo GetCampaign(Api.Addon addon) => GetCampaignByGuid(GetAddonId(addon));

        public static string GetAddonId(Api.Addon addon)
        {
            List<KeyValuePair<ObjectWithGUID<Api.Addon>, string>> addons = AddonSystem.GetAddons();
            foreach (var item in addons)
                if (item.Key.Object == addon)
                    return item.Value;
            return string.Empty;
        }
        public static string GetCampaignName(string levelfile) => GetCampaign(levelfile)?.Name;
        public static string GetCampaignName() => GetCampaign(Assembly.GetCallingAssembly())?.Name;
        public static string GetCampaignDescription(string levelfile) => GetCampaign(levelfile)?.Description;
        public static string GetCampaignDescription() => GetCampaign(Assembly.GetCallingAssembly())?.Description;
        public static Texture GetCampaignLogo(string levelfile) => GetCampaign(levelfile)?.Logo;
        public static Texture GetCampaignLogo() =>GetCampaign(Assembly.GetCallingAssembly())?.Logo;
        public static string GetCampaignId(string levelfile) => GetCampaign(levelfile)?.Id;
        public static string GetCampaignId() => GetCampaign(Assembly.GetCallingAssembly())?.Id;
        public static string[] GetCampaignAuthors(string levelfile) => GetCampaign(levelfile)?.Authors;
        public static string[] GetCampaignAuthors() => GetCampaign(Assembly.GetCallingAssembly())?.Authors;
        public static Campaign.UnlockStyle GetCampaignUnlockMode(string levelfile)
        {
            CampaignInfo campaign = GetCampaign(levelfile);
            return campaign != null ? campaign.LockMode : Campaign.UnlockStyle.Campaign;
        }
        public static Campaign.UnlockStyle GetCampaignUnlockMode()
        {
            CampaignInfo campaign = GetCampaign(Assembly.GetCallingAssembly());
            return campaign != null ? campaign.LockMode : Campaign.UnlockStyle.Campaign;
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
        public static string GetLevelTitle(string levelfile) => GetLevelInfo(levelfile).levelname;
        public static string GetLevelSubTitle(string levelfile) => GetLevelInfo(levelfile).levelname_sub;
        public static string GetLevelWallpaperPath(string levelfile) => GetLevelInfo(levelfile).loading_wallpaper;
        public static Texture GetLevelWallpaper(string levelfile) =>LoadTexture(GetLevelWallpaperPath(levelfile));
        public static bool GetLevelDisplayIntroState(string levelfile) => GetLevelInfo(levelfile).display_intro_title;
        public static bool GetLevelLoadingTextState(string levelfile) => GetLevelInfo(levelfile).overwrite_loading_text;
        public static string GetLevelLoadingText(string levelfile) => GetLevelInfo(levelfile).loading_text;
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
        public static bool IsCustomCampaignLevel(string levelfile) =>!(GetCampaign(levelfile) is null);
        #endregion
        #region Api Utils
        public static string GetFilePath(string path)
        {
            if (string.IsNullOrEmpty(path) || path.Length < 2) return path;

            string result = "";
            switch (path[0])
            {
                case '@':
                    CampaignInfo info = GetCampaign(Assembly.GetCallingAssembly());
                    result = new FileInfo(Path.Combine(info.Location, path.Substring(1))).FullName;
                    break;
                case '#':
                    result = new FileInfo(Path.Combine(Assembly.GetCallingAssembly().Location, path.Substring(1))).FullName;
                    break;
                default:
                    return path;
            }
            return result;
        }
        #endregion
        #region Unity And Game Utils
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
            return LevelInfo.Create(path, settings);
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
        #endregion
        #region Other Utils
        public static void MakeDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }
        #endregion
    }
}