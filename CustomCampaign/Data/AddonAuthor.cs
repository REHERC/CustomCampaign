using System;
using System.Runtime.Serialization;

namespace CustomCampaign.Data
{
    [DataContract, Serializable]
    public class AddonAuthor
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Contact { get; set; }

        public AddonAuthor(string _name, string _contact)
        {
            this.Name = _name;
            this.Contact = _contact;
        }
    }
}
