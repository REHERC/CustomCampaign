using CustomCampaign.Storage;
using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

#pragma warning disable RCS1001, CS0436
namespace CustomCampaign.Systems
{
    public static class LockingSystem
    {
        public static void CreateProfile()
        {
            Serializer<Dictionary<string, int>> progress = GetProgress();
            foreach (var campaign in CampaignDatabase.Campaigns)
                if (!progress.Data.ContainsKey(campaign.Value.Id))
                    progress.Data.Add(campaign.Value.Id, 0);
            progress.Save();
        }

        public static bool IsLevelLocked(string levelfile)
        {
            string file = levelfile.NormPath(true);
            try
            {
                if (Util.GetCampaignUnlockMode(levelfile) == Models.Campaign.UnlockStyle.LevelSet)
                    return false;
                string campaign = Util.GetCampaignId(file);
                int completion = GetCampaignProgress(campaign);
                return Util.GetLevelIndex(levelfile) > completion;
            }
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
            return false;
        }

        public static int GetCampaignProgress(string campaign)
        {
            if (string.IsNullOrEmpty(campaign)) return 0;
            Serializer<Dictionary<string, int>> serializer = GetProgress();
            if (!serializer.Data.ContainsKey(campaign))
            {
                serializer.Data.Add(campaign, 0);
                serializer.Save();
            }

            return serializer.Data[campaign];
        }

        public static Serializer<Dictionary<string, int>> GetProgress()
        {
            return new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
        }

        public static void UnlockLevel(string levelfile)
        {
            Serializer<Dictionary<string, int>> progress = GetProgress();
            string campaign = Util.GetCampaignId(levelfile);
            int index = Util.GetLevelIndex(levelfile);
            int campaign_progress = GetCampaignProgress(campaign);
            if (index > campaign_progress)
                progress.Data[campaign] = index;
            progress.Save();
        }

        public static string GetProgressFilePath()
        {
            string profile = G.Sys.ProfileManager_.CurrentProfile_.FileName_;
            return $"{Path.Combine(Resource.PersonalProfilesDirPath_, profile)}.json".NormPath(true);
        }
    }
}
