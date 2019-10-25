using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;

#pragma warning disable IDE0044

namespace Bridge
{
    public class Texture2D
    {
        public static bool ThrowExceptions = false;
        const string TypeFullName = "UnityEngine.Texture2D";
        private static Type ObjectType = null;

        static Texture2D()
        {
            ObjectType = Type.GetType(TypeFullName);
        }

        public static object CreateTexture2D(params object[] parameters)
        {
            if (ObjectType is null) if (ThrowExceptions) throw new Exception($"Unable to instantiate type \"{TypeFullName}\"."); else return null;

            List<Type> signature = new List<Type>();
            foreach (var parameter in parameters)
                signature.Add(parameter.GetType());

            ConstructorInfo constructor = ObjectType.GetConstructor(signature.ToArray());

            return constructor.Invoke(parameters);
        }
    }
}
