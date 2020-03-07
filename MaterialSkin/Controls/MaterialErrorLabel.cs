using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE0052

namespace MaterialSkin.Controls
{
    public class MaterialErrorLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private new Color ForeColor
        {
            get => ColorExtension.ToColor((int)Primary.Red700);
            set { base.ForeColor = ColorExtension.ToColor((int)Primary.Red700); }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = ColorExtension.ToColor((int)Primary.Red700);
            Font = SkinManager.ROBOTO_REGULAR_11;

            BackColorChanged += (sender, args) => ForeColor = ColorExtension.ToColor((int)Primary.Red700);
        }
    }
}
