#if false
using Serializers;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Extensions
{
    public static class IVisitorEx
    {
        public static bool IsEditorInspector(this IVisitor visitor)
        {
            return visitor is NGUIComponentInspector;
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref bool val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref int val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref uint val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref short val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref ushort val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref long val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref char val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref float val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref double val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref string val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref DateTime val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Vector2 val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Vector3 val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Vector4 val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Quaternion val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Color val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Bounds val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Material val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref PhysicMaterial val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref string[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref Material[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref float[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref double[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref int[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref byte[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref MedalStatus[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, ref options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref MaterialInfo[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitArrayHidden(this IVisitor visitor, string elem, ref bool[] val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitArray(elem, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref List<KeyValuePair<string, string>> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<string, bool> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }
        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<string, int> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }
        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<string, float> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }
        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<string, string> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<int, bool> val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        
        public static void VisitHidden(this IVisitor visitor, string name, ref Dictionary<GameModeID, MedalStatus> val, ref string keyOptions, ref string valueOptions)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, ref keyOptions, ref valueOptions);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref SerialRenderer val, SerialRenderer prefab, int version)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, prefab, version);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref SerialCollider val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitHidden(this IVisitor visitor, string name, ref SerialUtils.BoolState val, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.Visit(name, ref val, options);
            }
        }

        public static void VisitReferenceHidden<T>(this IVisitor visitor, string name, T val, Deserializer.SetReferenceCallback cb) where T : class
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitReference(name, val, cb);
            }
        }

        public static void VisitLabelHidden(this IVisitor visitor, string name, ref NGUILabelInspector.Label val, bool visible, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitLabel(name, ref val, visible, options);
            }
        }

        public static void VisitActionHidden(this IVisitor visitor, string name, System.Action val, bool visible, string options = null)
        {
            if (!visitor.IsEditorInspector())
            {
                visitor.VisitAction(name, val, visible, options);
            }
        }
    }
}
#endif