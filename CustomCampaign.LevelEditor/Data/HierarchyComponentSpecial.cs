namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentSpecial : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.HierarchyParent;

        public HierarchyComponentSpecial(string name, HierarchyComponentFolder parent) : base(name, parent)
        {
        }
    }
}
