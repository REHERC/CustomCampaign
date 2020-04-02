
#pragma warning disable IDE1006
using CustomCampaign.LevelEditor.Attributes;
using LevelEditorTools;

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
            return true;
        }
    }
}
