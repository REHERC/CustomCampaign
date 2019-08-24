namespace CustomCampaign.Editor.Pages
{
    partial class EditAddonPage
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
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.FormPanel = new MaterialSkin.Controls.MaterialPanel();
            this.DependenciesLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ActionsPanel = new MaterialSkin.Controls.MaterialPanel();
            this.RemoveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Dependencies = new MaterialSkin.Controls.MaterialListBox();
            this.AddonFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddonName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfirmBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainLayout.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.DependenciesLayout.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Controls.Add(this.FormPanel, 0, 0);
            this.MainLayout.Depth = 0;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(784, 455);
            this.MainLayout.TabIndex = 7;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormPanel.Controls.Add(this.DependenciesLayout);
            this.FormPanel.Controls.Add(this.AddonFile);
            this.FormPanel.Controls.Add(this.AddonName);
            this.FormPanel.Depth = 0;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Padding = new System.Windows.Forms.Padding(16);
            this.FormPanel.Size = new System.Drawing.Size(784, 455);
            this.FormPanel.TabIndex = 0;
            // 
            // DependenciesLayout
            // 
            this.DependenciesLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DependenciesLayout.AutoSize = true;
            this.DependenciesLayout.ColumnCount = 2;
            this.DependenciesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.DependenciesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DependenciesLayout.Controls.Add(this.ActionsPanel, 0, 0);
            this.DependenciesLayout.Controls.Add(this.Dependencies, 1, 0);
            this.DependenciesLayout.Depth = 0;
            this.DependenciesLayout.Location = new System.Drawing.Point(20, 90);
            this.DependenciesLayout.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.DependenciesLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.DependenciesLayout.Name = "DependenciesLayout";
            this.DependenciesLayout.RowCount = 1;
            this.DependenciesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.DependenciesLayout.Size = new System.Drawing.Size(744, 345);
            this.DependenciesLayout.TabIndex = 7;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.RemoveBtn);
            this.ActionsPanel.Controls.Add(this.EditBtn);
            this.ActionsPanel.Controls.Add(this.AddBtn);
            this.ActionsPanel.Depth = 0;
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ActionsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(160, 345);
            this.ActionsPanel.TabIndex = 4;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveBtn.Depth = 0;
            this.RemoveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveBtn.Icon = null;
            this.RemoveBtn.Location = new System.Drawing.Point(0, 72);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Primary = false;
            this.RemoveBtn.Size = new System.Drawing.Size(160, 36);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove Dependency";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSize = true;
            this.EditBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBtn.Depth = 0;
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBtn.Icon = null;
            this.EditBtn.Location = new System.Drawing.Point(0, 36);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Primary = false;
            this.EditBtn.Size = new System.Drawing.Size(160, 36);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit Dependency";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.Depth = 0;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.Icon = null;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Primary = false;
            this.AddBtn.Size = new System.Drawing.Size(160, 36);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Dependency";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Dependencies
            // 
            this.Dependencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dependencies.Depth = 0;
            this.Dependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dependencies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Dependencies.Font = new System.Drawing.Font("Roboto", 12F);
            this.Dependencies.FormattingEnabled = true;
            this.Dependencies.ItemHeight = 36;
            this.Dependencies.Location = new System.Drawing.Point(160, 0);
            this.Dependencies.Margin = new System.Windows.Forms.Padding(0);
            this.Dependencies.MouseState = MaterialSkin.MouseState.HOVER;
            this.Dependencies.Name = "Dependencies";
            this.Dependencies.Size = new System.Drawing.Size(584, 345);
            this.Dependencies.TabIndex = 3;
            this.Dependencies.SelectedIndexChanged += new System.EventHandler(this.Dependencies_SelectedIndexChanged);
            // 
            // AddonFile
            // 
            this.AddonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddonFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddonFile.Depth = 0;
            this.AddonFile.Hint = "Addon dll file (required)";
            this.AddonFile.Location = new System.Drawing.Point(20, 51);
            this.AddonFile.Margin = new System.Windows.Forms.Padding(4);
            this.AddonFile.MaxLength = 32767;
            this.AddonFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddonFile.Name = "AddonFile";
            this.AddonFile.PasswordChar = '\0';
            this.AddonFile.SelectedText = "";
            this.AddonFile.SelectionLength = 0;
            this.AddonFile.SelectionStart = 0;
            this.AddonFile.Size = new System.Drawing.Size(744, 23);
            this.AddonFile.TabIndex = 2;
            this.AddonFile.TabStop = false;
            this.AddonFile.UseSystemPasswordChar = false;
            this.AddonFile.TextChanged += new System.EventHandler(this.AddonFile_TextChanged);
            // 
            // AddonName
            // 
            this.AddonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddonName.Depth = 0;
            this.AddonName.Hint = "Addon name (required)";
            this.AddonName.Location = new System.Drawing.Point(20, 20);
            this.AddonName.Margin = new System.Windows.Forms.Padding(4);
            this.AddonName.MaxLength = 32767;
            this.AddonName.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddonName.Name = "AddonName";
            this.AddonName.PasswordChar = '\0';
            this.AddonName.SelectedText = "";
            this.AddonName.SelectionLength = 0;
            this.AddonName.SelectionStart = 0;
            this.AddonName.Size = new System.Drawing.Size(744, 23);
            this.AddonName.TabIndex = 0;
            this.AddonName.TabStop = false;
            this.AddonName.UseSystemPasswordChar = false;
            this.AddonName.TextChanged += new System.EventHandler(this.AddonName_TextChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(700, 464);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmBtn.AutoSize = true;
            this.ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmBtn.Depth = 0;
            this.ConfirmBtn.Header = false;
            this.ConfirmBtn.Icon = null;
            this.ConfirmBtn.Location = new System.Drawing.Point(612, 464);
            this.ConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Primary = true;
            this.ConfirmBtn.Size = new System.Drawing.Size(81, 36);
            this.ConfirmBtn.TabIndex = 5;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // EditAddonPage
            // 
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Name = "EditAddonPage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.PageName = "pages:editaddon";
            this.PageTitle = "Add or edit an addon";
            this.Size = new System.Drawing.Size(784, 512);
            this.MainLayout.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.DependenciesLayout.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialPanel FormPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddonFile;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddonName;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmBtn;
        private MaterialSkin.Controls.MaterialTableLayoutPanel DependenciesLayout;
        private MaterialSkin.Controls.MaterialListBox Dependencies;
        private MaterialSkin.Controls.MaterialPanel ActionsPanel;
        private MaterialSkin.Controls.MaterialFlatButton RemoveBtn;
        private MaterialSkin.Controls.MaterialFlatButton EditBtn;
        private MaterialSkin.Controls.MaterialFlatButton AddBtn;
    }
}
