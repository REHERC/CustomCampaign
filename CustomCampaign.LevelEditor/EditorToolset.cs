using System.Collections.Generic;
using UnityEngine;

namespace CustomCampaign.LevelEditor
{
    public static class EditorToolset
    {
        public static Dictionary<ToolCategory, int> CategorySort = new Dictionary<ToolCategory, int>();
        public static Dictionary<int, GameObject> QuickSelectMemory = new Dictionary<int, GameObject>();
        public static void Initialize()
        {
        }

        public static void SetQuickMemory(int index, GameObject instance)
        {
            QuickSelectMemory[index] = instance;
        }

        public static GameObject GetQuickMemory(int index)
        {
            if (QuickSelectMemory.ContainsKey(index))
            {
                return QuickSelectMemory[index];
            }
            else
            {
                return null;
            }
        }

        public static void Inspect(GameObject Target)
        {
            NGUIObjectInspectorTab Inspector = Object.FindObjectOfType<NGUIObjectInspectorTab>();

            var Editor = G.Sys.LevelEditor_;

            if (Editor && Inspector)
            {
                Editor.activeObject_ = Target;
                Inspector.targetObject_ = Target;
                Inspector.ClearComponentInspectors();
                Inspector.InitComponentInspectorsOnTargetObject();
                Inspector.InitAddComponentButton();
                Inspector.propertiesNeedToBeUpdated_ = false;
                Inspector.objectNameLabel_.text = Inspector.targetObject_.GetDisplayName();
            }
        }
    }
}
