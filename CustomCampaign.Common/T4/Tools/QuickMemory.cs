#pragma warning disable IDE1006, CA1034

using CustomCampaign.LevelEditor.Attributes;

namespace CustomCampaign.LevelEditor.Tools.View.Quick_Select.Instances
{
    public static class QuickMemory1
    {
        public static int AccessIndex = 1;

        [ToolKeyboardShortcut("CTRL+ALPHA1")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 1", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1110);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA1")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 1", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1115);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory2
    {
        public static int AccessIndex = 2;

        [ToolKeyboardShortcut("CTRL+ALPHA2")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 2", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1120);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA2")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 2", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1125);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory3
    {
        public static int AccessIndex = 3;

        [ToolKeyboardShortcut("CTRL+ALPHA3")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 3", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1130);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA3")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 3", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1135);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory4
    {
        public static int AccessIndex = 4;

        [ToolKeyboardShortcut("CTRL+ALPHA4")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 4", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1140);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA4")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 4", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1145);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory5
    {
        public static int AccessIndex = 5;

        [ToolKeyboardShortcut("CTRL+ALPHA5")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 5", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1150);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA5")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 5", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1155);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory6
    {
        public static int AccessIndex = 6;

        [ToolKeyboardShortcut("CTRL+ALPHA6")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 6", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1160);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA6")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 6", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1165);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory7
    {
        public static int AccessIndex = 7;

        [ToolKeyboardShortcut("CTRL+ALPHA7")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 7", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1170);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA7")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 7", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1175);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory8
    {
        public static int AccessIndex = 8;

        [ToolKeyboardShortcut("CTRL+ALPHA8")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 8", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1180);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA8")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 8", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1185);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
    public static class QuickMemory9
    {
        public static int AccessIndex = 9;

        [ToolKeyboardShortcut("CTRL+ALPHA9")]
        public class SaveMemory1 : SaveSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Save Selection 9", "Saves the inspected object into the memory.", ToolCategory.View, ToolButtonState.Button, true, 1190);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }

        [ToolKeyboardShortcut("SHIFT+ALPHA9")]
        public class LoadMemory1 : LoadSelectionToolBase
        {
            internal static new ToolInfo info_ => new ToolInfo("Load Selection 9", "Inspects the object saved into the memory.", ToolCategory.View, ToolButtonState.Button, false, 1195);

            public override ToolInfo Info_ => info_;

            public override int QuickAccessIndex => AccessIndex;

            public static new void Register()
            {
                G.Sys.LevelEditor_.RegisterTool(info_);
            }
        }
    }
}
