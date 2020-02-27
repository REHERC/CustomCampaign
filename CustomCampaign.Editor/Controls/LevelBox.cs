using CustomCampaign.Models;
using MaterialSkin;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Controls
{
    public class LevelBox : Cyotek.DragListBox
    {
        public override Color BackColor => SkinManager.GetApplicationBackgroundColor();

        [Browsable(false)]

        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        public override int ItemHeight => 96;
        public override DrawMode DrawMode => DrawMode.OwnerDrawVariable;

        protected override Color LineColor => SkinManager.ColorScheme.AccentColor;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //base.OnDrawItem(e);

            if (Items.Count <= 0)
            {
                return;
            }

            var g = e.Graphics;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.FillRectangle(new SolidBrush(SkinManager.GetApplicationBackgroundColor()),e.Bounds);
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            g.DrawImageUnscaled(RenderItem(selected, e), e.Bounds.Location);
        }

        private Image RenderItem(bool selected, DrawItemEventArgs e)
        {
            const float thumb_ratio = 640.0f / 360.0f;

            Bitmap flag = new Bitmap(Width, ItemHeight);
            Graphics g = Graphics.FromImage(flag);

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.Clear(Color.Black);

            if (selected)
            {
                g.Clear(SkinManager.GetCmsSelectedItemColor());
            }
            else
            {
                g.Clear(SkinManager.GetApplicationBackgroundColor());
            }

            if (!(Items[e.Index] is Level))
            {
                g.DrawString("Error: The type of the item data is invalid", e.Font, Brushes.Black, new PointF(0, 0));
                return flag;
            }

            Level data = (Level)Items[e.Index];

            int margin = 8,
            thumb_height = ItemHeight - (2 * margin),
            thumb_width = (int)Math.Round(thumb_ratio * thumb_height);

            g.DrawString(data.levelname.ToUpper(), SkinManager.GetFont(20), SkinManager.GetSecondaryTextBrush(), new PointF(thumb_width + (2 * margin), 1.5f * margin));
            g.DrawString(data.levelname_sub.ToUpper(), SkinManager.GetFont(14), SkinManager.GetSecondaryTextBrush(), new PointF(4 + thumb_width + (2 * margin), 5.0f * margin));

            if (data.countdown > 0)
            {
                g.DrawString($"Timer: {TimeSpan.FromSeconds(data.countdown).ToString(@"hh\:mm\:ss\.fff")}".ToUpper(), SkinManager.GetFont(14), SkinManager.GetSecondaryTextBrush(), new PointF(4 + thumb_width + (2 * margin), 7.75f * margin));
            }

            g.DrawImage(data.GetThumbnail(Editor.current_path) ?? Resx.Resources.NoPreview, new Rectangle(margin, margin, thumb_width, thumb_height));

            return flag;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                SelectedIndex = Items.Count > 0 ? IndexFromPoint(e.Location) : -1;
            }
            base.OnMouseDown(e);
        }
    }
}
