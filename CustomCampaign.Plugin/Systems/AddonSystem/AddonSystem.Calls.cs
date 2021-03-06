﻿#pragma warning disable CA1031, CA1303
using CustomCampaign.Data;
using CustomCampaign.Storage;

namespace CustomCampaign.Systems
{
    internal static partial class AddonSystem
    {
        internal static void InitializeAddons()
        {
            Plugin.Log.Info("Initializing addons...");
            foreach (var item in GetAddons())
            {
                // Avoid multiple initialization calls
                if (item.Key.Object.Initialized) return;

                CampaignInfo info = Utils.Campaign.GetCampaign(item.Key);
                item.Key.Object.Info = info;
                try
                {
                    item.Key.Object.OnInit(info);
                    item.Key.Object.Initialized = true;
                }
                catch (System.Exception error)
                {
                    Plugin.Log.Exception(error);
                }
            }
            Plugin.Log.Info("Addons initialized!");
        }

        internal static void EnableAddons(string guid)
        {
            if (Utils.Common.IsInLevelEditor())
            {
                return;
            }

            foreach (var item in GetAddons(guid))
            {
                try
                {
                    item.Key.Object.Enable();
                }
                catch (System.Exception error)
                {
                    Plugin.Log.Exception(error);
                }
            }
        }

        internal static void DisableAddons(string guid)
        {
            foreach (var item in GetAddons(guid))
            {
                try
                {
                    if (item.Key.Object.Enabled)
                    {
                        item.Key.Object.Disable();
                    }
                }
                catch (System.Exception error)
                {
                    Plugin.Log.Exception(error);
                }
            }
        }

        internal static void LevelLoaded(CampaignInfo campaign)
        {
            foreach (var item in GetAddons(campaign.Id))
            {
                try
                {
                    item.Key.Object.OnLevelStart(Utils.Campaign.GetLevelInfo(Utils.Common.LevelFile), G.Sys.GameManager_.ModeID_ == GameModeID.Sprint);
                }
                catch (System.Exception error)
                {
                    Plugin.Log.Exception(error);
                }
            }
        }
    }
}