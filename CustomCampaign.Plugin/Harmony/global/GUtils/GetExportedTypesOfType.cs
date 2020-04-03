using Harmony;
using LevelEditorTools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(GUtils), "GetExportedTypesOfType")]
    internal static class GetExportedTypesOfType
    {
        internal static void Postfix(Type baseType, ref Type[] __result)
        {
            List<Type> types = __result.ToList();

            if (new List<Type>() {
                typeof(ISerializable),
                typeof(LevelEditorTool),
                typeof(AddedComponent)
            }.Contains(baseType))
            {
                types.AddRange(Utils.Common.GetExportedTypesOfType(baseType));
            }
            __result = types.ToArray();
        }
    }
}