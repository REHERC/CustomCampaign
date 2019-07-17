using MaterialSkin.Controls;

namespace CustomCampaign.Editor.Pages
{
    partial class NewCampaignWizard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.FormPanel = new MaterialSkin.Controls.MaterialPanel();
            this.BrowseBox = new MaterialSkin.Controls.MaterialPanel();
            this.BrowseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.CampaignDirectory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.CreateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainLayout.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.BrowseBox.SuspendLayout();
            this.SuspendLayout();
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
            this.MainLayout.Controls.Add(this.FormPanel, 1, 1);
            this.MainLayout.Controls.Add(this.Divider, 0, 4);
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
            this.MainLayout.Size = new System.Drawing.Size(761, 261);
            this.MainLayout.TabIndex = 1;
            // 
            // FormPanel
            // 
            this.MainLayout.SetColumnSpan(this.FormPanel, 3);
            this.FormPanel.Controls.Add(this.BrowseBox);
            this.FormPanel.Controls.Add(this.CampaignDirectory);
            this.FormPanel.Controls.Add(this.CampaignDescription);
            this.FormPanel.Controls.Add(this.CampaignName);
            this.FormPanel.Depth = 0;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormPanel.Location = new System.Drawing.Point(152, 52);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainLayout.SetRowSpan(this.FormPanel, 3);
            this.FormPanel.Size = new System.Drawing.Size(456, 156);
            this.FormPanel.TabIndex = 0;
            // 
            // BrowseBox
            // 
            this.BrowseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBox.Controls.Add(this.BrowseBtn);
            this.BrowseBox.Depth = 0;
            this.BrowseBox.Location = new System.Drawing.Point(354, 92);
            this.BrowseBox.Margin = new System.Windows.Forms.Padding(6);
            this.BrowseBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseBox.Name = "BrowseBox";
            this.BrowseBox.Size = new System.Drawing.Size(80, 26);
            this.BrowseBox.TabIndex = 4;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.AutoSize = true;
            this.BrowseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseBtn.Depth = 0;
            this.BrowseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBtn.Icon = null;
            this.BrowseBtn.Location = new System.Drawing.Point(0, 0);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Primary = false;
            this.BrowseBtn.Size = new System.Drawing.Size(80, 26);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "BROWSE";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // CampaignDirectory
            // 
            this.CampaignDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CampaignDirectory.Depth = 0;
            this.CampaignDirectory.Enabled = false;
            this.CampaignDirectory.Hint = "Directory  (required)";
            this.CampaignDirectory.Location = new System.Drawing.Point(22, 92);
            this.CampaignDirectory.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignDirectory.MaxLength = 32767;
            this.CampaignDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignDirectory.Name = "CampaignDirectory";
            this.CampaignDirectory.PasswordChar = '\0';
            this.CampaignDirectory.SelectedText = "";
            this.CampaignDirectory.SelectionLength = 0;
            this.CampaignDirectory.SelectionStart = 0;
            this.CampaignDirectory.Size = new System.Drawing.Size(322, 23);
            this.CampaignDirectory.TabIndex = 2;
            this.CampaignDirectory.TabStop = false;
            this.CampaignDirectory.Text = "Directory (required)";
            this.CampaignDirectory.UseSystemPasswordChar = false;
            // 
            // CampaignDescription
            // 
            this.CampaignDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CampaignDescription.Depth = 0;
            this.CampaignDescription.Hint = "Campaign description";
            this.CampaignDescription.Location = new System.Drawing.Point(22, 57);
            this.CampaignDescription.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignDescription.MaxLength = 32767;
            this.CampaignDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignDescription.Name = "CampaignDescription";
            this.CampaignDescription.PasswordChar = '\0';
            this.CampaignDescription.SelectedText = "";
            this.CampaignDescription.SelectionLength = 0;
            this.CampaignDescription.SelectionStart = 0;
            this.CampaignDescription.Size = new System.Drawing.Size(412, 23);
            this.CampaignDescription.TabIndex = 1;
            this.CampaignDescription.TabStop = false;
            this.CampaignDescription.UseSystemPasswordChar = false;
            // 
            // CampaignName
            // 
            this.CampaignName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CampaignName.Depth = 0;
            this.CampaignName.Hint = "Campaign name (required)";
            this.CampaignName.Location = new System.Drawing.Point(22, 22);
            this.CampaignName.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignName.MaxLength = 32767;
            this.CampaignName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignName.Name = "CampaignName";
            this.CampaignName.PasswordChar = '\0';
            this.CampaignName.SelectedText = "";
            this.CampaignName.SelectionLength = 0;
            this.CampaignName.SelectionStart = 0;
            this.CampaignName.Size = new System.Drawing.Size(412, 23);
            this.CampaignName.TabIndex = 0;
            this.CampaignName.TabStop = false;
            this.CampaignName.UseSystemPasswordChar = false;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainLayout.SetColumnSpan(this.Divider, 5);
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Divider.Location = new System.Drawing.Point(3, 257);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(755, 1);
            this.Divider.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(699, 278);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateBtn.Depth = 0;
            this.CreateBtn.Header = false;
            this.CreateBtn.Icon = null;
            this.CreateBtn.Location = new System.Drawing.Point(621, 278);
            this.CreateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Primary = true;
            this.CreateBtn.Size = new System.Drawing.Size(71, 36);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NewCampaignWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Name = "NewCampaignWizard";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.PageName = "pages:newcampaignwizard";
            this.PageTitle = "New campaign";
            this.Size = new System.Drawing.Size(784, 328);
            this.MainLayout.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.BrowseBox.ResumeLayout(false);
            this.BrowseBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CreateBtn;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignName;
        private MaterialTableLayoutPanel MainLayout;
        private MaterialPanel FormPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignDescription;
        private MaterialPanel BrowseBox;
        private MaterialSkin.Controls.MaterialFlatButton BrowseBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignDirectory;
        private MaterialDivider Divider;
    }
}
