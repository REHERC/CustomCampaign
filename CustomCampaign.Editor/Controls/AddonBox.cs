using CustomCampaign.Models;
using MaterialSkin;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Controls
{
    public class AddonBox : Cyotek.DragListBox
    {
        public override Color BackColor => SkinManager.GetApplicationBackgroundColor();
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        public override int ItemHeight => 48;
        public override DrawMode DrawMode => DrawMode.OwnerDrawVariable;

        protected override Color LineColor => SkinManager.ColorScheme.AccentColor;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //base.OnDrawItem(e);

            if (Items.Count <= 0) return;

            var g = e.Graphics;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.FillRectangle(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), e.Bounds);
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            g.DrawImageUnscaled(RenderItem(selected, e), e.Bounds.Location);
        }

        private Image RenderItem(bool selected, DrawItemEventArgs e)
        {
            Bitmap flag = new Bitmap(Width, ItemHeight);
            Graphics g = Graphics.FromImage(flag);

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.Clear(Color.Black);

            if (selected)
                g.Clear(SkinManager.GetCmsSelectedItemColor());
            else
                g.Clear(SkinManager.GetApplicationBackgroundColor());

            if (!(Items[e.Index] is Addon))
            {
                g.DrawString("Error: The type of the item data is invalid", e.Font, Brushes.Black, new PointF(0, 0));
                return flag;
            }

            Addon data = (Addon)Items[e.Index];

            int margin = 4;

            string title = $"{data.name.ToUpper()}";

            Font title_font = SkinManager.GetFont(14);
            Size title_size = TextRenderer.MeasureText(title, title_font);

            g.DrawString(title, title_font, SkinManager.GetSecondaryTextBrush(), new PointF(margin, 0.5f * margin));
            g.DrawString($"({data.module})", SkinManager.GetFont(12), SkinManager.GetSecondaryTextBrush(), new PointF(margin * 2.25f + title_size.Width, 1.1f * margin));
            g.DrawString($"{data.dependencies.Count} dependencies", SkinManager.GetFont(12), SkinManager.GetSecondaryTextBrush(), new PointF(0.75f * margin + 4, 6.0f * margin));

            return flag;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                SelectedIndex = Items.Count > 0 ? IndexFromPoint(e.Location) : -1;
            base.OnMouseDown(e);
        }
    }
}
