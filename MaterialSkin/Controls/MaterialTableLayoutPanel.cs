﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE0059

namespace MaterialSkin.Controls
{
    public class MaterialTableLayoutPanel : TableLayoutPanel, IMaterialControl
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

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(SkinManager.GetApplicationBackgroundColor());
        }
    }
}
