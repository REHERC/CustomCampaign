using System;

namespace CustomCampaign.LevelEditor.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ToolKeyboardShortcutAttribute : Attribute
    {
        public InputEvent SchemeA { get; }
        public InputEvent SchemeB { get; }

        public ToolKeyboardShortcutAttribute(string A)
        {
            SchemeA = SchemeB = InputEvent.Create(A);
        }

        public ToolKeyboardShortcutAttribute(string A, string B)
        {
            SchemeA = InputEvent.Create(A);
            SchemeB = InputEvent.Create(B);
        }

        public InputEvent Get (char scheme)
        {
            switch (scheme)
            {
                case 'A':
                    return SchemeA;
                case 'B':
                    return SchemeB;
                default:
                    return null;
            }
        }
    }
}
