using System;
using System.Runtime.Serialization;

namespace CustomCampaign.Data
{
    [DataContract, Serializable]
    public class ProfileProgress
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public int Value { get; set; }
    }
}
