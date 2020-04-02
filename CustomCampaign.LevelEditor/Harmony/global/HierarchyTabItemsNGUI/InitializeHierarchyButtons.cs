using Harmony;

namespace CustomCampaign.LevelEditor.Harmony
{
    [HarmonyPatch(typeof(HierarchyTabItemsNGUI), "InitializeHierarchyButtons")]
    internal static class InitializeHierarchyButtons
    {
        internal static bool Prefix(HierarchyTabItemsNGUI __instance)
        {
            if (Common.HierarchyTabLogic.Target != null)
            {
                __instance.ClearHierarchyButtons();

                __instance.AddLayer(Common.HierarchyTabLogic.VirtualLayer, 0);

                __instance.buttonList_.SortAndUpdateVisibleButtons();

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
