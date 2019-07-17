using CustomCampaign.Models;
using Photon.Serialization;

namespace CustomCampaign.Editor
{
    public static class Config
    {
        public static Serializer<AppSettings> AppSettings = new Serializer<AppSettings>(SerializerType.Json, "config.json", true);
    }
}
