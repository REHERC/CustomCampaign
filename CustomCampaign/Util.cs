using UnityEngine;

namespace CustomCampaign
{
    internal static class Util
    {
        public static GameObject FindByName(string name)
        {
            foreach (var go in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
                if (go.name == name)
                    return go as GameObject;
            return null;
        }
    }
}
