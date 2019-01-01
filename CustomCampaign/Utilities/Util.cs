﻿using System;
using System.IO;
using UnityEngine;

namespace CustomCampaign
{
    internal static class Util
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

        public static bool ResourceExists<T>(string name) where T : UnityEngine.Object
        {
            T resource = Resources.Load<T>(name);
            bool exists = !(resource == null);
            Console.WriteLine($"{name} : {exists}");
            return exists;
        }

        public static string TrimLeft(string Input, string Cut)
        {
            if (Input.StartsWith(Cut))
            {
                return Input.Substring(Input.Length - 1, Input.Length - Cut.Length);
            }
            else return Input;
        }


        public static string PluginLevelRedirect(this string path)
        {
            if (path.Replace("/", @"\").StartsWith(Plugin.LevelsFolder().Replace("/", @"\") + @"\CustomCampaign"))
            {
                return (Plugin.GetPluginFolder() + @"\Levels" + path.Substring((Plugin.LevelsFolder() + @"\CustomCampaign").Length)).Replace("/", @"\");
            }
            return path;
        }

        public static string GetForwardPath(this string path)
        {
            return path.Replace(Path.DirectorySeparatorChar, '/');
        }

        public static string NormPath(this string input)
        {
            return Resource.NormalizePath(input.ToLower()).Normalize();
        }
    }
}
