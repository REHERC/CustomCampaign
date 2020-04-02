using System.Collections.Generic;
using UnityEngine;

namespace CustomCampaign.LevelEditor
{
    public static class EditorToolset
    {
        public static Dictionary<ToolCategory, int> CategorySort = new Dictionary<ToolCategory, int>();
        public static void Initialize()
        {
        }

        public static void Inspect(GameObject Target)
        {
            NGUIObjectInspectorTab Inspector = Object.FindObjectOfType<NGUIObjectInspectorTab>();

            var Editor = G.Sys.LevelEditor_;

            if (Editor && Inspector)
            {
                //Editor.ClearSelectedList();
                //Editor.SelectObject(Target);
                Editor.activeObject_ = Target;
                Inspector.targetObject_ = Target;
                Inspector.ClearComponentInspectors();
                Inspector.InitComponentInspectorsOnTargetObject();
                Inspector.InitAddComponentButton();
                Inspector.propertiesNeedToBeUpdated_ = false;
            }
        }
    }
}
