using Harmony;
using System;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable CS0168, RCS1003, RCS1001
namespace CustomCampaign
{
    public static class Patches
    {
        [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
        internal static class LevelGridMenu__CreateEntries__Patch
        {
            public static void Postfix(LevelGridMenu __instance)
            {
                bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");
                if (flag_campaignmode)
                {
                    const GameModeID campaign_mode = GameModeID.Nexus;
                    const LevelGridMenu.PlaylistEntry.UnlockStyle unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                    foreach (CampaignInfo campaign in Storage.Campaigns)
                        __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", campaign.GetLevelSet(campaign_mode), campaign.Name, true, unlock_mode, campaign_mode);
                    __instance.buttonList_.SortAndUpdateVisibleButtons();
                }

                LockingSystem.CreateProfile();
            }
        }
    }

    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    internal static class LevelIntroTitleLogic__Update__Patch
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            string path = G.Sys.GameManager_.LevelPath_;
            if (CampaignUtils.IsCustomCampaignLevel(path))
            {
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
                __instance.titleLabel_.text = CampaignUtils.GetLevelTitle(path);
                __instance.subtitleText_.text = CampaignUtils.GetLevelSubTitle(path);
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "SetDisplayedInfoForSelectedPlaylist")]
    internal static class LevelGridMenu__SetDisplayedInfoForSelectedPlaylist__Patch
    {
        public static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");
            if (flag_campaignmode)
            {
                if (__instance.isActiveAndEnabled)
                {
                    try
                    {
                        LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
                        string level = playlist.GetLevelSet()[0].levelPath_;
                        if (CampaignUtils.IsCustomCampaignLevel(level))
                        {
                            __instance.modeDescription_.text = __instance.gridDescription_.text = CampaignUtils.GetCampaignDescription(level);
                            __instance.campaignLogo_.mainTexture = CampaignUtils.GetCampaignLogo(level);
                        }
                    }
                    catch (Exception pizza) { Plugin.Log.Exception(pizza); }
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridCell), "OnDisplayedVirtual")]
    internal static class LevelGridCell__OnDisplayedVirtual__Patch
    {
        public static void Postfix(LevelGridCell __instance, ref UIButton ___button_)
        {
            try
            {
                LevelGridGrid.LevelEntry entry = __instance.entry_ as LevelGridGrid.LevelEntry;
                string path = entry.AbsolutePath_;
                if (CampaignUtils.IsCustomCampaignLevel(path))
                {
                    __instance.titleLabel_.enabled = false;
                    __instance.authorLabel_.enabled = false;
                    __instance.soloTitleLabel_.enabled = true;
                    if (LockingSystem.IsLevelLocked(path))
                    {
                        __instance.lockedIcon_.SetActive(true);
                        ___button_.onClick.Clear();
                        string leveltitle = "";
                        foreach (char c in entry.LevelInfo_.levelName_)
                            leveltitle += c.ToString() == " " ? " " : "?";
                        __instance.soloTitleLabel_.text = leveltitle;
                    }
                    else
                        __instance.soloTitleLabel_.text = entry.LevelInfo_.levelName_;
                }
            }
            catch (Exception pizza) { Plugin.Log.Exception(pizza); }
        }
    }

    [HarmonyPatch(typeof(BlackFadeLogic), "FinishFadeOut")]
    internal static class BlackFadeLogic__FinishFadeOut__Patch
    {
        public static void Postfix(BlackFadeLogic __instance)
        {
            string path = G.Sys.GameManager_.NextLevelPath_;
            if (CampaignUtils.IsCustomCampaignLevel(path) && __instance.GetPrivateField<string>("storedSceneToLoad_") != "MainMenu")
            {
                Texture background = CampaignUtils.GetLevelWallpaper(path);
                if (background != null)
                    __instance.GetPrivateField<LevelLoadingOverlay>("menu_").loadingTexture_.mainTexture = background;
            }
        }
    }

    [HarmonyPatch(typeof(PauseMenuLogic), "Update")]
    internal static class PauseMenuLogic__Update__Patch
    {
        public static void Postfix(PauseMenuLogic __instance)
        {
            string path = G.Sys.GameManager_.LevelPath_;
            if (G.Sys.GameManager_.PauseMenuOpen_ && CampaignUtils.IsCustomCampaignLevel(path))
            {
                __instance.gameMode_.text = CampaignUtils.GetCampaignName(path);
                __instance.gameModeDescription_.text = CampaignUtils.GetCampaignDescription(path);
                __instance.medal_.Display(MedalStatus.None, false);
                __instance.medal_.gameObject.SetActive(false);
                __instance.medal_.Destroy();
                __instance.upperRightGroup_.SetActive(false);
                __instance.levelName_.text = "[AAAAAA]Level:[-] [FFFFFF]" + G.Sys.GameManager_.LevelName_;
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "CreateAndAddLevelSet", new Type[] { typeof(LevelSet), typeof(string), typeof(LevelGridMenu.PlaylistEntry.Type), typeof(LevelGroupFlags) })]
    internal static class LevelGridMenu__CreateAndAddLevelSet__Patch
    {
        public static void Prefix(
            ref LevelSelectMenuAbstract.DisplayType ___displayType_,
            ref LevelSet set, ref LevelGridMenu.PlaylistEntry.Type type)
        {
            if (type != LevelGridMenu.PlaylistEntry.Type.Campaign && ___displayType_ != LevelSelectMenuAbstract.DisplayType.Adventure)
                foreach (LevelNameAndPathPair level in new List<LevelNameAndPathPair>(set.WorkshopLevelNameAndPathPairsInSet_))
                    if (CampaignUtils.IsCustomCampaignLevel(level.levelPath_))
                        set.RemoveLevel(level.levelPath_);
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "OnGridCellClicked")]
    internal static class LevelGridMenu__OnGridCellClicked__Patch
    {
        public static bool Prefix(LevelGridMenu __instance, ref int index)
        {
            LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
            string level = playlist.Playlist_[index].levelNameAndPath_.levelPath_;
            if (CampaignUtils.GetCampaignUnlockMode(level) == Campaign.UnlockStyle.LevelSet)
                return true;
            bool flag = !LockingSystem.IsLevelLocked(level) || !CampaignUtils.IsCustomCampaignLevel(level);
            if (!flag)
                G.Sys.MenuPanelManager_.ShowTimedOk(10, "Complete previous levels to unlock.", "LEVEL LOCKED");
            return flag;
        }
    }
}
