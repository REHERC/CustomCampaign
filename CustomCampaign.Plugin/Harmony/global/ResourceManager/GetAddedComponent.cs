using Harmony;
using System;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(ResourceManager), "GetAddedComponent")]
    public static class ResourceManager_GetAddedComponent
    {
        public static void Prefix(ResourceManager __instance, Type compType)
        {
            if (__instance.addedComponentsPrefab_.GetComponents(compType).Length == 0)
            {
                __instance.addedComponentsPrefab_.AddComponent(compType);
            }
        }
    }
}
