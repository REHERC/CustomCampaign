using CustomCampaign.LevelEditor.Abstractions;
using System.Collections.Generic;

namespace CustomCampaign.LevelEditor.Scripts
{
    public static class ScriptManager
    {
        public static Dictionary<string, EditorScript> Scripts = new Dictionary<string, EditorScript>();

        public static void LoadScript<SCRIPT>() where SCRIPT : EditorScript, new()
        {
            SCRIPT instance = EditorScript.Create<SCRIPT>();
            Scripts.Add(instance.Id, instance);
        }
    }
}
