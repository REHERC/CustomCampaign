﻿using CustomCampaign.LevelEditor.Components;
using Serializers;
using System;
using System.Reflection;
using UnityEngine;

namespace CustomCampaign.Storage
{
    public static class LevelEditor
    {
        public static void Initialize()
        {
            GameObject host = G.Sys.ResourceManager_.addedComponentsPrefab_;

            foreach (Type type in Utils.Common.GetExportedTypesOfType(typeof(AddedComponent)))
            {
                AddComponentToPrefab(type, host);
                AddToTypeMap(type);
            }

            DataWrapper.Register();
        }

        public static void AddToTypeMap(Type value)
        {
            MethodInfo method = value.GetMethod("GetID", BindingFlags.Static | BindingFlags.Public);
            if (method != null)
            {
                ComponentID key = (ComponentID)method.Invoke(null, null);
                if (!BinaryDeserializer.idToSerializableTypeMap_.ContainsKey(key) && !BinaryDeserializer.idToSerializableTypeMap_.ContainsValue(value))
                {
                    BinaryDeserializer.idToSerializableTypeMap_.Add(key, value);
                }
            }
        }

        private static void AddComponentToPrefab(Type value, GameObject host)
        {
            if (host.GetComponents(value).Length == 0)
            {
                host.AddComponent(value);
            }
        }
    }
}
