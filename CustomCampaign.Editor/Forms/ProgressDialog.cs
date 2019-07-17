namespace CustomCampaign.Editor.Forms
{
    public partial class ProgressDialog : MaterialSkin.Controls.MaterialForm
    {
        private string _title = "Action";
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                HeaderLabel.Text = value;
            }
        }

        public ProgressDialog()
        {
            InitializeComponent();
        }
    }
}
