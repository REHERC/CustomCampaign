﻿using System.Collections.Generic;
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

        public HierarchyComponentFolder GetOrCreateFolder(string name)
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

        public HierarchyComponentFile AddFile(string name, string id, bool overwrite = false, int stack = 2)
        {
            HierarchyComponentFile file = GetFile(name);

            if (file is null)
            {
                file = new HierarchyComponentFile(name, id);
                Entries.Add(file);
                return file;
            }
            else if (overwrite && stack > 0)
            {
                Entries.Remove(file);
                return AddFile(name, id, true, stack - 1);
            }
            else
            {
                return null;
            }
        }

        public HierarchyComponentFile CreateFile(string path, string id)
        {
            string[] structure = (from entry in path.Split('/') where entry.Length > 0 select entry).ToArray();
            System.Console.WriteLine($"CreateFile {path} \t {id}");

            if (structure.Length > 0)
            {
                return CreateFile(structure, id);
            }
            else
            {
                return null;
            }
        }

        public HierarchyComponentFile CreateFile(string[] path, string id)
        {
            string name = path[0];

            if (path.Length > 1)
            {
                System.Console.WriteLine($"Folder {name}");
                // Folder
                HierarchyComponentFolder folder = GetOrCreateFolder(name);
                return folder.CreateFile(path.RemoveAt(0), id);
            }
            else
            {
                System.Console.WriteLine($"File {name}");
                // File
                HierarchyComponentFile file = AddFile(name, id);
                return file;
            }
        }
    }
}
