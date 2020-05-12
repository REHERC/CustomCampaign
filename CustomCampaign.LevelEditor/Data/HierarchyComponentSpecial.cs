namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentSpecial : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.Special;

        private readonly string path_;
        public override string Path => path_;

        public HierarchyComponentSpecial(string name, string path, HierarchyComponentFolder parent) : base(name, parent)
        {
            path_ = path;
        }
    }
}
