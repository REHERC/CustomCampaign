
#pragma warning disable IDE1006
using CustomCampaign.LevelEditor.Attributes;
using LevelEditorTools;
using System.Collections.Generic;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Tools.View.Animator_Stack
{
    [ToolKeyboardShortcut("SHIFT+H")]
    public class InspectParentNode : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("Inspect Parent Object", "Sets the target root of the objects tab to the parent of the current object.", ToolCategory.View, ToolButtonState.Button, true, 1105);
        public override ToolInfo Info_ => info_;

        public static void Register()
        {
            G.Sys.LevelEditor_.RegisterTool(info_);
        }

        public override bool Run()
        {
            global::LevelEditor levelEditor = G.Sys.LevelEditor_;
            List<GameObject> selection = levelEditor.SelectedNonTrackNodeAndNonOnlyAllowOneObjects_;

            if (selection.Count == 1)
            {
                return Harmony.Common.HierarchyTabLogic.Tool.InspectParent(selection[0]);
            }
            else
            {
                return false;
            }
        }
    }
}
