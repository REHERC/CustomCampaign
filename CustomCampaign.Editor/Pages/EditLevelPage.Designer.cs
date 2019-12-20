namespace CustomCampaign.Editor.Pages
{
    partial class EditLevelPage
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
            this.HideInSprint = new MaterialSkin.Controls.MaterialCheckBox();
            this.OverwriteLoadingText = new MaterialSkin.Controls.MaterialCheckBox();
            this.DisplayIntro = new MaterialSkin.Controls.MaterialCheckBox();
            this.LoadingText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoadingBackground = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LevelSector = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LevelName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LevelPanel = new MaterialSkin.Controls.MaterialPanel();
            this.LevelFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LocateLevel = new MaterialSkin.Controls.MaterialFlatButton();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfirmBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainLayout.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.LevelPanel.SuspendLayout();
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
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(784, 455);
            this.MainLayout.TabIndex = 4;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoScroll = true;
            this.FormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormPanel.Controls.Add(this.HideInSprint);
            this.FormPanel.Controls.Add(this.OverwriteLoadingText);
            this.FormPanel.Controls.Add(this.DisplayIntro);
            this.FormPanel.Controls.Add(this.LoadingText);
            this.FormPanel.Controls.Add(this.LoadingBackground);
            this.FormPanel.Controls.Add(this.LevelSector);
            this.FormPanel.Controls.Add(this.LevelName);
            this.FormPanel.Controls.Add(this.LevelPanel);
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
            // HideInSprint
            // 
            this.HideInSprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HideInSprint.Depth = 0;
            this.HideInSprint.Font = new System.Drawing.Font("Roboto", 11F);
            this.HideInSprint.Location = new System.Drawing.Point(13, 261);
            this.HideInSprint.Margin = new System.Windows.Forms.Padding(0);
            this.HideInSprint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HideInSprint.MouseState = MaterialSkin.MouseState.HOVER;
            this.HideInSprint.Name = "HideInSprint";
            this.HideInSprint.Ripple = true;
            this.HideInSprint.Size = new System.Drawing.Size(751, 30);
            this.HideInSprint.TabIndex = 7;
            this.HideInSprint.Text = "Hide level in sprint mode";
            this.HideInSprint.UseVisualStyleBackColor = true;
            this.HideInSprint.CheckedChanged += new System.EventHandler(this.HideInSprint_CheckedChanged);
            // 
            // OverwriteLoadingText
            // 
            this.OverwriteLoadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverwriteLoadingText.Depth = 0;
            this.OverwriteLoadingText.Font = new System.Drawing.Font("Roboto", 11F);
            this.OverwriteLoadingText.Location = new System.Drawing.Point(13, 186);
            this.OverwriteLoadingText.Margin = new System.Windows.Forms.Padding(0);
            this.OverwriteLoadingText.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OverwriteLoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverwriteLoadingText.Name = "OverwriteLoadingText";
            this.OverwriteLoadingText.Ripple = true;
            this.OverwriteLoadingText.Size = new System.Drawing.Size(751, 30);
            this.OverwriteLoadingText.TabIndex = 5;
            this.OverwriteLoadingText.Text = "Overwrite loading text";
            this.OverwriteLoadingText.UseVisualStyleBackColor = true;
            this.OverwriteLoadingText.CheckedChanged += new System.EventHandler(this.OverwriteLoadingText_CheckedChanged);
            // 
            // DisplayIntro
            // 
            this.DisplayIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayIntro.Depth = 0;
            this.DisplayIntro.Font = new System.Drawing.Font("Roboto", 11F);
            this.DisplayIntro.Location = new System.Drawing.Point(13, 51);
            this.DisplayIntro.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayIntro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DisplayIntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisplayIntro.Name = "DisplayIntro";
            this.DisplayIntro.Ripple = true;
            this.DisplayIntro.Size = new System.Drawing.Size(751, 30);
            this.DisplayIntro.TabIndex = 1;
            this.DisplayIntro.Text = "Display level intro title";
            this.DisplayIntro.UseVisualStyleBackColor = true;
            this.DisplayIntro.CheckedChanged += new System.EventHandler(this.DisplayIntro_CheckedChanged);
            // 
            // LoadingText
            // 
            this.LoadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoadingText.Depth = 0;
            this.LoadingText.Hint = "Loading text";
            this.LoadingText.Location = new System.Drawing.Point(20, 224);
            this.LoadingText.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingText.MaxLength = 32767;
            this.LoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadingText.Name = "LoadingText";
            this.LoadingText.PasswordChar = '\0';
            this.LoadingText.SelectedText = "";
            this.LoadingText.SelectionLength = 0;
            this.LoadingText.SelectionStart = 0;
            this.LoadingText.Size = new System.Drawing.Size(744, 23);
            this.LoadingText.TabIndex = 6;
            this.LoadingText.TabStop = false;
            this.LoadingText.UseSystemPasswordChar = false;
            this.LoadingText.TextChanged += new System.EventHandler(this.LoadingText_TextChanged);
            // 
            // LoadingBackground
            // 
            this.LoadingBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBackground.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoadingBackground.Depth = 0;
            this.LoadingBackground.Hint = "Loading background image";
            this.LoadingBackground.Location = new System.Drawing.Point(20, 155);
            this.LoadingBackground.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingBackground.MaxLength = 32767;
            this.LoadingBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadingBackground.Name = "LoadingBackground";
            this.LoadingBackground.PasswordChar = '\0';
            this.LoadingBackground.SelectedText = "";
            this.LoadingBackground.SelectionLength = 0;
            this.LoadingBackground.SelectionStart = 0;
            this.LoadingBackground.Size = new System.Drawing.Size(744, 23);
            this.LoadingBackground.TabIndex = 4;
            this.LoadingBackground.TabStop = false;
            this.LoadingBackground.UseSystemPasswordChar = false;
            this.LoadingBackground.TextChanged += new System.EventHandler(this.LoadingBackground_TextChanged);
            // 
            // LevelSector
            // 
            this.LevelSector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelSector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LevelSector.Depth = 0;
            this.LevelSector.Hint = "Level sector name";
            this.LevelSector.Location = new System.Drawing.Point(20, 120);
            this.LevelSector.Margin = new System.Windows.Forms.Padding(4);
            this.LevelSector.MaxLength = 32767;
            this.LevelSector.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelSector.Name = "LevelSector";
            this.LevelSector.PasswordChar = '\0';
            this.LevelSector.SelectedText = "";
            this.LevelSector.SelectionLength = 0;
            this.LevelSector.SelectionStart = 0;
            this.LevelSector.Size = new System.Drawing.Size(744, 23);
            this.LevelSector.TabIndex = 3;
            this.LevelSector.TabStop = false;
            this.LevelSector.UseSystemPasswordChar = false;
            this.LevelSector.TextChanged += new System.EventHandler(this.LevelSector_TextChanged);
            // 
            // LevelName
            // 
            this.LevelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LevelName.Depth = 0;
            this.LevelName.Hint = "Level name";
            this.LevelName.Location = new System.Drawing.Point(20, 89);
            this.LevelName.Margin = new System.Windows.Forms.Padding(4);
            this.LevelName.MaxLength = 32767;
            this.LevelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelName.Name = "LevelName";
            this.LevelName.PasswordChar = '\0';
            this.LevelName.SelectedText = "";
            this.LevelName.SelectionLength = 0;
            this.LevelName.SelectionStart = 0;
            this.LevelName.Size = new System.Drawing.Size(744, 23);
            this.LevelName.TabIndex = 2;
            this.LevelName.TabStop = false;
            this.LevelName.UseSystemPasswordChar = false;
            this.LevelName.TextChanged += new System.EventHandler(this.LevelName_TextChanged);
            // 
            // LevelPanel
            // 
            this.LevelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelPanel.Controls.Add(this.LevelFile);
            this.LevelPanel.Controls.Add(this.LocateLevel);
            this.LevelPanel.Depth = 0;
            this.LevelPanel.Location = new System.Drawing.Point(20, 20);
            this.LevelPanel.MinimumSize = new System.Drawing.Size(0, 23);
            this.LevelPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(744, 23);
            this.LevelPanel.TabIndex = 8;
            // 
            // LevelFile
            // 
            this.LevelFile.Depth = 0;
            this.LevelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelFile.Hint = "Level file (required)";
            this.LevelFile.Location = new System.Drawing.Point(0, 0);
            this.LevelFile.Margin = new System.Windows.Forms.Padding(4);
            this.LevelFile.MaxLength = 32767;
            this.LevelFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelFile.Name = "LevelFile";
            this.LevelFile.PasswordChar = '\0';
            this.LevelFile.SelectedText = "";
            this.LevelFile.SelectionLength = 0;
            this.LevelFile.SelectionStart = 0;
            this.LevelFile.Size = new System.Drawing.Size(668, 23);
            this.LevelFile.TabIndex = 0;
            this.LevelFile.TabStop = false;
            this.LevelFile.UseSystemPasswordChar = false;
            this.LevelFile.TextChanged += new System.EventHandler(this.LevelFile_TextChanged);
            // 
            // LocateLevel
            // 
            this.LocateLevel.AutoSize = true;
            this.LocateLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocateLevel.Depth = 0;
            this.LocateLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LocateLevel.Icon = null;
            this.LocateLevel.Location = new System.Drawing.Point(668, 0);
            this.LocateLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LocateLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LocateLevel.Name = "LocateLevel";
            this.LocateLevel.Primary = false;
            this.LocateLevel.Size = new System.Drawing.Size(76, 23);
            this.LocateLevel.TabIndex = 4;
            this.LocateLevel.Text = "Browse";
            this.LocateLevel.UseVisualStyleBackColor = true;
            this.LocateLevel.Click += new System.EventHandler(this.LocateLevel_Click);
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
            this.CancelBtn.TabIndex = 3;
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
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // EditLevelPage
            // 
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Name = "EditLevelPage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.PageName = "pages:editlevel";
            this.PageTitle = "Add or edit a level";
            this.Size = new System.Drawing.Size(784, 512);
            this.MainLayout.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.LevelPanel.ResumeLayout(false);
            this.LevelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmBtn;
        private MaterialSkin.Controls.MaterialPanel FormPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoadingBackground;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelSector;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelFile;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoadingText;
        private MaterialSkin.Controls.MaterialCheckBox DisplayIntro;
        private MaterialSkin.Controls.MaterialCheckBox OverwriteLoadingText;
        private MaterialSkin.Controls.MaterialCheckBox HideInSprint;
        private MaterialSkin.Controls.MaterialPanel LevelPanel;
        private MaterialSkin.Controls.MaterialFlatButton LocateLevel;
    }
}
