using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE0059

namespace MaterialSkin.Controls
{
    public class MaterialUserControl : UserControl, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public override Color BackColor
        {
            get => SkinManager.GetApplicationBackgroundColor();
            set
            {
                value = SkinManager.GetApplicationBackgroundColor();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
        }
    }
}
