using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;

#pragma warning disable IDE0051, CA1031
namespace MaterialSkin.Controls
{
    public class MaterialDropDown : ComboBox, IMaterialControl
    {
        //Properties for managing the material design properties
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        private string _hint;

        public string Hint
        {
            get
            {
                return _hint;
            }
            set
            {
                _hint = value;
                Invalidate();
            }
        }

        private bool dropdown = false;

        [Browsable(false)]
        public MouseState MouseState { get; set; } = MouseState.OUT;

        private readonly AnimationManager _animationManager;

        public new Font Font
        {
            get
            {
                return SkinManager.ROBOTO_REGULAR_11;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            MouseState = MouseState.HOVER;
            _animationManager.StartNewAnimation(AnimationDirection.In, new Point(0, 0));
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            MouseState = MouseState.OUT;
            _animationManager.SetProgress(0);
            //Invalidate();
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            dropdown = true;
            //Parent.Invalidate(Bounds);
        }

        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);
            dropdown = false;
            //Parent.Invalidate(Bounds);
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        public MaterialDropDown()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            DrawMode = DrawMode.OwnerDrawVariable;
            DropDownStyle = ComboBoxStyle.DropDownList;

            _animationManager = new AnimationManager
            {
                Increment = 0.06,
                AnimationType = AnimationType.EaseInOut,
                InterruptAnimation = false
            };
            _animationManager.OnAnimationProgress += _ => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;

            g.Clear(Parent.BackColor);

            var lineY = Height - 2;
            g.FillRectangle(SkinManager.GetDividersBrush(), 0, lineY, Width, 1);

            try
            {
                if (MouseState == MouseState.HOVER)
                {
                    //Animate
                    int animationWidth = (int)(Width * _animationManager.GetProgress());
                    int halfAnimationWidth = animationWidth / 2;
                    int animationStart = Width / 2;

                    //Animated focus transition
                    g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
                }
            }
            catch
            { }

            //var text = (!dropdown || string.IsNullOrEmpty(Hint)) && SelectedIndex >= 0 && !DesignMode ? Items[SelectedIndex].ToString() : Hint;
            var text = SelectedIndex >= 0 && !DesignMode ? Items[SelectedIndex].ToString() : Hint;

            Rectangle textRect = new Rectangle(
                ClientRectangle.Left - 2,
                ClientRectangle.Top,
                ClientRectangle.Width - 24,
                ClientRectangle.Height
            );

            g.DrawString(
                    text,
                    SkinManager.GetFont(11),
                    GetTextBrush(),
                    textRect,
                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

            var vertical = Height / 2;
            var horizontal = Width - 8;
            Point[] points2 = { new Point(horizontal - 4, vertical - 4), new Point(horizontal + 4, vertical - 4), new Point(horizontal, vertical + 4) };
            g.FillPolygon(dropdown ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetSecondaryTextBrush(), points2);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        private Brush GetTextBrush()
        {
            Color color = SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? Color.Black : Color.White;
            return new SolidBrush(color);
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            e.ItemHeight = 28;
            e.ItemWidth = Width;
            DropDownHeight = (Math.Min(Items.Count, 6) * e.ItemHeight) + 2;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            base.OnDrawItem(e);
            var g = e.Graphics;

            var bounds = new Rectangle(e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);

            const int spacing = 24;
            var rect = new Rectangle(spacing, bounds.Top, bounds.Width - spacing, bounds.Height);

            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                g.FillRectangle(SkinManager.GetCmsSelectedItemBrush(), bounds);
            else
                g.FillRectangle(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), bounds);

            g.DrawString(
                Items[e.Index].ToString(),
                SkinManager.ROBOTO_REGULAR_11,
                SkinManager.GetPrimaryTextBrush(),
                rect,
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }
            );
        }
    }
}