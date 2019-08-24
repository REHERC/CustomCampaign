using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

#pragma warning disable IDE0069

namespace CustomCampaign.Editor.Controls
{
    public partial class PizzaCard : MaterialUserControl
    {
        public PizzaCard()
        {
            InitializeComponent();
        }

        private Image _picture = null;
        [Category("Pizza")]
        public Image Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
                ProfilePicture.Image = value;
                Invalidate();
            }
        }

        private bool _showPicture = true;
        [Category("Pizza")]
        public bool ShowPicture
        {
            get
            {
                return _showPicture;
            }
            set
            {
                _showPicture = value;
                ProfilePicture.Visible = value;
                Invalidate();
            }
        }

        private string _title = "Title";
        [Category("Pizza")]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                Invalidate();
            }
        }

        private string _description = "Description";
        [Category("Pizza")]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                Invalidate();
            }
        }


        Font TitleFont => new Font(SkinManager.GetFont(15, true), FontStyle.Bold);
        Font DescriptionFont => new Font(SkinManager.GetFont(12, false), FontStyle.Regular);

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            var border = 8;
            var leftmargin = ShowPicture ? 56 : border / 2;

            Rectangle TitleRect = new Rectangle
            (
                border + leftmargin,
                border,
                Bounds.Width - 2 * border - leftmargin,
                24
            );

            Rectangle DescriptionRect = new Rectangle
            (
                TitleRect.Left + 2,
                border + TitleRect.Height,
                TitleRect.Width,
                Height - TitleRect.Height
            );

            g.DrawString(Title.ToUpper(), TitleFont, GetTextBrugh(), TitleRect);
            g.DrawString(Description, DescriptionFont, GetTextBrugh(), DescriptionRect);

            base.OnPaint(e);
        }

        private void ProfilePicture_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ProfilePicture.ClientSize.Width, ProfilePicture.ClientSize.Height);
            ProfilePicture.Region = new Region(path);
        }

        private Brush GetTextBrugh()
        {
            bool darkmode = SkinManager.Theme == MaterialSkinManager.Themes.DARK;
            return new SolidBrush(darkmode ? Color.White : SkinManager.ColorScheme.PrimaryColor);
        }
    }
}
