#pragma warning disable CA1034

using CustomCampaign.LevelEditor.Attributes;
using CustomCampaign.Data;
using LevelEditorTools;
using Serializers;
using System;
using System.Collections.Generic;
using UnityEngine;
using CustomCampaign.LevelEditor.Scripts;

namespace CustomCampaign.LevelEditor.Components
{
    [HideComponent]
    public class ComponentWrapper : AddedComponent
    {
        #region Initialization Stuff
        public static Dictionary<string, Type> ReferenceMap = new Dictionary<string, Type>();

        public static void Register()
        {
            foreach (var Type in Utils.Common.GetExportedTypesOfType(typeof(IData)))
            {
                if (!Type.IsSubclassOf(typeof(EditorScript)))
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
        public static ComponentID GetID() => (ComponentID)1006;
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
    }
}