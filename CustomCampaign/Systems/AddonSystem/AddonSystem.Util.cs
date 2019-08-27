using CustomCampaign.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CustomCampaign.Systems
{
    internal static partial class AddonSystem
    {
        internal static List<KeyValuePair<ObjectWithGUID<Api.Addon>, string>> GetAddons() => Addons.ToList();
        internal static List<KeyValuePair<ObjectWithGUID<Api.Addon>, string>> GetAddons(string guid) => Addons.Where((item) => item.Value == guid).ToList();
        internal static List<KeyValuePair<ObjectWithGUID<Assembly>, string>> GetAssemblies() => Assemblies.ToList();
    }
}