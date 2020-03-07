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
            this.FormPanel_ = new MaterialSkin.Controls.MaterialPanel();
            this.BrowseBox = new MaterialSkin.Controls.MaterialPanel();
            this.BrowseBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.CampaignDirectory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CampaignName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.CreateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonsPanel = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.FormLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.MainLayout.SuspendLayout();
            this.BrowseBox.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.FormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.Controls.Add(this.ButtonsPanel, 0, 4);
            this.MainLayout.Controls.Add(this.Divider, 0, 3);
            this.MainLayout.Controls.Add(this.FormPanel_, 2, 1);
            this.MainLayout.Controls.Add(this.FormLayout, 1, 1);
            this.MainLayout.Depth = 0;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(12, 12);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(760, 304);
            this.MainLayout.TabIndex = 1;
            // 
            // FormPanel_
            // 
            this.FormPanel_.Depth = 0;
            this.FormPanel_.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormPanel_.Location = new System.Drawing.Point(608, 49);
            this.FormPanel_.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel_.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel_.Name = "FormPanel_";
            this.FormPanel_.Padding = new System.Windows.Forms.Padding(16);
            this.FormPanel_.Size = new System.Drawing.Size(152, 148);
            this.FormPanel_.TabIndex = 0;
            // 
            // BrowseBox
            // 
            this.BrowseBox.AutoSize = true;
            this.BrowseBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseBox.Controls.Add(this.BrowseBtn);
            this.BrowseBox.Depth = 0;
            this.BrowseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBox.Location = new System.Drawing.Point(352, 96);
            this.BrowseBox.Margin = new System.Windows.Forms.Padding(0, 4, 6, 6);
            this.BrowseBox.MaximumSize = new System.Drawing.Size(0, 23);
            this.BrowseBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseBox.Name = "BrowseBox";
            this.BrowseBox.Size = new System.Drawing.Size(76, 23);
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
            this.BrowseBtn.Size = new System.Drawing.Size(76, 23);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "BROWSE";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // CampaignDirectory
            // 
            this.CampaignDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CampaignDirectory.Depth = 0;
            this.CampaignDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDirectory.Enabled = false;
            this.CampaignDirectory.Hint = "Directory  (required)";
            this.CampaignDirectory.Location = new System.Drawing.Point(28, 98);
            this.CampaignDirectory.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignDirectory.MaxLength = 32767;
            this.CampaignDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignDirectory.Name = "CampaignDirectory";
            this.CampaignDirectory.PasswordChar = '\0';
            this.CampaignDirectory.SelectedText = "";
            this.CampaignDirectory.SelectionLength = 0;
            this.CampaignDirectory.SelectionStart = 0;
            this.CampaignDirectory.Size = new System.Drawing.Size(318, 23);
            this.CampaignDirectory.TabIndex = 2;
            this.CampaignDirectory.TabStop = false;
            this.CampaignDirectory.Text = "Directory (required)";
            this.CampaignDirectory.UseSystemPasswordChar = false;
            // 
            // CampaignDescription
            // 
            this.FormLayout.SetColumnSpan(this.CampaignDescription, 2);
            this.CampaignDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CampaignDescription.Depth = 0;
            this.CampaignDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignDescription.Hint = "Campaign description";
            this.CampaignDescription.Location = new System.Drawing.Point(28, 63);
            this.CampaignDescription.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignDescription.MaxLength = 32767;
            this.CampaignDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignDescription.Name = "CampaignDescription";
            this.CampaignDescription.PasswordChar = '\0';
            this.CampaignDescription.SelectedText = "";
            this.CampaignDescription.SelectionLength = 0;
            this.CampaignDescription.SelectionStart = 0;
            this.CampaignDescription.Size = new System.Drawing.Size(400, 23);
            this.CampaignDescription.TabIndex = 1;
            this.CampaignDescription.TabStop = false;
            this.CampaignDescription.UseSystemPasswordChar = false;
            // 
            // CampaignName
            // 
            this.FormLayout.SetColumnSpan(this.CampaignName, 2);
            this.CampaignName.Depth = 0;
            this.CampaignName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CampaignName.Hint = "Campaign name (required)";
            this.CampaignName.Location = new System.Drawing.Point(28, 28);
            this.CampaignName.Margin = new System.Windows.Forms.Padding(6);
            this.CampaignName.MaxLength = 32767;
            this.CampaignName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CampaignName.Name = "CampaignName";
            this.CampaignName.PasswordChar = '\0';
            this.CampaignName.SelectedText = "";
            this.CampaignName.SelectionLength = 0;
            this.CampaignName.SelectionStart = 0;
            this.CampaignName.Size = new System.Drawing.Size(400, 23);
            this.CampaignName.TabIndex = 0;
            this.CampaignName.TabStop = false;
            this.CampaignName.UseSystemPasswordChar = false;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainLayout.SetColumnSpan(this.Divider, 3);
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(0, 246);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.MaximumSize = new System.Drawing.Size(0, 1);
            this.Divider.MinimumSize = new System.Drawing.Size(0, 1);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(760, 1);
            this.Divider.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(683, 14);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 37);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateBtn.Depth = 0;
            this.CreateBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateBtn.Header = false;
            this.CreateBtn.Icon = null;
            this.CreateBtn.Location = new System.Drawing.Point(604, 14);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Primary = true;
            this.CreateBtn.Size = new System.Drawing.Size(71, 37);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonsPanel.ColumnCount = 3;
            this.MainLayout.SetColumnSpan(this.ButtonsPanel, 3);
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsPanel.Controls.Add(this.CancelBtn, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CreateBtn, 1, 0);
            this.ButtonsPanel.Depth = 0;
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 247);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.ButtonsPanel.RowCount = 1;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsPanel.Size = new System.Drawing.Size(760, 57);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // FormLayout
            // 
            this.FormLayout.ColumnCount = 2;
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FormLayout.Controls.Add(this.BrowseBox, 1, 2);
            this.FormLayout.Controls.Add(this.CampaignName, 0, 0);
            this.FormLayout.Controls.Add(this.CampaignDirectory, 0, 2);
            this.FormLayout.Controls.Add(this.CampaignDescription, 0, 1);
            this.FormLayout.Depth = 0;
            this.FormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLayout.Location = new System.Drawing.Point(152, 49);
            this.FormLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FormLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormLayout.Name = "FormLayout";
            this.FormLayout.Padding = new System.Windows.Forms.Padding(22);
            this.FormLayout.RowCount = 4;
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormLayout.Size = new System.Drawing.Size(456, 148);
            this.FormLayout.TabIndex = 2;
            // 
            // NewCampaignWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MainLayout);
            this.Name = "NewCampaignWizard";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.PageName = "pages:newcampaignwizard";
            this.PageTitle = "New campaign";
            this.Size = new System.Drawing.Size(784, 328);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.BrowseBox.ResumeLayout(false);
            this.BrowseBox.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.FormLayout.ResumeLayout(false);
            this.FormLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CreateBtn;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignName;
        private MaterialTableLayoutPanel MainLayout;
        private MaterialPanel FormPanel_;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignDescription;
        private MaterialPanel BrowseBox;
        private MaterialSkin.Controls.MaterialFlatButton BrowseBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField CampaignDirectory;
        private MaterialDivider Divider;
        private MaterialTableLayoutPanel ButtonsPanel;
        private MaterialTableLayoutPanel FormLayout;
    }
}
