#pragma warning disable IDE1006
using LevelEditorTools;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Tools.View.Quick_Select
{
    public class LoadSelectionToolBase : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("Load Selection", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1100);
        public override ToolInfo Info_ => info_;

        public virtual int QuickAccessIndex => -1;

        public static void Register()
        {
        }

        public override bool Run()
        {
            GameObject instance = EditorToolset.GetQuickMemory(QuickAccessIndex);
            if (instance)
            {
                EditorToolset.Inspect(instance);
            }
            return true;
        }
    }
}
