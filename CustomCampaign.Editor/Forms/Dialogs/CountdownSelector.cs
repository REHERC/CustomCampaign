using MaterialSkin.Controls;
using System;
using Result = System.Windows.Forms.DialogResult;

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
    }
}
