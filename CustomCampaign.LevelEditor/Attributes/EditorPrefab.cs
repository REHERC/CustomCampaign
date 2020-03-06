using CustomCampaign.LevelEditor.Enums;
using System;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class EditorPrefabAttribute : Attribute
    {
        internal string Path { get; set; }
        internal string Name { get; set; }
#if !LIMITED_COMPATIBILITY
        internal Texture2D Icon { get; set; }
#endif
        internal PrefabType BasePrefab { get; set; }
        internal string Prefab { get; set; }

        public EditorPrefabAttribute(string path, string name, PrefabType prefab_type, string prefab = "")
        {
            Path = path;
            Name = name;
            BasePrefab = prefab_type;
            Prefab = prefab;
        }

#if !LIMITED_COMPATIBILITY
        public EditorPrefabAttribute(string path, string name, Texture2D icon, PrefabType prefab_type, string prefab = "") : this(path, name, prefab_type, prefab)
        {
            Icon = icon;
        }
#endif
    }
}
