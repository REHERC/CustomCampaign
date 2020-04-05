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
        internal bool Fake { get; set; }

        public static SCRIPT Create<SCRIPT>() where SCRIPT : EditorScript, new()
        {
            GameObject Prefab = new GameObject
            {
                name = $"{typeof(SCRIPT).FullName} (Virtual Fake Instance)"
            };

            GameObject Holder = Instantiate(Prefab);

            SCRIPT Instance = Holder.AddComponent<SCRIPT>();

            Instance.Fake = true;
            DontDestroyOnLoad(Holder);

            return Instance;
        }

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