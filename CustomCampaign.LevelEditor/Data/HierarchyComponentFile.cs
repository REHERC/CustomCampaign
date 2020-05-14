#pragma warning disable RCS1170

using System;

namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentFile : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.File;

        public override string Path => Id.ToLowerInvariant();

        public string Id { get; private set; }

        public Type ComponentType { get; private set; }

        public HierarchyComponentFile(string name, string id) : base(name, null)
        {
            Id = id;
        }

        public void SetComponent(Type component)
        {
            ComponentType = component;
        }
    }
}
