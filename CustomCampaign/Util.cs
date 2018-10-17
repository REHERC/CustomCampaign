using System;
using UnityEngine;

namespace CustomCampaign
{
    internal class Util
    {
        public static GameObject FindByName(string name)
        {
            foreach (var go in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
            {
                if (go.name == name)
                    return go as GameObject;
            }
            return null;
        }

        public static bool ResourceExists<T>(string name) where T: UnityEngine.Object
        {
            T resource = Resources.Load<T>(name);
            bool exists = !(resource == null);
            Console.WriteLine($"{name} : {exists}");
            return true;
        }
    }
}
