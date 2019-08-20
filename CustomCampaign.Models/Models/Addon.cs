using Photon.Serialization;
using System.Collections.Generic;
using System.IO;

namespace CustomCampaign.Models
{
    public class Addon
    {
        public string module = "";
        public List<string> dependencies = new List<string>();

        public static Addon FromFile(string file)
        {
            return File.Exists(file) ? new Serializer<Addon>(SerializerType.Json, file, true, true).Data : null;
        }
    }
}
