using System.Collections.Generic;

namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentFolder : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.Folder;

        public HierarchyComponentFolder(string name, HierarchyComponentFolder parent) : base(name, parent)
        {
            Entries = new List<HierarchyComponentData>();
        }

        public List<HierarchyComponentData> Entries { get; set; }
    }
}
