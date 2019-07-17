using Newtonsoft.Json;
using System.Collections.Generic;

namespace CustomCampaign.Models
{
    public class Campaign
    {
        [JsonProperty(Required = Required.Default)]
        public const ulong version = 1;

        public string name = "";
        public string description = "";
        public string logopath = "";
        public string authors = "";
        public int lockmode = 0;
        public int gamemode = 15;
        public List<Level> levels = new List<Level>();
        public List<Addon> addons = new List<Addon>();
    }
}
