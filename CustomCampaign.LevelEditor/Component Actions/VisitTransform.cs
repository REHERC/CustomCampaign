using Harmony;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Component_Actions
{
    [HarmonyPatch(typeof(TransformWrapper), "Visit")]
    internal static class VititTransform
    {
        internal static void Prefix(TransformWrapper __instance, IVisitor visitor)
        {
            if (!(visitor is Serializers.Serializer) && !(visitor is Serializers.Deserializer))
            {
                Transform ObjectTransform = __instance.tComponent_;
                if (!ObjectTransform.IsRoot())
                {
                    visitor.VisitAction("Inspect Parent", () => {
                        var Editor = G.Sys.LevelEditor_;
                        var Selection = Editor.SelectedObjects_;
                        if (Selection.Count == 1)
                        {
                            EditorToolset.Inspect(ObjectTransform.parent.gameObject);
                        }
                        else
                        {
                            G.Sys.MenuPanelManager_.ShowError("ERROR", "You must select only 1 object to use this tool.");
                        }
                    }, null);
                }
            }
        }
    }
}
