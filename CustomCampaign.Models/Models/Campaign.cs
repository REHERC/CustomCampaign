using Newtonsoft.Json;
using Photon.Serialization;
using System.Collections.Generic;
using System.IO;

namespace CustomCampaign.Models
{
    public class Campaign
    {
        [JsonProperty(Required = Required.Default)]
        public const ulong version = 1;

        public string guid = "";
        public string name = "";
        public string description = "";
        public string logopath = "";
        public string authors = "";
        public int lockmode = 0;
        public int gamemode = 15;
        public List<Level> levels = new List<Level>();
        public List<Addon> addons = new List<Addon>();

        public static Campaign FromFile(string file)
        {
            return File.Exists(file) ? new Serializer<Campaign>(SerializerType.Json, file, true, true).Data : null;
        }

        public bool Validate()
        {
            return true;
        }

        public static implicit operator bool(Campaign campaign) => !(campaign is null);
    }
}
