using Photon.Serialization;
using System.Collections.Generic;
using System.Linq;
using static CustomCampaign.Plugin;

#pragma warning disable IDE0017
namespace CustomCampaign
{
    public static class LockingManager
    {
        public static bool IsLevelLocked(string levelfile)
        {
            string file = levelfile.NormPath(true);
            string workshop = $"{LevelsFolder()}/WorkshopLevels/".NormPath();
            string relativepath = file.Substring(workshop.Length);
            string campaign = relativepath.Split('/')[0].ToLowerInvariant();
            while (file.EndsWith("/"))
                file = file.TrimEnd('/');
            int index = 1;
            foreach (var level in Storage.Levelnfos)
            {
                string lvl = level.Key.NormPath(true);
                while (lvl.EndsWith("/"))
                    lvl = lvl.TrimEnd('/');
                if (lvl == file)
                    index = level.Value.index - 1;
            }
            int progress = GetCampaignProgress(campaign);
            return index > progress;
        }
        
        public static int GetCampaignProgress(string campaign)
        {
            Serializer<Dictionary<string, int>> Progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, ProgressFilePath(), true);
            if (Progress.Data.ContainsKey(campaign.ToLower()))
                return Progress.Data[campaign.ToLower()];
            else
                return 0;
        }

        public static void Load()
        {
            CreateProfile();
        }

        private static void CreateProfile()
        {
            Serializer<Dictionary<string, int>> Progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, ProgressFilePath(), true);
            foreach (var campaign in Storage.Campaigns)
                if (!Progress.Data.ContainsKey(campaign.DirectoryName.ToLower()))
                    Progress.Data.Add(campaign.DirectoryName.ToLower(), 0);
            Progress.Save();
        }

        private static string ProgressFilePath()
        {
            string Profile = G.Sys.ProfileManager_.CurrentProfile_.FileName_;
            return $@"{$@"{ProfilesFolder()}/Progress/".NormPath()}/{Profile}.json";
        }
    }
}
