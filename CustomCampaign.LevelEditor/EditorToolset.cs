using System.Collections.Generic;
using UnityEngine;

namespace CustomCampaign.LevelEditor
{
    public static class EditorToolset
    {
        public static Dictionary<int, GameObject> QuickSelectMemory { get; set; }  = new Dictionary<int, GameObject>();
    }
}
