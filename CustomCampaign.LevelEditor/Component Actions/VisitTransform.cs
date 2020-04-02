using Harmony;

namespace CustomCampaign.LevelEditor.Component_Actions
{
    [HarmonyPatch(typeof(TransformWrapper), "Visit")]
    internal static class VititTransform
    {
        internal static void Postfix(IVisitor visitor)
        {
            if (!(visitor is Serializers.Serializer) && !(visitor is Serializers.Deserializer))
            {
                visitor.VisitAction("Parent Object To Current Hierarchy", () => { }, null);
                visitor.VisitAction("Reset Object Hierarchy", () => { }, null);
            }
        }
    }
}
