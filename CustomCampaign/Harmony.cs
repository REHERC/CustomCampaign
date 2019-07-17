using CustomCampaign.Data;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using Harmony;
using System;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable CS0168, RCS1003, RCS1001
namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    internal static class LevelGridMenu__CreateEntries__Patch
    {
        public static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");
            if (flag_campaignmode)
            {
                const LevelGridMenu.PlaylistEntry.UnlockStyle unlock_mode = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                foreach (CampaignInfo campaign in CampaignDatabase.Campaigns)
                    __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", campaign.GetLevelSet(campaign.GameMode), campaign.Name, true, unlock_mode, campaign.GameMode);
                __instance.buttonList_.SortAndUpdateVisibleButtons();
            }

            LockingSystem.CreateProfile();
        }
    }

    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    internal static class LevelIntroTitleLogic__Update__Patch
    {
        public static void Postfix(LevelIntroTitleLogic __instance)
        {
            string path = G.Sys.GameManager_.LevelPath_;
            if (Util.IsCustomCampaignLevel(path))
            {
                __instance.titleLabel_.text = Util.GetLevelTitle(path).Space(1);
                __instance.subtitleText_.text = Util.GetLevelSubTitle(path).Space(1);
                __instance.subtitleText_.gameObject.SetActive(true);
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
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
                        if (Util.IsCustomCampaignLevel(level))
                        {
                            __instance.modeDescription_.text = __instance.gridDescription_.text = Util.GetCampaignDescription(level);
                            __instance.campaignLogo_.mainTexture = Util.GetCampaignLogo(level);
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
                if (Util.IsCustomCampaignLevel(path))
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
            if (Util.IsCustomCampaignLevel(path) && __instance.GetPrivateField<string>("storedSceneToLoad_") != "MainMenu")
            {
                Texture background = Util.GetLevelWallpaper(path);
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
            if (G.Sys.GameManager_.PauseMenuOpen_ && Util.IsCustomCampaignLevel(path))
            {
                __instance.gameMode_.text = Util.GetCampaignName(path);
                __instance.gameModeDescription_.text = Util.GetCampaignDescription(path);
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
                foreach (LevelNameAndPathPair level in set.GetAllLevelNameAndPathPairs())
                    if (Util.IsCustomCampaignLevel(level.levelPath_))
                        set.RemoveLevel(level.levelPath_.Normalize());
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "OnGridCellClicked")]
    internal static class LevelGridMenu__OnGridCellClicked__Patch
    {
        public static bool Prefix(LevelGridMenu __instance, ref int index)
        {
            bool result = false;
            LevelPlaylist playlist = __instance.DisplayedEntry_.Playlist_;
            string level = playlist.Playlist_[index].levelNameAndPath_.levelPath_;
            if (Util.GetCampaignUnlockMode(level) == Campaign.UnlockStyle.LevelSet)
                result = true;
            else
            {
                bool flag = !LockingSystem.IsLevelLocked(level) || !Util.IsCustomCampaignLevel(level);
                if (!flag)
                    G.Sys.MenuPanelManager_.ShowTimedOk(10, Constants.Strings.LevelLocked_Message, Constants.Strings.LevelLocked_Title);
                result = flag;
            }
            if (result && Util.IsCustomCampaignLevel(level))
            {
                CampaignInfo campaign = Util.GetCampaign(level);
                Events.CampaignLevelStarted.Broadcast(new Events.CampaignLevelStarted.Data(campaign));
            }
            return result;
        }
    }

    [HarmonyPatch(typeof(GameManager), "GetModeShowInLevelEditor")]
    internal static class GameManager__GetModeShowInLevelEditor__Patch
    {
        public static List<GameModeID> Modes = new List<GameModeID>() {
            GameModeID.Challenge,
            GameModeID.ReverseTag,
            GameModeID.Adventure,
            GameModeID.Sprint,
            GameModeID.Stunt,
            GameModeID.LostToEchoes,
            GameModeID.MainMenu,
            GameModeID.Nexus
        };

        public static void Postfix(ref bool __result, GameModeID ID)
        {
            __result = Modes.Contains(ID);
        }
    }
}
