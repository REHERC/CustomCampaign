using System;

namespace CustomCampaign.LevelEditor.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class HideComponentAttribute : Attribute
    {
    }
}