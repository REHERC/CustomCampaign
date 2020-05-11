namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentSpecial : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.HierarchyParent;

        private string path_;

        public override string Path => path_;

        public HierarchyComponentSpecial(string name, string path, HierarchyComponentFolder parent) : base(name, parent)
        {
            path_ = path;
        }
    }
}
