#pragma warning disable IDE1006
using CustomCampaign.LevelEditor.Attributes;
using LevelEditorTools;

namespace CustomCampaign.LevelEditor.Tools.View.Animator_Stack
{
    [ToolKeyboardShortcut("ALT+H")]
    public class InspectRoot : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("Reset Inspector", "Resets the target root of the objects tab.", ToolCategory.View, ToolButtonState.Button, false, 1110);
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
