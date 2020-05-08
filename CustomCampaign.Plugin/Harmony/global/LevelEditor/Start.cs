#pragma warning disable CA1031
using CustomCampaign.LevelEditor.Extensions;
using CustomCampaign.LevelEditor.Tools.Others;
using CustomCampaign.Storage;
using Harmony;
using System;
using UnityEngine;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(global::LevelEditor), "Start")]
    internal static class Start
    {
        internal static void Postfix()
        {
            CreateCustomComponentMenu();
        }

        internal static void CreateCustomComponentMenu()
        {
            try
            {
                GameObject ComponentMenuObject = Resource.LoadPrefabInstance("LevelEditorLevelNameSelectMenu", true);
                ComponentMenuObject.name = "CustomComponentSelectMenu";

                AddCustomComponentMenuLogic ComponentMenu = ComponentMenuObject.AddComponent<AddCustomComponentMenuLogic>();
                LevelEditorLevelNameSelectMenuLogic MusicLogic = ComponentMenuObject.GetComponent<LevelEditorLevelNameSelectMenuLogic>();

                ComponentMenu.Init(MusicLogic);

                foreach (LevelEditorLevelNameSelectMenuButton trackButton in ComponentMenuObject.GetComponentsInChildren<LevelEditorLevelNameSelectMenuButton>(true))
                {
                    CustomComponentSelectMenuButton componentButton = trackButton.gameObject.AddComponent<CustomComponentSelectMenuButton>();

                    componentButton.Init(trackButton);

                    trackButton.gameObject.RemoveComponents<LevelEditorLevelNameSelectMenuButton>();
                }

                ComponentMenuObject.RemoveComponents<LevelEditorLevelNameSelectMenuLogic>();

                LevelEditorEx.componentSelectMenuLogic = ComponentMenu;
            }
            catch (Exception e)
            {
                Plugin.Log.Exception(e);
            }
        }
    }
}
