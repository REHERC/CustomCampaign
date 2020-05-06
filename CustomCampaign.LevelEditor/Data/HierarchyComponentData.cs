
namespace CustomCampaign.LevelEditor.Data
{
    public abstract class HierarchyComponentData
    {
        public abstract HierarchyLevel Hierarchy { get; }
        public string Name { get; set; }
        public HierarchyComponentFolder Parent { get; set; }

        protected HierarchyComponentData(string name, HierarchyComponentFolder parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}
