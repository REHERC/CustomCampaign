using LevelEditorTools;
using System;

namespace CustomCampaign.LevelEditor.Abstractions
{
    public abstract class EditorInstantTool : InstantTool
    {
        public static global::LevelEditor Editor => G.Sys.LevelEditor_;
        public override ToolInfo Info_
        {
            get
            {
                return new ToolInfo(Name, Description, Category, ToolButtonState.Button, NeedsSelectedObject);
            }
        }

        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract bool NeedsSelectedObject { get; }
        public abstract ToolCategory Category { get; }

        public static void Register()
        {
            foreach (Type tool in GUtils.GetExportedTypesOfType(typeof(EditorInstantTool)))
            {
                EditorInstantTool instance = Activator.CreateInstance(tool) as EditorInstantTool;
                instance.RegisterTool();
            }
        }

        protected void RegisterTool()
        {
            G.Sys.LevelEditor_.RegisterTool(this);
        }

        public static implicit operator ToolInfo(EditorInstantTool value) => value.Info_;
    }
}
