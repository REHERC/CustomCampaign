using CustomCampaign.Models;
using Photon.Serialization;

#pragma warning disable CS0436

namespace CustomCampaign.Editor
{
    public static class Config
    {
        public static Serializer<AppSettings> AppSettings = new Serializer<AppSettings>(SerializerType.Json, "config.json", true);
    }
}
