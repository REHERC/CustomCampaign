using CustomCampaign.SDK.Data;
using Photon.Serialization;
using System.Collections.Generic;
using System.IO;

#pragma warning disable RCS1003
namespace CustomCampaign
{
    public class AddonInfo
    {
        public string Id { get; set; }
        public List<string> Dependencies { get; set; }
        public string Module { get; set; }
        public string Name { get; set; }
        public List<Author> Authors { get; set; }

        public static AddonInfo Load(CampaignInfo campaign, string manifest)
        {
            string path = Path.GetFullPath($"{campaign.DataDirectory}/{manifest}");
            if (File.Exists(path))
            {
                AddonInfo info = new Serializer<AddonInfo>(SerializerType.Json, path, true, true).Data;
                info.Id = campaign.Id;
                return info;
            }
            else return null;
        }
    }
}
