﻿using Photon.Serialization;
using System;
using System.Collections.Generic;

#pragma warning disable RCS1001
namespace CustomCampaign
{
    public static class LockingSystem
    {
        public static void CreateProfile()
        {
            Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
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
                Serializer<Dictionary<string, int>> progress = new Serializer<Dictionary<string, int>>(SerializerType.Json, GetProgressFilePath(), true);
                int completion = progress.Data[campaign];
                return Utils.GetLevelIndex(levelfile) > completion;
            }
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
            return false;
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