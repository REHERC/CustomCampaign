using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CustomCampaign.SDK.Data
{
    [DataContract, Serializable]
    public class AddOnManifest
    {
        public string Id { get; set; }

        [DataMember]
        public string AddonName { get; set; }

        [DataMember]
        public List<Author> Authors { get; set; }

        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public List<string> Dependencies { get; set; }
    }

    [DataContract, Serializable]
    public class Author
    {
        [DataMember]
        public string Name { get; set; } = "Author";

        [DataMember]
        public string Contact { get; set; } = "author@mail.com";

        public Author(string _name, string _contact)
        {
            this.Name = _name;
            this.Contact = _contact;
        }
    }
}
