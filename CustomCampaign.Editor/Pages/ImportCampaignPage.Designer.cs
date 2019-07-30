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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.FormPanel = new MaterialSkin.Controls.MaterialPanel();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ImportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TemplateCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.BannerBackground.SuspendLayout();
            this.MainPanel.SuspendLayout();
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TemplateCheck);
            this.MainPanel.Controls.Add(this.MainLayout);
            this.MainPanel.Controls.Add(this.CancelBtn);
            this.MainPanel.Controls.Add(this.ImportBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainPanel.Size = new System.Drawing.Size(784, 296);
            this.MainPanel.TabIndex = 8;
            // 
            // MainLayout
            // 
            this.MainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.ColumnCount = 5;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.Controls.Add(this.Divider, 0, 4);
            this.MainLayout.Controls.Add(this.FormPanel, 0, 0);
            this.MainLayout.Depth = 0;
            this.MainLayout.Location = new System.Drawing.Point(11, 11);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(761, 226);
            this.MainLayout.TabIndex = 11;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainLayout.SetColumnSpan(this.Divider, 5);
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Divider.Location = new System.Drawing.Point(3, 222);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(755, 1);
            this.Divider.TabIndex = 1;
            // 
            // FormPanel
            // 
            this.MainLayout.SetColumnSpan(this.FormPanel, 5);
            this.FormPanel.Controls.Add(this.DisplayText);
            this.FormPanel.Depth = 0;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Padding = new System.Windows.Forms.Padding(4);
            this.MainLayout.SetRowSpan(this.FormPanel, 4);
            this.FormPanel.Size = new System.Drawing.Size(761, 180);
            this.FormPanel.TabIndex = 0;
            this.FormPanel.BackColorChanged += new System.EventHandler(this.FormPanel_BackColorChanged);
            // 
            // DisplayText
            // 
            this.DisplayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayText.HideSelection = false;
            this.DisplayText.Location = new System.Drawing.Point(4, 4);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ReadOnly = true;
            this.DisplayText.Size = new System.Drawing.Size(753, 172);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "DISPLAYED INFO";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(699, 246);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.ImportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportBtn.Depth = 0;
            this.ImportBtn.Header = false;
            this.ImportBtn.Icon = null;
            this.ImportBtn.Location = new System.Drawing.Point(621, 246);
            this.ImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Primary = true;
            this.ImportBtn.Size = new System.Drawing.Size(72, 36);
            this.ImportBtn.TabIndex = 9;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            // 
            // TemplateCheck
            // 
            this.TemplateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateCheck.Depth = 0;
            this.TemplateCheck.Font = new System.Drawing.Font("Roboto", 11F);
            this.TemplateCheck.Location = new System.Drawing.Point(11, 249);
            this.TemplateCheck.Margin = new System.Windows.Forms.Padding(0);
            this.TemplateCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TemplateCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.TemplateCheck.Name = "TemplateCheck";
            this.TemplateCheck.Ripple = true;
            this.TemplateCheck.Size = new System.Drawing.Size(607, 30);
            this.TemplateCheck.TabIndex = 12;
            this.TemplateCheck.Text = "Import as template";
            this.TemplateCheck.UseVisualStyleBackColor = true;
            // 
            // ImportCampaignPage
            // 
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BannerBackground);
            this.Name = "ImportCampaignPage";
            this.PageName = "pages:importcampaign";
            this.PageTitle = "Import a campaign";
            this.Size = new System.Drawing.Size(784, 328);
            this.BannerBackground.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MainLayout.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BannerBackground;
        private System.Windows.Forms.Panel MainPanel;
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
