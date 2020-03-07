#pragma warning disable SecurityIntelliSenseCS, CSCS0168, RCS1001, RCS1206

using CustomCampaign.Data;
using CustomCampaign.Storage;
using CustomCampaign.Systems;
using System;
using System.Collections.Generic;
using System.IO;

/* Unmerged change from project 'CustomCampaign.Plugin.Centrifuge'
Before:
using UnityEngine;
After:
using System.Linq;
*/
using System.Linq;

/* Unmerged change from project 'CustomCampaign.Plugin.Centrifuge'
Before:
using System.Linq;
After:
using UnityEngine;
*/
using System.Reflection;
using UnityEngine;

namespace CustomCampaign.Utils
{
    public static class Common
    {
        #region Game Manager Fields
        public static string LevelFile => G.Sys.GameManager_.LevelPath_;
        public static string LastLevelFile => G.Sys.GameManager_.LastLevelPath_;
        public static string NextLevelFile => G.Sys.GameManager_.LastLevelPath_;
        #endregion
        #region Api Utils
        public static string GetFilePath(string path, bool campaign_by_default = false)
        {
            if (string.IsNullOrEmpty(path) || path.Length < 2) return path;

            string result;
            switch (path[0])
            {
                // From campaign dir
                case '@':
                    CampaignInfo info = Campaign.GetCampaign(Assembly.GetCallingAssembly());
                    result = new FileInfo(Path.Combine(info.Location, path.Substring(1))).FullName;
                    break;
                // From plugin dir
                case '#':
                    result = new FileInfo(Path.Combine(Plugin.Files.RootDirectory, path.Substring(1))).FullName;
                    break;
                // From assembly dir
                case ':':
                    result = new FileInfo(Path.Combine(Assembly.GetCallingAssembly().Location, path.Substring(1))).FullName;
                    break;
                default:
                    return campaign_by_default ? GetFilePath($"@{path}", false) : path;
            }
            return result;
        }
        #endregion
        #region Unity And Game Utils
        public static GameObject FindByName(string name)
        {
            foreach (var go in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
            {
                if (go.name == name)
                {
                    return go as GameObject;
                }
            }
            return null;
        }

        public static LevelInfo LevelInfoFromPath(string path)
        {
            LevelSettings settings = LevelSettings.CreateAndLoadFromPath(path, out bool _);
            return LevelInfo.Create(path, settings);
        }

#if API_SPECTRUM && !LIMITED_COMPATIBILITY
        public static Texture LoadTexture(string filepath)
        {
            Texture2D result = null;
            if (File.Exists(filepath))
            {
                byte[] imagedata = File.ReadAllBytes(filepath);
                result = new Texture2D(2, 2);
                result.LoadImage(imagedata);
            }
            return result;
        }

#endif
#if API_CENTRIFUGE && !LIMITED_COMPATIBILITY
        public static Texture LoadTexture(string filepath)
        {
            object result = null;
            if (File.Exists(filepath))
            {
                byte[] imagedata = File.ReadAllBytes(filepath);
                result = Bridge.Texture2D.CreateTexture2D(2, 2);
                result.CallMethod("LoadImage", imagedata);
            }
            return result as Texture;
        }
#endif
        #endregion
        #region Other Utils
        public static void MakeDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        public static List<Type> GetExportedTypesOfType(Type baseType)
        {
            List<Type> typeList = new List<Type>();

            List<Assembly> assemblies = new List<Assembly>();
            assemblies.AddRange(AddonSystem.GetAssemblies().Select((entry) => entry.Key.Object));
            assemblies.Add(Assembly.GetAssembly(typeof(Entry)));

            foreach (Assembly asm in assemblies)
            {
                Type[] asmTypes = asm.GetTypes();
                foreach (Type type in asmTypes)
                    if (baseType.IsAssignableFrom(type) && type != baseType)
                        typeList.Add(type);
            }

            return typeList;
        }
        #endregion
    }
}