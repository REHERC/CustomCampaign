using System.Collections.Generic;

namespace CustomCampaign.SDK.Data
{
    class AddOnManifest
    {
        public string AddonName { get; set; } = "Addon";
        public List<Author> Authors { get; set; } = new List<Author>();
        public string ModuleFile { get; set; } = "Addon.dll";
        public string EntryClass { get; set; } = "Entry";
        public string[] Dependencies { get; set; } = {};
        public bool Enabled { get; set; } = true;
    }

    class Author
    {
        public string Name { get; set; } = "Author";
        public string Contact { get; set; } = "author@mail.com";
    }
}
