using CustomCampaign.LevelEditor.Data;
using CustomCampaign.LevelEditor.Tools.Others;
using System;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Extensions
{
    public static class LevelEditorEx
    {
        public static AddCustomComponentMenuLogic componentSelectMenuLogic;

        public static void ClearAndSelect(this global::LevelEditor editor, GameObject prefab)
        {
            editor.ClearSelectedList(true);
            editor.SelectObject(prefab);
        }

        public static void OpenComponentSelectMenu(this global::LevelEditor _, string headerText, Action<HierarchyComponentData> pathCallback, MenuPanel.OnPanelPop onPopCallback)
        {
            G.Sys.MenuPanelManager_.Clear(true);
            componentSelectMenuLogic.Show(headerText, pathCallback);
            MenuPanel menuPanel = MenuPanel.Create(componentSelectMenuLogic.gameObject, false, false, false, true, false, false);
            menuPanel.onPanelPop_ = onPopCallback;
            menuPanel.allowZeroPanels_ = true;
            menuPanel.showBforBack_ = false;
            menuPanel.Push();
        }
    }
}
