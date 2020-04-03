#pragma warning disable IDE1006
using LevelEditorTools;

namespace CustomCampaign.LevelEditor.Tools.View.Quick_Select
{
    public class SaveSelectionToolBase : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("Save Selection", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1100);
        public override ToolInfo Info_ => info_;

        public virtual int QuickAccessIndex => -1;

        public static void Register()
        {
        }

        public override bool Run()
        {
            var Editor = G.Sys.LevelEditor_;
            var Selection = Editor.SelectedObjects_;
            if (Selection.Count == 1)
            {
                EditorToolset.SetQuickMemory(QuickAccessIndex, Selection[0]);
            }
            else
            {
                G.Sys.MenuPanelManager_.ShowError("ERROR", "You must select only 1 object to use this tool.");
            }

            return true;
        }
    }
}
