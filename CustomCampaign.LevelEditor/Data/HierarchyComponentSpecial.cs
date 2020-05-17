namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentSpecial : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.Special;

        private readonly string path_;
        public override string Path => $"${path_.ToLowerInvariant()}";

        public HierarchyComponentSpecial(string name, string path) : base(name, null)
        {
            path_ = path;
        }
    }
}
