using Harmony;
using System;
using UnityEngine;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(LevelGridMenu), "CreateEntries")]
    public class LevelGridMenu__CreateEntries__Patch
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
    public class LevelGridMenu__SetDisplayedInfoForSelectedPlaylist__Patch
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
    public class LevelIntroTitleLogic__SetIdlePosition__Patch
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
    public class LevelIntroTitleLogic__Update__Patch
    {
        static void Postfix(LevelIntroTitleLogic __instance)
        {
            if (Mod.IsCustomCampaignLevel(Mod.LevelContext.Current))
            {
                __instance.subtitleText_.alpha = __instance.titleLabel_.alpha;

                __instance.titleLabel_.text = Mod.GetLevelTitle();
                __instance.subtitleText_.text = "- LEVEL NAME SUBTITLE -";
            }
        }
    }

    [HarmonyPatch(typeof(BlackFadeLogic), "FinishFadeOut")]
    public class BlackFadeLogic__FinishFadeOut__Patch
    {
        static void Postfix(BlackFadeLogic __instance)
        {
            if (Mod.IsCustomCampaignLevel(Mod.LevelContext.Next))
            {
                Texture background = Mod.GetLevelLoadingBackground();
                if (background != null)
                {
                    __instance.GetPrivateField<LevelLoadingOverlay>("menu_").loadingTexture_.mainTexture = background;
                }
            }
        }
    }
}
