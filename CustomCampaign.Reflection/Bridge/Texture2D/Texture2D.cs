#if BRIDGING
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

#pragma warning disable IDE0044, RCS1129, CA1810

namespace Bridge
{
    public static class Texture2D
    {
        public static bool ThrowExceptions = true;
        internal const string TypeFullName = "UnityEngine.Texture2D";
        private readonly static Type ObjectType = null;

        static Texture2D()
        {
            Assembly unity = Assembly.GetAssembly(typeof(GameObject));
            ObjectType = unity.GetType(TypeFullName);
        }

        public static object CreateTexture2D(params object[] parameters)
        {
            if (ObjectType is null)
            {
                if (ThrowExceptions)
                {
                    throw new Exception($"Unable to instantiate type \"{TypeFullName}\".");
                }
            }
            else
            {
                return null;
            }

            List<Type> signature = new List<Type>();
            foreach (var parameter in parameters)
            {
                signature.Add(parameter.GetType());
            }
            ConstructorInfo constructor = ObjectType.GetConstructor(signature.ToArray());

            return constructor.Invoke(parameters);
        }
    }
}
#endif