using CustomCampaign.Editor.Controls;
using CustomCampaign.Editor.Resx;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class PizzaForm : MaterialForm
    {
        public PizzaForm()
        {
            InitializeComponent();

            AddMember("Brionac", "Fast playtesting boi", ProfilePictures.Brionac);
            AddMember("Californ1a", "", ProfilePictures.California);
            AddMember("Ciastex", "The wise anarchist", ProfilePictures.Ciastex);
            AddMember("Ghostly", "Pizza chef", ProfilePictures.Ghostly);
            AddMember("I beg your pardon", "Äctüàl dôçtôs", ProfilePictures.Ibegyourpardon, 2);
            AddMember("Jay2a", "Probably exists", ProfilePictures.Jay2a);
            AddMember("Mr Mii", "", ProfilePictures.Mrmii);
            AddMember("Pinapl", "The yellow one", ProfilePictures.Pinapl);
            AddMember("Pines of chaos", "Long burger CEO", ProfilePictures.Pinesofchaos);
            AddMember("Reherc", "Shitpost with code", ProfilePictures.Reherc);
            AddMember("Sperzieboon", "A festive biotec CEO", ProfilePictures.Sperzieboon);
        }

        private void AddMember(string title, string description, Image picture, int tile = 1)
        {
            const int padding = 4;

            FlowLayout.Controls.Add(new PizzaCard() {
                Margin = new Padding(padding),
                Width = 256 * tile + 2 * padding * (tile - 1),

                Title = title,
                Description = description,
                Picture = picture
            });
        }
    }
}
