using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE0059

namespace MaterialSkin.Controls
{
    public class MaterialListBox : ListBox, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public override int ItemHeight => Font.Height + 2 * Spacing;

        public MaterialListBox()
        {
            base.BorderStyle = BorderStyle;
            base.Font = Font;
            base.ItemHeight = ItemHeight;
        }

        public override Color BackColor
        {
            get => SkinManager.GetApplicationBackgroundColor();
            set => value = SkinManager.GetApplicationBackgroundColor();
        }

        public new BorderStyle BorderStyle
        {
            get => BorderStyle.None;
            set => value = BorderStyle.None;
        }

        public override Font Font
        {
            get => SkinManager.GetFont(12);
        }

        private const int Spacing = 8;

        public override DrawMode DrawMode => DrawMode.OwnerDrawVariable;

        protected override void OnMeasureItem(MeasureItemEventArgs e) => e.ItemHeight = ItemHeight;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= Items.Count) return;

            string text = Items[e.Index].ToString();

            Rectangle bounds = e.Bounds;
            Rectangle text_rect = new Rectangle(bounds.X + Spacing, bounds.Y + Spacing, bounds.Width - 2 * Spacing, bounds.Height - 2 * Spacing);

            e.Graphics.FillRectangle(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), bounds);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected && SelectionMode != SelectionMode.None)
                e.Graphics.FillRectangle(new SolidBrush(SkinManager.GetCmsSelectedItemColor()), bounds);

            e.Graphics.DrawString(text, Font, SkinManager.GetSecondaryTextBrush(), text_rect, StringFormat.GenericDefault);

            e.Graphics.Dispose();
        }
    }
}
