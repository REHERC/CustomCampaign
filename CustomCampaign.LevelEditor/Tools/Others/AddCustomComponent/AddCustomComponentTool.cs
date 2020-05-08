#pragma warning disable IDE1006, RCS1192
using CustomCampaign.LevelEditor.Data;
using CustomCampaign.LevelEditor.Extensions;
using CustomCampaign.Storage;
using LevelEditorTools;
using System;
using System.Collections.Generic;

namespace CustomCampaign.LevelEditor.Tools.Others
{
    public class AddCustomComponentTool : LevelEditorTool
    {
        private string printMessage_;
        private ToolState toolState_;

        internal static ToolInfo info_ => new ToolInfo("Add Custom Component", "Select a modded script from a list.", ToolCategory.Others, ToolButtonState.Button, false, 1100)
        {
            CancelsAllOtherTools_ = true
        };

        public override ToolInfo Info_ => info_;

        public static void Register()
        {
            G.Sys.LevelEditor_.RegisterTool(info_);
        }

        public static void RegisterStackableTypes(List<ToolTypeInfo> stackableTypes)
        {
            stackableTypes.Add(ToolTypeInfo.Create(typeof(global::LevelEditor), ToolState.Active));
        }

        public override void Start()
        {
            Plugin.Log.Info("Start tool");
            toolState_ = ToolState.Active;
            G.Sys.LevelEditor_.OpenComponentSelectMenu("Select Custom Component", new Action<HierarchyComponentData>(OnItemSelected), new MenuPanel.OnPanelPop(OnMenuPop));
            printMessage_ = "Select a component to add to the current object";
        }

        public override ToolState Update()
        {
            PrintMessage(printMessage_);
            return toolState_;
        }

        public override void Cancel()
        {
            return;
        }

        public override void Finish()
        {
            // TODO : Add later
        }

        public void OnMenuPop()
        {
            toolState_ = ToolState.FinishedQuietly;
            printMessage_ = null;
        }

        private void OnItemSelected(HierarchyComponentData entry)
        {
            // TODO : Implment method
        }
    }
}
