#pragma warning disable RCS1073
using UnityEngine;

namespace CustomCampaign.LevelEditor.Harmony
{
    public static class Common
    {
        internal static class HierarchyTabLogic
        {
            private static Transform target_;
            public static Transform Target
            {
                get
                {
                    return target_;
                }
                set
                {
                    target_ = value;
                    LevelLayer temp = RefreshVirtualLayer();
                    if (temp.GameObjects_.Count > 0)
                    {
                        VirtualLayer = temp;
                        RefreshHierarchy();
                    }
                }
            }

            public static LevelLayer VirtualLayer;

            public static void RefreshHierarchy()
            {
                HierarchyTabItemsNGUI tab = Object.FindObjectOfType<HierarchyTabItemsNGUI>();

                if (tab)
                {
                    tab.InitializeHierarchyButtons();
                }
            }

            public static LevelLayer RefreshVirtualLayer()
            {
                var layer = new LevelLayer($"[93D43D]Hierarchy of {Target.name}[-]", true, true);
                if (Target.HasComponent<Group>())
                {
                    Group group = Target.GetComponent<Group>();
                    foreach (GameObject children in group.gameObject.GetChildren())
                    {
                        if (children.HasComponent<Group>()) {
                            Group childrengroup = children.GetComponent<Group>();
                            layer.Add(childrengroup.gameObject);
                        }
                        else
                        {
                            layer.Add(children);
                        }
                    }
                }
                return layer;
            }

            public static void SetHierarchyTarget(GameObject value)
            {
                SetHierarchyTarget(value.transform);
            }

            public static void SetHierarchyTarget(Transform value)
            {
                Target = value;
                RefreshHierarchy();
            }

            internal static class Tool
            {
                public static void InspectRoot()
                {
                    SetHierarchyTarget(null as Transform);
                }

                public static void InspectObject(GameObject value)
                {
                    SetHierarchyTarget(value);
                }

                public static bool InspectParent(GameObject value)
                {
                    Transform parent = value.transform.parent;
                    if (!IsAtRootLevel(value) && parent)
                    {
                        SetHierarchyTarget(parent);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static bool IsAtRootLevel(GameObject value)
                {
                    return value.transform.IsRoot();

                    /*
                    Transform parent = value.transform.parent;
                    if (parent && parent.HasComponent<Group>()) {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    */
                }
            }
        }
    }
}
