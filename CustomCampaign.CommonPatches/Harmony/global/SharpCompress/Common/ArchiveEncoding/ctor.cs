﻿using Harmony;
using System.Text;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(global::SharpCompress.Common.ArchiveEncoding), MethodType.Constructor)]
    internal static class ConstructArchiveEncoding
    {
        internal static bool Prefix(global::SharpCompress.Common.ArchiveEncoding __instance)
        {
            __instance.Default = Encoding.UTF8;
            __instance.Password = Encoding.UTF8;

            return false;
        }
    }
}