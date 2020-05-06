#pragma warning disable IDE1006, RCS1192
using LevelEditorTools;
using System;
using System.Collections.Generic;

namespace CustomCampaign.LevelEditor.Tools.Others
{
    public class AddCustomComponentTool : SelectStringFromListTool
    {
        internal static ToolInfo info_ => new ToolInfo("Add Custom Component", "Select a modded script from a list.", ToolCategory.Others, ToolButtonState.Button, false, 1100)
        {
            CancelsAllOtherTools_ = true
        };
        public override ToolInfo Info_ => info_;

        public static void Register()
        {
            G.Sys.LevelEditor_.RegisterTool(info_);
        }

        public override string NoEntriesError_ => "No existing component found";

        public override string Title_ => "Scripts:";

        public override string ValueName_ => "Script";

        public override void AddEntries(Dictionary<string, string> entryList)
        {
            entryList.Add(@"TEST1", "Test 1");
            entryList.Add(@"TEST2", "Test 2");
            entryList.Add(@"TEST3\TEST3", "Test 2");
        }

        public static void StartTool(ISerializable s, Action<string> setFn)
        {
            StartToolP<AddCustomComponentTool>(s, setFn);
        }
    }
}
