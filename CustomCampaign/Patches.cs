using Harmony;
using System;
using System.Linq;
using System.IO;
using UnityEngine;
using static CustomCampaign.Plugin;
using System.Collections.Generic;

namespace CustomCampaign.Patches
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    class LevelGridMenu__CreateEntries__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            bool flag_campaignmode = __instance.GetPrivateField<bool>("isCampaignMode_");
            if (flag_campaignmode)
            {
                GameModeID mode = GameModeID.Nexus;
                LevelGridMenu.PlaylistEntry.UnlockStyle unlock = LevelGridMenu.PlaylistEntry.UnlockStyle.PreviousLevels;
                foreach (Storage.CampaignInfo campaign in Storage.Campaigns)
                {
                    __instance.CallPrivateMethod("CreateAndAddCampaignLevelSet", campaign.Levels, campaign.Name, true, unlock, mode);
                    __instance.buttonList_.SortAndUpdateVisibleButtons();
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "SetDisplayedInfoForSelectedPlaylist")]
    class LevelGridMenu__SetDisplayedInfoForSelectedPlaylist__Patch
    {
        static void Postfix(LevelGridMenu __instance)
        {
            if (__instance.isActiveAndEnabled)
            {
                Mod.SelectedPlaylist = __instance.DisplayedEntry_.Playlist_;
                if (Mod.IsCustomCampaignPlaylist())
                {
                    __instance.modeDescription_.text = __instance.gridDescription_.text = Mod.GetCampaignDescription();
                    __instance.campaignLogo_.mainTexture = Mod.GetCampaignLogo();
                }
            }
        }
    }

    [HarmonyPatch(typeof(LevelIntroTitleLogic), "SetIdlePosition")]
    class LevelIntroTitleLogic__SetIdlePosition__Patch
    {
        static void Postfix(LevelIntroTitleLogic __instance)
        {
            if (Mod.IsCustomCampaignLevel(Mod.LevelContext.Current))
            {
                __instance.subtitleText_.gameObject.SetActive(true);
            }
        }
    }

    [HarmonyPatch(typeof(LevelIntroTitleLogic), "Update")]
    class LevelIntroTitleLogic__Update__Patch
    {
        static void Postfix(LevelIntroTitleLogic __instance)
        {
            if (Mod.IsCustomCampaignLevel(Mod.LevelContext.Current))
            {
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;
                __instance.titleLabel_.text = Mod.GetLevelTitle();
                __instance.subtitleText_.text = Mod.GetLevelSubTitle();
            }
        }
    }

    [HarmonyPatch(typeof(BlackFadeLogic), "FinishFadeOut")]
    class BlackFadeLogic__FinishFadeOut__Patch
    {
        static void Postfix(BlackFadeLogic __instance)
        {
            if (Mod.IsCustomCampaignLevel(Mod.LevelContext.Next) && __instance.GetPrivateField<string>("storedSceneToLoad_") != "MainMenu")
            {
                Texture background = Mod.GetLevelLoadingBackground();
                if (background != null)
                    __instance.GetPrivateField<LevelLoadingOverlay>("menu_").loadingTexture_.mainTexture = background;
            }
        }
    }

    [HarmonyPatch(typeof(PauseMenuLogic), "Update")]
    class PauseMenuLogic__Update__Patch
    {
        static void Postfix(PauseMenuLogic __instance)
        {
            if (G.Sys.GameManager_.PauseMenuOpen_ && Mod.IsCustomCampaignLevel(Mod.LevelContext.Current))
            {
                __instance.gameMode_.text = Mod.GetCampaignName();
                __instance.gameModeDescription_.text = Mod.GetCampaignDescription();
                __instance.medal_.Display(MedalStatus.None, false);
                __instance.medal_.gameObject.SetActive(false);
                __instance.levelName_.text = "[AAAAAA]Level:[-] [FFFFFF]" + G.Sys.GameManager_.LevelName_;
            }
        }
    }

    [HarmonyPatch(typeof(LevelGridMenu), "CreateAndAddLevelSet", new Type[] { typeof(LevelSet), typeof(string), typeof(LevelGridMenu.PlaylistEntry.Type), typeof(LevelGroupFlags)})]
    class LevelGridMenu__CreateAndAddLevelSet__Patch
    {
        static void Prefix(
            LevelGridMenu __instance, 
            ref LevelSelectMenuAbstract.DisplayType ___displayType_,
            ref LevelSet set, ref string name, ref LevelGridMenu.PlaylistEntry.Type type)
        {
            List<string> remove = new List<string>();
            if (type != LevelGridMenu.PlaylistEntry.Type.Campaign && ___displayType_ != LevelSelectMenuAbstract.DisplayType.Adventure)
                foreach (LevelNameAndPathPair level in new List<LevelNameAndPathPair>(set.WorkshopLevelNameAndPathPairsInSet_))
                    if (Storage.Levelnfos.ContainsKey(level.levelPath_.NormPath()))
                        set.RemoveLevel(level.levelPath_);
        }
    }

    [HarmonyPatch(typeof(LevelGridCell), "OnDisplayedVirtual")]
    class LevelGridCell__OnDisplayedVirtual__Patch
    {
        static void Postfix(LevelGridCell __instance)
        {
            LevelGridGrid.LevelEntry entry = __instance.entry_ as LevelGridGrid.LevelEntry;
            string path = entry.AbsolutePath_.NormPath();
            if (Storage.Levelnfos.ContainsKey(path))
            {
                __instance.titleLabel_.enabled = false;
                __instance.authorLabel_.enabled = false;
                __instance.soloTitleLabel_.enabled = true;
                __instance.soloTitleLabel_.text = entry.LevelInfo_.levelName_;

                //__instance.lockedIcon_.SetActive(true);

            }

        }
    }
}
