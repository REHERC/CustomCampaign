using CustomCampaign.LevelEditor.Attributes;
using CustomCampaign.Storage;
using Harmony;
using LevelEditorTools;
using System;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(ToolInputCombos), "Load")]
    internal static class LoadToolInputCombos
    {
        internal static void Postfix(ref ToolInputCombos __result, ref string fileName)
        {
            switch (fileName)
            {
                case "BlenderToolInputCombos":  // Scheme A
                    AddCustomHotkeys(ref __result, 'A');
                    break;
                case "UnityToolInputCombos":    // Scheme B
                    AddCustomHotkeys(ref __result, 'B');
                    break;
            }
        }

        internal static void AddCustomHotkeys(ref ToolInputCombos __result, char scheme)
        {
            foreach (Type tooltype in Utils.Common.GetExportedTypesOfType(typeof(LevelEditorTool)))
            {
                LevelEditorTool instance = Activator.CreateInstance(tooltype) as LevelEditorTool;

                foreach (var attribute in tooltype.GetCustomAttributes(true))
                {
                    switch (attribute)
                    {
                        case ToolKeyboardShortcutAttribute input:
                            __result.Add(input.Get(scheme).ToString(), instance.Info_.Name_);
                            break;
                    }
                }
            }
        }
    }
}
