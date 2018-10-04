using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace CustomCampaign
{
    public class ResourceBlindfolder
    {
        [HarmonyPatch(typeof(Resources), "Load", new Type[] { typeof(string)})]
        internal class ResourcesLoader
        {
            static void Postfix(string path)
            {
                
            }
        }
    }
}
