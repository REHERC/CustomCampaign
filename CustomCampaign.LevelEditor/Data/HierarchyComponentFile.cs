namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentFile : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.File;

        public HierarchyComponentFile(string name, HierarchyComponentFolder parent) : base(name, parent)
        {
        }
    }
}
