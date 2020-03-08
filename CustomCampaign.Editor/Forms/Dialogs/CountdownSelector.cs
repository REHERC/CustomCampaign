using CustomCampaign.Editor.Pages;
using MaterialSkin.Controls;
using System;
using Result = System.Windows.Forms.DialogResult;
using Buttons = System.Windows.Forms.MessageBoxButtons;
using CustomCampaign.Data;

namespace CustomCampaign.Editor.Forms.Dialogs
{
    public partial class CountdownSelector : MaterialForm
    {
        public void SetValue(double value)
        {
            SetValue(TimeSpan.FromSeconds(value));
        }

        public void SetValue(TimeSpan value)
        {
            Miliseconds.Value = value.Milliseconds;
            Seconds.Value = value.Seconds;
            Minutes.Value = value.Minutes;
            Hours.Value = value.Hours + (value.Days * 24);
        }

        public TimeSpan GetSpan()
        {
            decimal result = 0;

            result += Miliseconds.Value / 1000;
            result += Seconds.Value;
            result += Minutes.Value * 60;
            result += Hours.Value * 3600;

            return TimeSpan.FromSeconds((double)result);
        }

        public double GetValue()
        {
            return GetSpan().TotalSeconds;
        }

        public CountdownSelector()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close(Result.Cancel);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Close(Result.OK);
        }

        private void CountdownSelector_Load(object sender, EventArgs e)
        {
            EditorMainPage page = Globals.MainWindow.GetPage<EditorMainPage>("pages:editormain");
            int index = page.CampaignGamemode.SelectedIndex;
            bool adventure_mode = GameModeId.GetIdFromIndex(index) == GameModeId.ConversionTable["Adventure"];

            if (!adventure_mode)
            {
                if (MessageDialog.Show("The campaign must use the adventure game mode to use the countdown settings!\n\nDo you want to set the campaign mode to adventure?", "Error", Buttons.YesNo) == Result.Yes)
                {
                    page.CampaignGamemode.SelectedIndex = GameModeId.GetIndexFromId(GameModeId.ConversionTable["Adventure"]);
                }
                else
                {
                    Close(Result.Cancel);
                }
            }
        }
    }
}
