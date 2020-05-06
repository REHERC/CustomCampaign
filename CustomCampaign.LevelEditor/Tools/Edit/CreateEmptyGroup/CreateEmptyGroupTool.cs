#pragma warning disable IDE1006
using static CustomCampaign.LevelEditor.Extensions.LevelEditorEx;
using LevelEditorActions;
using UnityEngine;
using LevelEditorTools;

namespace CustomCampaign.LevelEditor.Tools.Edit
{
    public class CreateEmptyGroupTool : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("Create Empty Group", "Creates an empty object.", ToolCategory.Edit, ToolButtonState.Button, false, 1100);
        public override ToolInfo Info_ => info_;

        public static void Register()
        {
            G.Sys.LevelEditor_.RegisterTool(info_);
        }

        public override bool Run()
        {
            CreateEmptyGroupAction Action = new CreateEmptyGroupAction();
            GameObject Group = Action.Create();
            G.Sys.LevelEditor_.ClearAndSelect(Group);
            Action.FinishAndAddToLevelEditorActions();
            return true;
        }

        private class CreateEmptyGroupAction : SimplerAction
        {
            public override string Description_ => "";

            public ReferenceMap.Handle<GameObject> Handle;

            internal GameObject Create()
            {
                Redo();
                return Handle.Get();
            }

            public override void Redo()
            {
                GameObject group = Resource.LoadPrefabInstance("Group", true);
                G.Sys.LevelEditor_.AddGameObjectSilent(ref Handle, group, null);
            }

            public override void Undo()
            {
                GameObject prefab = Handle.Get();

                if (prefab is null)
                {
                    return;
                }

                G.Sys.LevelEditor_.RemoveGameObjectSilent(prefab);
            }
        }
    }
}
