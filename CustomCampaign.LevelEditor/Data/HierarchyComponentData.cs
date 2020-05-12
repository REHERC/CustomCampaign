
using System.Globalization;

namespace CustomCampaign.LevelEditor.Data
{
    public abstract class HierarchyComponentData
    {
        public abstract HierarchyLevel Hierarchy { get; }

        public string Name { get; set; }

        public abstract string Path { get; }

        public HierarchyComponentFolder Parent { get; set; }

        protected HierarchyComponentData(string name, HierarchyComponentFolder parent)
        {
            Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            Parent = parent;
        }
    }
}
