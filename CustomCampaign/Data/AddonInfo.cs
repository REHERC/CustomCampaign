using CustomCampaign.SDK.Data;
using Photon.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

#pragma warning disable RCS1003
namespace CustomCampaign
{
    [DataContract, Serializable]
    public class AddonInfo
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

        public string RootDirectory { get; set; }

        public static AddonInfo Load(CampaignInfo campaign, string manifest)
        {
            string path = Path.GetFullPath($"{campaign.DataDirectory}/{manifest}");
            if (File.Exists(path))
            {
                AddonInfo info = new Serializer<AddonInfo>(SerializerType.Json, path, true, true).Data;
                info.Id = campaign.Id;
                info.RootDirectory = campaign.DataDirectory;
                return info;
            }
            else return null;
        }
    }
}
