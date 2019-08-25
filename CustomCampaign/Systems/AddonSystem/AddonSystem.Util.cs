using CustomCampaign.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomCampaign.Systems
{
    public static partial class AddonSystem
    {
        public static List<KeyValuePair<ObjectWithGUID<Api.Addon>, string>> GetAddons() => Addons.ToList();
        public static List<KeyValuePair<ObjectWithGUID<Api.Addon>, string>> GetAddons(string guid) => Addons.Where((item) => item.Value == guid).ToList();
    }
}