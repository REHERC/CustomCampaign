#pragma warning disable RCS1170

namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentFile : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.File;

        public string Id { get; private set; }

        public HierarchyComponentFile(string name, string id, HierarchyComponentFolder parent) : base(name, parent)
        {
            Id = id;
        }
    }
}
