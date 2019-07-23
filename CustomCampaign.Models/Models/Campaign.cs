using CustomCampaign.Models.Validators;
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

        [JsonIgnore]
        private FileValidator FileIncludeValidator = new FileValidator();

        public static Campaign FromFile(string file)
        {
            return File.Exists(file) ? new Serializer<Campaign>(SerializerType.Json, file, true, true).Data : null;
        }

        public List<string> IncludedFiles(string rootdirectory = "") => FileIncludeValidator.DefaultInclude(this, rootdirectory);

        public bool Validate(string rootdirectory)
        {
            bool result = true;

            result &= FileIncludeValidator.Validate(this, rootdirectory);

            return result;
        }

        public static implicit operator bool(Campaign campaign) => !(campaign is null);

        public enum UnlockStyle
        {
            Campaign = 0,
            LevelSet = 1
        }
    }
}
