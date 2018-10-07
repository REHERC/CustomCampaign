using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;

namespace CustomCampaign
{
    [HarmonyPatch(typeof(GameManager), new Type[] { typeof(string) })]
    [HarmonyPatch("LoadLevel")]
    public class GameManager__LoadLevel__Patch
    {
        static void Prefix(string levelPath)
        {
            Console.WriteLine($"GameManager - Load level \"{levelPath}\"");
        }
    }

    [HarmonyPatch(typeof(Level))]
    [HarmonyPatch("LoadFromPath")]
    public class Level__LoadFromPath__Patch
    {
        static void Prefix(string levelPath)
        {
            Console.WriteLine($"Level - Load level \"{levelPath}\"");
        }
    }
}
