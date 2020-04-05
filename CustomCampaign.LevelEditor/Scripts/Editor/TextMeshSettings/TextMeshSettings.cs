#pragma warning disable RCS1213, IDE0051
using CustomCampaign.LevelEditor.Abstractions;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Scripts.Editor
{
    public class TextMeshSettings : EditorScript
    {
        public override string Id => "customcampaign.scripts.textmeshsettings";
        public override string Folder => "Default Scripts/";
        public override string Name => "Text Mesh Settings";
        public override string Description => "Provides additional properties for text mesh objects.";

        #region Component Properties
        public TextAnchor anchor_ = TextAnchor.MiddleCenter;
        private readonly string anchor_Options = Options.EnumHelper.Format<TextAnchor>() + Options.Description.Format("");
        public TextAlignment alignment_ = TextAlignment.Center;
        private readonly string alignment_Options = Options.EnumHelper.Format<TextAlignment>() + Options.Description.Format("");
        public float lineSpacing_;
        private readonly string lineSpacing_Options = Options.MinFloat.Format(0.0f) + Options.ExpStep.Format(0.1f) + Options.Description.Format("");
        public float tabSize_;
        private readonly string tabSize_Options = Options.MinFloat.Format(0.0f) + Options.ExpStep.Format(0.1f) + Options.Description.Format("");
        public bool richText_;
        private readonly string richText_Options = Options.Description.Format("");
        #endregion
        #region Component Fields
        private TextMesh mesh;
        #endregion
        #region MonoBehaviour Methods
        private void Awake()
        {
            mesh = GetComponent<TextMesh>();
        }
        #endregion

        public override void Visit(IVisitor visitor)
        {
            SerialUtils.PropertySerializeHelper<TextMesh> helper = new SerialUtils.PropertySerializeHelper<TextMesh>(visitor, mesh, null);
            helper.VisitEnumIfDifferent("Anchor", (TextMesh m) => m.anchor, (TextMesh m, TextAnchor v) => { m.anchor = v; anchor_ = v; }, anchor_Options);
            helper.VisitEnumIfDifferent("Alignment", (TextMesh m) => m.alignment, (TextMesh m, TextAlignment v) => { m.alignment = v; alignment_ = v; }, alignment_Options);
            helper.VisitIfDifferent("Line Spacing", (TextMesh m) => m.lineSpacing, (TextMesh m, float v) => { m.lineSpacing = v; lineSpacing_ = v; }, lineSpacing_Options);
            helper.VisitIfDifferent("Tab Size", (TextMesh m) => m.tabSize, (TextMesh m, float v) => { m.tabSize = v; tabSize_ = v; }, tabSize_Options);
            helper.VisitIfDifferent("Rich Text", (TextMesh m) => m.richText, (TextMesh m, bool v) => { m.richText = v; richText_ = v; }, richText_Options);
        }

        public override bool Validate(GameObject prefab, out string error)
        {
            error = string.Empty;
            if (prefab.HasInterface<TextMesh>())
            {
                return true;
            }
            else
            {
                error = $"Object(s) must have a TextMesh to add a {Name} component.";
                return false;
            }
        }
    }
}