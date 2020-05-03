#pragma warning disable CA1034

using CustomCampaign.LevelEditor.Attributes;
using CustomCampaign.Data;
using CustomCampaign.Storage;
using LevelEditorTools;
using Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Components
{
    [HideComponent]
    public class DataWrapper : AddedComponent
    {
        #region Initialization Stuff
        public static Dictionary<string, Type> ReferenceMap = new Dictionary<string, Type>();

        public static void Register()
        {
            foreach (var Type in Utils.Common.GetExportedTypesOfType(typeof(IData)))
            {
                if (!Type.IsSubclassOf(typeof(Component)))
                {
                    IData Instance = Activator.CreateInstance(Type) as IData;

                    ReferenceMap.Add(Instance.DataIdentifier, Type);
                }
            }
        }
        #endregion

        #region Added Component Infos
        #region Add And Remove Component Classes
        public class Add : AddComponentTool<DataWrapper>
        {
            public override bool ValidateObject(out string errorMessage, GameObject obj)
            {
                errorMessage = string.Empty;
                return true;
            }
        }

        public class Remove : RemoveComponentTool<DataWrapper>
        {
        }
        #endregion

        public override string DisplayName_ => $"Custom Component";
        public static string description_ = "(no description)";

        public override int Version_ => 2;
        public override string ComponentDescription_ => description_;
        public override Type AddTool_ => typeof(Add);
        public override Type RemoveTool_ => typeof(Remove);
        public override ComponentID ID_ => GetID();
        public static ComponentID GetID() => (ComponentID)1005;
        #endregion

        #region Properties
        public IData Data => data;
        #endregion

        #region Serializable Fields
        protected IData data = null;
        protected string identifier = string.Empty;
        protected string identifier_options = Options.Description.Format("Internal id to select which IData provider to use for serialization.");
        #endregion

        public override void Visit(IVisitor visitor, ISerializable prefabComp, int version)
        {
            visitor.Visit("wrapper.identifier", ref identifier, identifier_options);

            switch (visitor)
            {
                case Deserializer _:
                    if (ReferenceMap.TryGetValue(identifier, out Type Type))
                    {
                        data = Activator.CreateInstance(Type) as IData;
                    }
                    break;
            }

            data?.VisitData(visitor, prefabComp, version);
        }

        #region IO Methods
        public static DataWrapper Create<DATA>(DATA Source = null) where DATA : class, IData, new()
        {
            GameObject Group = Resource.LoadPrefabInstance("Group");
            DataWrapper Component = Group.AddComponent<DataWrapper>();
            Component.data = Source ?? new DATA();
            Component.identifier = Component.Data.DataIdentifier;
            return Component;
        }

        public static DataWrapper LoadComponent<DATA>(string Path) where DATA : class, IData, new()
        {
            FileInfo FileInfo = new FileInfo(Path);

            if (FileInfo.Exists)
            {
                GameObject Load = Resource.LoadPrefabInstance("Group");
                DataWrapper LoadComponent = Load.AddComponent<DataWrapper>();
                BinaryDeserializer.LoadComponentFile(FileInfo.FullName, Load, null);
                return LoadComponent;
            }
            else
            {
                return Create<DATA>();
            }
        }

        public static DATA Load<DATA>(string Path) where DATA : class, IData, new()
        {
            return LoadComponent<DATA>(Path).Data as DATA;
        }

        public static void SaveComponent<DATA>(string Path, DataWrapper Wrapper) where DATA : class, IData, new()
        {
            FileInfo FileInfo = new FileInfo(Path);

            if (FileInfo.Exists)
            {
                FileInfo.Delete();
            }

            BinarySerializer.SaveComponentFile(FileInfo.FullName, Wrapper, null);
        }

        public static void Save<DATA>(string Path, DATA Source) where DATA : class, IData, new()
        {
            SaveComponent<DATA>(Path, Create<DATA>(Source));
        }

        public static byte[] ToBytes<DATA>(DATA Source) where DATA : class, IData, new()
        {
            return BinarySerializer.SaveComponentToBytes(Create<DATA>(Source), null);
        }

        public static DATA FromBytes<DATA>(byte[] Source) where DATA : class, IData, new()
        {
            GameObject Load = Resource.LoadPrefabInstance("Group");
            DataWrapper LoadComponent = Load.AddComponent<DataWrapper>();

            BinaryDeserializer.LoadComponentContentsFromBytes(LoadComponent, null, Source);

            return LoadComponent.Data as DATA;
        }
    }
    #endregion
}