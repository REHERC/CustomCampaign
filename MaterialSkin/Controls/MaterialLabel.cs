using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

#pragma warning disable IDE0059

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private int _fontSize = 11;
        public int FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
                this.Font = SkinManager.GetFont(_fontSize);
            }
        }

        public new Color BackColor
        {
            get => SkinManager.GetApplicationBackgroundColor();
            set
            {
                value = SkinManager.GetApplicationBackgroundColor();
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            BackColor = SkinManager.GetApplicationBackgroundColor();
            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = Font = SkinManager.GetFont(FontSize);

            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.Clear(BackColor);
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(Point.Empty, Size));
        }
    }
}
