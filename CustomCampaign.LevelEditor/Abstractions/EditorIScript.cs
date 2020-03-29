using UnityEngine;

namespace CustomCampaign.LevelEditor.Abstractions
{
    public abstract class EditorScript : MonoBehaviour, ILevelEditorDrawable
    {
        public virtual string Id { get; }
        public virtual string Name { get; }
        public virtual string Description { get; }
        public virtual string Folder { get; }
        protected virtual int Version { get; }
        protected GameObject Instance { get; set; }

        public virtual void Visit(IVisitor visitor)
        {
            visitor.VisualLabel("This script has no properties.");
        }

        public virtual bool Validate(GameObject prefab, out string error)
        {
            error = string.Empty;
            return true;
        }

        public virtual void DrawInspected(GLDrawer drawer)
        {
        }
    }
}