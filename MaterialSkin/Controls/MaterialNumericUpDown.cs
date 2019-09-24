using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialNumericUpDown : NumericUpDown, IMaterialControl
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
            set => value = SkinManager.GetApplicationBackgroundColor();
        }

        public new BorderStyle BorderStyle
        {
            get
            {
                base.BorderStyle = BorderStyle.None;
                return BorderStyle.None;
            }
            set
            {
                base.BorderStyle = BorderStyle.None;
            }
        }

        public override Font Font => SkinManager.GetFont(11);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            Brush b = Brushes.Red;


            Rectangle r = new Rectangle(0, 0, 24, 24);

            g.FillRectangle(b, r);
        }
    }
}
