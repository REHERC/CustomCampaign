using Harmony;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Component_Actions
{
    [HarmonyPatch(typeof(Group), "Visit")]
    internal static class VititGroup
    {
        internal static void Postfix(Group __instance, IVisitor visitor)
        {
            if (!(visitor is Serializers.Serializer) && !(visitor is Serializers.Deserializer))
            {
                GameObject[] SubObjects = __instance.gameObject.GetChildren();
                if (SubObjects.Length > 0)
                {
                    visitor.VisualLabel("Group Hierarchy");

                    int Index = 1;

                    foreach (GameObject Children in SubObjects)
                    {
                        string Name = Children.name;

                        if (Children.HasComponent<CustomName>())
                        {
                            CustomName CustomNameComponent = Children.GetComponent<CustomName>();
                            Name = $"[b]{CustomNameComponent.CustomName_}[/b]";
                        }

                        visitor.VisitAction($"Inspect {Name} (#{Index})", () => EditorToolset.Inspect(Children), null);

                        ++Index;
                    }
                }
            }
        }
    }
}
