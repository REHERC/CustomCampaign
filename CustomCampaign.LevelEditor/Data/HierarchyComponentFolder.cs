using System.Collections.Generic;
using System.Linq;

namespace CustomCampaign.LevelEditor.Data
{
    public class HierarchyComponentFolder : HierarchyComponentData
    {
        public override HierarchyLevel Hierarchy => HierarchyLevel.Folder;

        public override string Path => $"/{Name.ToLowerInvariant()}";

        public List<HierarchyComponentData> Entries { get; set; }

        public HierarchyComponentFolder(string name, HierarchyComponentFolder parent) : base(name, parent)
        {
            Entries = new List<HierarchyComponentData>();
        }

        public List<HierarchyComponentFolder> GetSubFolders()
        {
            return (from ItemEntry in Entries where ItemEntry.Hierarchy == HierarchyLevel.Folder select ItemEntry).Cast<HierarchyComponentFolder>().ToList();
        }

        public List<HierarchyComponentFile> GetFiles()
        {
            return (from ItemEntry in Entries where ItemEntry.Hierarchy == HierarchyLevel.File select ItemEntry).Cast<HierarchyComponentFile>().ToList();
        }

        public HierarchyComponentFolder GetFolderOrCreate(string name)
        {
            string SearchPath = $"/{name.ToLowerInvariant()}";

            foreach (HierarchyComponentFolder Match in from Entry in GetSubFolders() where Entry.Path == SearchPath select Entry)
            {
                return Match;
            }

            HierarchyComponentFolder SubFolder = new HierarchyComponentFolder(name, this);
            Entries.Add(SubFolder);
            return SubFolder;
        }

        public HierarchyComponentFile GetFile(string name)
        {
            foreach (HierarchyComponentFile Match in from Entry in GetFiles() where string.Equals(name, Entry.Name, System.StringComparison.InvariantCultureIgnoreCase) select Entry)
            {
                return Match;
            }

            return null;
        }

        public bool AddFile(string name, string id, bool overwrite = false, int stack = 2)
        {
            HierarchyComponentFile File = GetFile(name);

            if (File is null)
            {
                Entries.Add(new HierarchyComponentFile(name, id));
                return true;
            }
            else if (overwrite && stack > 0)
            {
                Entries.Remove(File);
                return AddFile(name, id, true, stack - 1);
            }
            else
            {
                return false;
            }
        }
    }
}
