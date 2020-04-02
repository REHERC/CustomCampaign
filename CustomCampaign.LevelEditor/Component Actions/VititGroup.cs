using Harmony;

namespace CustomCampaign.LevelEditor.Component_Actions
{
    [HarmonyPatch(typeof(Group), "Visit")]
    internal static class VititGroup
    {
        internal static void Postfix(IVisitor visitor)
        {
            if (!(visitor is Serializers.Serializer) && !(visitor is Serializers.Deserializer))
            {
                visitor.VisitAction("Inspect Parent Object", () => { }, null);
                visitor.VisitAction("Inspect Object Hierarchy", () => { }, null);
            }
        }
    }
}
