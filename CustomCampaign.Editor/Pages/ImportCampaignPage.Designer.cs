namespace CustomCampaign.Editor.Pages
{
    partial class ImportCampaignPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BannerBackground = new System.Windows.Forms.Panel();
            this.BannerText = new System.Windows.Forms.Label();
            this.TemplateCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.FormPanel = new MaterialSkin.Controls.MaterialPanel();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ImportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BannerBackground.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BannerBackground
            // 
            this.BannerBackground.Controls.Add(this.BannerText);
            this.BannerBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerBackground.Location = new System.Drawing.Point(0, 0);
            this.BannerBackground.Margin = new System.Windows.Forms.Padding(0);
            this.BannerBackground.Name = "BannerBackground";
            this.BannerBackground.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BannerBackground.Size = new System.Drawing.Size(784, 32);
            this.BannerBackground.TabIndex = 7;
            // 
            // BannerText
            // 
            this.BannerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BannerText.Location = new System.Drawing.Point(8, 0);
            this.BannerText.Name = "BannerText";
            this.BannerText.Size = new System.Drawing.Size(776, 32);
            this.BannerText.TabIndex = 0;
            this.BannerText.Text = "NOTIFICATION TEXT";
            this.BannerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TemplateCheck
            // 
            this.TemplateCheck.Depth = 0;
            this.TemplateCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplateCheck.Font = new System.Drawing.Font("Roboto", 11F);
            this.TemplateCheck.Location = new System.Drawing.Point(12, 242);
            this.TemplateCheck.Margin = new System.Windows.Forms.Padding(0, 12, 0, 6);
            this.TemplateCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TemplateCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.TemplateCheck.Name = "TemplateCheck";
            this.TemplateCheck.Ripple = true;
            this.TemplateCheck.Size = new System.Drawing.Size(599, 36);
            this.TemplateCheck.TabIndex = 12;
            this.TemplateCheck.Text = "Import as template (generate new unique identifier)";
            this.TemplateCheck.UseVisualStyleBackColor = true;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.Controls.Add(this.Divider, 0, 1);
            this.MainLayout.Controls.Add(this.CancelBtn, 2, 2);
            this.MainLayout.Controls.Add(this.FormPanel, 0, 0);
            this.MainLayout.Controls.Add(this.ImportBtn, 1, 2);
            this.MainLayout.Controls.Add(this.TemplateCheck, 0, 2);
            this.MainLayout.Depth = 0;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 32);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Padding = new System.Windows.Forms.Padding(12);
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(784, 296);
            this.MainLayout.TabIndex = 11;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainLayout.SetColumnSpan(this.Divider, 3);
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(12, 229);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.MaximumSize = new System.Drawing.Size(0, 1);
            this.Divider.MinimumSize = new System.Drawing.Size(0, 1);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(760, 1);
            this.Divider.TabIndex = 1;
            // 
            // FormPanel
            // 
            this.MainLayout.SetColumnSpan(this.FormPanel, 3);
            this.FormPanel.Controls.Add(this.DisplayText);
            this.FormPanel.Depth = 0;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormPanel.Location = new System.Drawing.Point(12, 12);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.FormPanel.Size = new System.Drawing.Size(760, 217);
            this.FormPanel.TabIndex = 0;
            this.FormPanel.BackColorChanged += new System.EventHandler(this.FormPanel_BackColorChanged);
            // 
            // DisplayText
            // 
            this.DisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayText.HideSelection = false;
            this.DisplayText.Location = new System.Drawing.Point(0, 4);
            this.DisplayText.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ReadOnly = true;
            this.DisplayText.Size = new System.Drawing.Size(760, 209);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "DISPLAYED INFO";
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(695, 242);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.Depth = 0;
            this.ImportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBtn.Header = false;
            this.ImportBtn.Icon = null;
            this.ImportBtn.Location = new System.Drawing.Point(615, 242);
            this.ImportBtn.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.ImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Primary = true;
            this.ImportBtn.Size = new System.Drawing.Size(72, 36);
            this.ImportBtn.TabIndex = 9;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // ImportCampaignPage
            // 
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.BannerBackground);
            this.Name = "ImportCampaignPage";
            this.PageName = "pages:importcampaign";
            this.PageTitle = "Import a campaign";
            this.Size = new System.Drawing.Size(784, 328);
            this.BannerBackground.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BannerBackground;
        private MaterialSkin.Controls.MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialPanel FormPanel;
        private MaterialSkin.Controls.MaterialDivider Divider;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ImportBtn;
        private System.Windows.Forms.Label BannerText;
        private System.Windows.Forms.TextBox DisplayText;
        private MaterialSkin.Controls.MaterialCheckBox TemplateCheck;
    }
}
