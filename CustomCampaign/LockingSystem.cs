using Photon.Serialization;
using System.Collections.Generic;

namespace CustomCampaign
{
    static class LockingSystem
    {

        public static void CreateProfile()
        {
            Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
            foreach (var campaign in Storage.Campaigns)
                if (!progress.Data.ContainsKey(campaign.Id))
                    progress.Data.Add(campaign.Id, 0);
            progress.Save();
        }

        public static bool IsLevelLocked(string levelfile)
        {
            string file = levelfile.NormPath(true);
            if (CampaignUtils.GetCampaignUnlockMode(levelfile) == Campaign.UnlockStyle.LevelSet)
                return false;
            string campaign = CampaignUtils.GetCampaignId(file);
            Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
            int completion = progress.Data[campaign];
            return CampaignUtils.GetLevelIndex(levelfile) > completion;
        }

        public static int GetCampaignProgress(string campaign)
        {
            Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
            return progress.Data[campaign];
        }

        public static void UnlockLevel(string levelfile)
        {
            string file = levelfile.NormPath(true);
            Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
            string campaign = CampaignUtils.GetCampaignId(levelfile);
            int index = CampaignUtils.GetLevelIndex(levelfile);
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
