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
    }
}
