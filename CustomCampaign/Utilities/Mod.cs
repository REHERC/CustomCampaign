using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using static CustomCampaign.Storage;

namespace CustomCampaign
{
    public static partial class Mod
    {
        public static LevelPlaylist SelectedPlaylist;

        public enum LevelContext
        {
            Last = 1,
            Current = 2,
            Next = 4
        }

        static string LevelPath(LevelContext context)
        {
            switch (context)
            {
                case LevelContext.Last:
                    return G.Sys.GameManager_.LastLevelPath_;
                case LevelContext.Next:
                    return G.Sys.GameManager_.NextLevelPath_;
                default:
                    return G.Sys.GameManager_.LevelPath_;
            }
        }
    }

    public static partial class Mod
    {
        public static bool IsCustomCampaignLevel(LevelContext context)
        {
            string currentpath = LevelPath(context).NormPath();
            foreach (var campaign in Storage.Campaigns)
            {
                foreach (var level in campaign.Levels.GetAllLevelNameAndPathPairs())
                {
                    string path = level.levelPath_.NormPath();
                    if (currentpath == path)
                        return true;
                }
            }

            return false;
        }

        public static bool IsCustomCampaignPlaylist()
        {
            if (SelectedPlaylist is null || SelectedPlaylist.Playlist_.Count == 0) return false;
            List<LevelNameAndPathPair> levellist = SelectedPlaylist.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            return firstpath.NormPath().StartsWith(workshoppath);
        }

        private static CampaignLevelInfo GetLevel(string path)
        {
            foreach (var level in from lvl in Storage.Levelnfos where path.NormPath() == lvl.Key.NormPath() select lvl.Value)
                return level;
            return (Storage.CampaignLevelInfo)null;
        }

        public static string GetLevelTitle()
        {
            Storage.CampaignLevelInfo level = GetLevel(LevelPath(LevelContext.Current));
            return level is null ? string.Empty : level.name;
        }

        public static string GetLevelSubTitle()
        {
            Storage.CampaignLevelInfo level = GetLevel(LevelPath(LevelContext.Current));
            return level is null ? string.Empty : level.sector;
        }

        public static Texture GetLevelLoadingBackground()
        {
            Storage.CampaignLevelInfo level = GetLevel(LevelPath(LevelContext.Next));

            if (level != null && level.wallpaper != "" && File.Exists(level.wallpaper))
            {
                byte[] image = File.ReadAllBytes(Path.GetFullPath(level.wallpaper));
                Texture2D background = new Texture2D(2, 2);
                background.LoadImage(image);
                return background;
            }

            return (Texture)null;
        }

        public static Texture GetCampaignLogo()
        {
            if (SelectedPlaylist is null || SelectedPlaylist.Playlist_.Count == 0) return (Texture)null;

            List<LevelNameAndPathPair> levellist = SelectedPlaylist.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            if (firstpath.NormPath().StartsWith(workshoppath))
            {
                string reducedpath = firstpath.Substring(workshoppath.Length);
                string campaignname = reducedpath.Substring(0, reducedpath.NormPath().IndexOf("/"));

                var linq_query = from c in Storage.Campaigns where c.DirectoryName.ToLower() == campaignname.ToLower() select c;
                foreach (var campaign in linq_query)
                {
                    byte[] image = File.ReadAllBytes(Path.GetFullPath($"{campaign.Directory}/{campaign.LogoPath}"));
                    Texture2D logo = new Texture2D(2, 2);
                    logo.LoadImage(image);

                    return logo;
                }
            }
            return (Texture)null;
        }

        public static string GetCampaignRoot()
        {
            if (SelectedPlaylist is null || SelectedPlaylist.Playlist_.Count == 0) return null;

            List<LevelNameAndPathPair> levellist = SelectedPlaylist.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            if (firstpath.NormPath().StartsWith(workshoppath))
            {
                string reducedpath = firstpath.Substring(workshoppath.Length);
                string campaignname = reducedpath.Substring(0, reducedpath.NormPath().IndexOf("/"));

                var linq_query = from c in Storage.Campaigns where c.DirectoryName.ToLower() == campaignname.ToLower() select c;
                foreach (var campaign in linq_query)
                    return $"{Plugin.LevelsFolder()}/WorkshopLevels/{campaign.DirectoryName}".NormPath(); ;
            }
            return null;
        }

        public static string GetCampaignName()
        {
            if (SelectedPlaylist is null || SelectedPlaylist.Playlist_.Count == 0) return string.Empty;

            List<LevelNameAndPathPair> levellist = SelectedPlaylist.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            if (firstpath.NormPath().StartsWith(workshoppath))
            {
                string reducedpath = firstpath.Substring(workshoppath.Length);
                string campaignname = reducedpath.Substring(0, reducedpath.NormPath().IndexOf("/"));

                var linq_query = from c in Storage.Campaigns where c.DirectoryName.ToLower() == campaignname.ToLower() select c;
                foreach (var campaign in linq_query)
                    return campaign.Name;
            }
            return string.Empty;
        }

        public static string GetCampaignDescription()
        {
            if (SelectedPlaylist is null || SelectedPlaylist.Playlist_.Count == 0) return string.Empty;

            List<LevelNameAndPathPair> levellist = SelectedPlaylist.GetLevelSet();
            string firstpath = levellist[0].levelPath_;
            string workshoppath = $"{Plugin.LevelsFolder()}/WorkshopLevels/".NormPath();
            if (firstpath.NormPath().StartsWith(workshoppath))
            {
                string reducedpath = firstpath.Substring(workshoppath.Length);
                string campaignname = reducedpath.Substring(0, reducedpath.NormPath().IndexOf("/"));

                var linq_query = from c in Storage.Campaigns where c.DirectoryName.ToLower() == campaignname.ToLower() select c;
                foreach (var campaign in linq_query)
                    return campaign.Description;
            }
            return string.Empty;
        }
    }
}
