using Photon.Serialization;
using System;
using System.Collections.Generic;

#pragma warning disable RCS1001
namespace CustomCampaign
{
    public static class LockingSystem
    {
        public static void CreateProfile()
        {
            Serializer<Dictionary<string, int>> progress = GetProgress();
            foreach (var campaign in CampaignDatabase.Campaigns)
                if (!progress.Data.ContainsKey(campaign.Id))
                    progress.Data.Add(campaign.Id, 0);
            progress.Save();
        }

        public static bool IsLevelLocked(string levelfile)
        {
            string file = levelfile.NormPath(true);
            try
            {
                if (Utils.GetCampaignUnlockMode(levelfile) == Campaign.UnlockStyle.LevelSet)
                    return false;
                string campaign = Utils.GetCampaignId(file);
                int completion = GetProgress().Data[campaign];
                return Utils.GetLevelIndex(levelfile) > completion;
            }
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
            return false;
        }

        public static int GetCampaignProgress(string campaign)
        {
            return GetProgress().Data[campaign];
        }

        public static Serializer<Dictionary<string, int>> GetProgress()
        {
            return new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
        }

        public static void UnlockLevel(string levelfile)
        {
            Serializer<Dictionary<string, int>> progress = GetProgress();
            string campaign = Utils.GetCampaignId(levelfile);
            int index = Utils.GetLevelIndex(levelfile);
            int campaign_progress = GetCampaignProgress(campaign);
            if (index > campaign_progress)
                progress.Data[campaign] = index;
            progress.Save();
        }

        public static string GetProgressFilePath()
        {
            string profile = G.Sys.ProfileManager_.CurrentProfile_.FileName_;
            return $"{Resource.PersonalProfilesDirPath_}{profile}.json";
        }
    }
}
