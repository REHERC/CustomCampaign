using static CustomCampaign.LevelEditor.Extensions.LevelEditorEx;
using CustomCampaign.LevelEditor.Abstractions;
using LevelEditorActions;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Tools
{
    public class CreateEmptyGroupTool : EditorInstantTool
    {
        public override string Name => "Create Empty Group";
        public override string Description => "Creates an empty object.";
        public override bool NeedsSelectedObject => false;
        public override ToolCategory Category => ToolCategory.Edit;

        public override bool Run()
        {
            CreateEmptyGroupAction Action = new CreateEmptyGroupAction();
            GameObject Group = Action.Create();
            Editor.ClearAndSelect(Group);
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
                Editor.AddGameObjectSilent(ref Handle, group, null);
            }

            public override void Undo()
            {
                GameObject prefab = Handle.Get();

                if (prefab is null)
                {
                    return;
                }

                Editor.RemoveGameObjectSilent(prefab);
            }
        }
    }
}
