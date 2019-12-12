using CustomCampaign.Editor.Controls;
using CustomCampaign.Editor.Resx;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class ContributorsForm : MaterialForm
    {
        public ContributorsForm()
        {
            InitializeComponent();

            AddMember("Backgrounds'", "", ProfilePictures.Backgrounds);
            AddMember("Brionac", "Fast playtesting boi\nNoah Alt #25", ProfilePictures.Brionac);
            AddMember("Californ1a", "", ProfilePictures.California);
            AddMember("Ciastex", "The wise anarchist\nVdd", ProfilePictures.Ciastex);
            AddMember("Fzeroman", "", ProfilePictures.Fzeroman);
            AddMember("Ghostly", "Pizza chef", ProfilePictures.Ghostly);
            AddMember("Ibegyourpardon", "Äctüàl dôçtôs\nIgregyourpardon", ProfilePictures.Ibegyourpardon);
            AddMember("Jay2a", "Probably exists\nJay2a got wrecked", ProfilePictures.Jay2a);
            AddMember("Knightbane (Noah)", "Noah the chonker", ProfilePictures.Knightbane);
            AddMember("Krispy", "", ProfilePictures.Krispy);
            AddMember("Mr Mii", "MrWii", ProfilePictures.Mrmii);
            AddMember("Omaneye", "", ProfilePictures.Omaneye);
            AddMember("Pinapl", "The yellow one\nKing Pin Pinapl\nMekkler", ProfilePictures.Pinapl);
            AddMember("Pines of chaos", "Long burger CEO\nπnes", ProfilePictures.Pinesofchaos);
            AddMember("Plasmawario", "Distributor of pant", ProfilePictures.Plasmawario);
            AddMember("Reherc", "Shitpost with code\nDecorative plant", ProfilePictures.Reherc);
            AddMember("Semtex4ya", "Lord of brightness", ProfilePictures.Semtex4ya);
            AddMember("Sperzieboon", "A festive biotec CEO", ProfilePictures.Sperzieboon);
            AddMember("Spzi", "Big spin", ProfilePictures.Spzi);
            AddMember("", "", ProfilePictures.Crab);
        }

        private void AddMember(string title, string description, Image picture, int tile = 1)
        {
            const int padding = 4;

            FlowLayout.Controls.Add(new InfoCard()
            {
                Margin = new Padding(padding),
                Width = 256 * tile + 2 * padding * (tile - 1),
                Height = 96,
                Title = title,
                Description = description,
                Picture = picture,
                TabStop = false
            });
        }
    }
}
