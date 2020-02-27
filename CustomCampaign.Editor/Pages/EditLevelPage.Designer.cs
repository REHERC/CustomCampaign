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
            this.TimerTitle = new MaterialSkin.Controls.MaterialLabel();
            this.TimerValue = new MaterialSkin.Controls.MaterialLabel();
            this.TimerOptions = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.TimerBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.HideInSprint = new MaterialSkin.Controls.MaterialCheckBox();
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.FormPanel = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ButtonsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.FormDivider = new MaterialSkin.Controls.MaterialDivider();
            this.LevelPanel.SuspendLayout();
            this.TimerOptions.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverwriteLoadingText
            // 
            this.OverwriteLoadingText.AutoSize = true;
            this.OverwriteLoadingText.Depth = 0;
            this.OverwriteLoadingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverwriteLoadingText.Font = new System.Drawing.Font("Roboto", 11F);
            this.OverwriteLoadingText.Location = new System.Drawing.Point(0, 138);
            this.OverwriteLoadingText.Margin = new System.Windows.Forms.Padding(0);
            this.OverwriteLoadingText.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OverwriteLoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverwriteLoadingText.Name = "OverwriteLoadingText";
            this.OverwriteLoadingText.Ripple = true;
            this.OverwriteLoadingText.Size = new System.Drawing.Size(374, 30);
            this.OverwriteLoadingText.TabIndex = 5;
            this.OverwriteLoadingText.Text = "Overwrite loading text";
            this.OverwriteLoadingText.UseVisualStyleBackColor = true;
            this.OverwriteLoadingText.CheckedChanged += new System.EventHandler(this.OverwriteLoadingText_CheckedChanged);
            // 
            // DisplayIntro
            // 
            this.DisplayIntro.AutoSize = true;
            this.DisplayIntro.Depth = 0;
            this.DisplayIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayIntro.Font = new System.Drawing.Font("Roboto", 11F);
            this.DisplayIntro.Location = new System.Drawing.Point(0, 27);
            this.DisplayIntro.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayIntro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DisplayIntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisplayIntro.Name = "DisplayIntro";
            this.DisplayIntro.Ripple = true;
            this.DisplayIntro.Size = new System.Drawing.Size(374, 30);
            this.DisplayIntro.TabIndex = 1;
            this.DisplayIntro.Text = "Display level intro title";
            this.DisplayIntro.UseVisualStyleBackColor = true;
            this.DisplayIntro.CheckedChanged += new System.EventHandler(this.DisplayIntro_CheckedChanged);
            // 
            // LoadingText
            // 
            this.LoadingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoadingText.Depth = 0;
            this.LoadingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingText.Hint = "Loading text";
            this.LoadingText.Location = new System.Drawing.Point(6, 170);
            this.LoadingText.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.LoadingText.MaxLength = 32767;
            this.LoadingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadingText.Name = "LoadingText";
            this.LoadingText.PasswordChar = '\0';
            this.LoadingText.SelectedText = "";
            this.LoadingText.SelectionLength = 0;
            this.LoadingText.SelectionStart = 0;
            this.LoadingText.Size = new System.Drawing.Size(368, 23);
            this.LoadingText.TabIndex = 6;
            this.LoadingText.TabStop = false;
            this.LoadingText.UseSystemPasswordChar = false;
            this.LoadingText.Visible = false;
            this.LoadingText.TextChanged += new System.EventHandler(this.LoadingText_TextChanged);
            // 
            // LoadingBackground
            // 
            this.LoadingBackground.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoadingBackground.Depth = 0;
            this.LoadingBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingBackground.Hint = "Loading background image";
            this.LoadingBackground.Location = new System.Drawing.Point(6, 113);
            this.LoadingBackground.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.LoadingBackground.MaxLength = 32767;
            this.LoadingBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadingBackground.Name = "LoadingBackground";
            this.LoadingBackground.PasswordChar = '\0';
            this.LoadingBackground.SelectedText = "";
            this.LoadingBackground.SelectionLength = 0;
            this.LoadingBackground.SelectionStart = 0;
            this.LoadingBackground.Size = new System.Drawing.Size(368, 23);
            this.LoadingBackground.TabIndex = 4;
            this.LoadingBackground.TabStop = false;
            this.LoadingBackground.UseSystemPasswordChar = false;
            this.LoadingBackground.TextChanged += new System.EventHandler(this.LoadingBackground_TextChanged);
            // 
            // LevelSector
            // 
            this.LevelSector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LevelSector.Depth = 0;
            this.LevelSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelSector.Hint = "Level sector name";
            this.LevelSector.Location = new System.Drawing.Point(6, 86);
            this.LevelSector.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.LevelSector.MaxLength = 32767;
            this.LevelSector.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelSector.Name = "LevelSector";
            this.LevelSector.PasswordChar = '\0';
            this.LevelSector.SelectedText = "";
            this.LevelSector.SelectionLength = 0;
            this.LevelSector.SelectionStart = 0;
            this.LevelSector.Size = new System.Drawing.Size(368, 23);
            this.LevelSector.TabIndex = 3;
            this.LevelSector.TabStop = false;
            this.LevelSector.UseSystemPasswordChar = false;
            this.LevelSector.Visible = false;
            this.LevelSector.TextChanged += new System.EventHandler(this.LevelSector_TextChanged);
            // 
            // LevelName
            // 
            this.LevelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LevelName.Depth = 0;
            this.LevelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelName.Hint = "Level name";
            this.LevelName.Location = new System.Drawing.Point(6, 59);
            this.LevelName.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.LevelName.MaxLength = 32767;
            this.LevelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelName.Name = "LevelName";
            this.LevelName.PasswordChar = '\0';
            this.LevelName.SelectedText = "";
            this.LevelName.SelectionLength = 0;
            this.LevelName.SelectionStart = 0;
            this.LevelName.Size = new System.Drawing.Size(368, 23);
            this.LevelName.TabIndex = 2;
            this.LevelName.TabStop = false;
            this.LevelName.UseSystemPasswordChar = false;
            this.LevelName.Visible = false;
            this.LevelName.TextChanged += new System.EventHandler(this.LevelName_TextChanged);
            // 
            // LevelPanel
            // 
            this.LevelPanel.AutoSize = true;
            this.LevelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LevelPanel.Controls.Add(this.LevelFile);
            this.LevelPanel.Controls.Add(this.LocateLevel);
            this.LevelPanel.Depth = 0;
            this.LevelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelPanel.Location = new System.Drawing.Point(6, 2);
            this.LevelPanel.Margin = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.LevelPanel.MinimumSize = new System.Drawing.Size(0, 23);
            this.LevelPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(368, 23);
            this.LevelPanel.TabIndex = 0;
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
            this.LevelFile.Size = new System.Drawing.Size(292, 23);
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
            this.LocateLevel.Location = new System.Drawing.Point(292, 0);
            this.LocateLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LocateLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LocateLevel.Name = "LocateLevel";
            this.LocateLevel.Primary = false;
            this.LocateLevel.Size = new System.Drawing.Size(76, 23);
            this.LocateLevel.TabIndex = 1;
            this.LocateLevel.Text = "Browse";
            this.LocateLevel.UseVisualStyleBackColor = true;
            this.LocateLevel.Click += new System.EventHandler(this.LocateLevel_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(309, 9);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.AutoSize = true;
            this.ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmBtn.Depth = 0;
            this.ConfirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfirmBtn.Header = false;
            this.ConfirmBtn.Icon = null;
            this.ConfirmBtn.Location = new System.Drawing.Point(220, 9);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.ConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Primary = true;
            this.ConfirmBtn.Size = new System.Drawing.Size(81, 36);
            this.ConfirmBtn.TabIndex = 0;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // TimerTitle
            // 
            this.TimerTitle.AutoSize = true;
            this.TimerTitle.Depth = 0;
            this.TimerTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.TimerTitle.FontSize = 11;
            this.TimerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimerTitle.FormLabel = false;
            this.TimerTitle.Location = new System.Drawing.Point(0, 8);
            this.TimerTitle.Margin = new System.Windows.Forms.Padding(0, 8, 6, 8);
            this.TimerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerTitle.Name = "TimerTitle";
            this.TimerTitle.Size = new System.Drawing.Size(71, 19);
            this.TimerTitle.TabIndex = 0;
            this.TimerTitle.Text = "Car timer";
            // 
            // TimerValue
            // 
            this.TimerValue.AutoSize = true;
            this.TimerValue.Depth = 0;
            this.TimerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.TimerValue.FontSize = 11;
            this.TimerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimerValue.FormLabel = true;
            this.TimerValue.Location = new System.Drawing.Point(77, 8);
            this.TimerValue.Margin = new System.Windows.Forms.Padding(0, 8, 6, 8);
            this.TimerValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerValue.Name = "TimerValue";
            this.TimerValue.Size = new System.Drawing.Size(184, 19);
            this.TimerValue.TabIndex = 1;
            this.TimerValue.Text = "Standard sprint stopwatch";
            // 
            // TimerOptions
            // 
            this.TimerOptions.AutoSize = true;
            this.TimerOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimerOptions.ColumnCount = 3;
            this.TimerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TimerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimerOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TimerOptions.Controls.Add(this.TimerBtn, 2, 0);
            this.TimerOptions.Controls.Add(this.TimerTitle, 0, 0);
            this.TimerOptions.Controls.Add(this.TimerValue, 1, 0);
            this.TimerOptions.Depth = 0;
            this.TimerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerOptions.Location = new System.Drawing.Point(4, 197);
            this.TimerOptions.Margin = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.TimerOptions.MaximumSize = new System.Drawing.Size(0, 35);
            this.TimerOptions.MinimumSize = new System.Drawing.Size(0, 35);
            this.TimerOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerOptions.Name = "TimerOptions";
            this.TimerOptions.RowCount = 1;
            this.TimerOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimerOptions.Size = new System.Drawing.Size(370, 35);
            this.TimerOptions.TabIndex = 7;
            // 
            // TimerBtn
            // 
            this.TimerBtn.AutoSize = true;
            this.TimerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimerBtn.Depth = 0;
            this.TimerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerBtn.Icon = null;
            this.TimerBtn.Location = new System.Drawing.Point(271, 6);
            this.TimerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TimerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerBtn.Name = "TimerBtn";
            this.TimerBtn.Primary = false;
            this.TimerBtn.Size = new System.Drawing.Size(95, 23);
            this.TimerBtn.TabIndex = 2;
            this.TimerBtn.Text = "Configure";
            this.TimerBtn.UseVisualStyleBackColor = true;
            this.TimerBtn.Click += new System.EventHandler(this.TimerBtn_Click);
            // 
            // HideInSprint
            // 
            this.HideInSprint.Depth = 0;
            this.HideInSprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HideInSprint.Font = new System.Drawing.Font("Roboto", 11F);
            this.HideInSprint.Location = new System.Drawing.Point(0, 234);
            this.HideInSprint.Margin = new System.Windows.Forms.Padding(0);
            this.HideInSprint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HideInSprint.MouseState = MaterialSkin.MouseState.HOVER;
            this.HideInSprint.Name = "HideInSprint";
            this.HideInSprint.Ripple = true;
            this.HideInSprint.Size = new System.Drawing.Size(374, 30);
            this.HideInSprint.TabIndex = 8;
            this.HideInSprint.Text = "Hide level in sprint mode";
            this.HideInSprint.UseVisualStyleBackColor = true;
            this.HideInSprint.CheckedChanged += new System.EventHandler(this.HideInSprint_CheckedChanged);
            // 
            // MainLayout
            // 
            this.MainLayout.AutoScroll = true;
            this.MainLayout.AutoSize = true;
            this.MainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.FormPanel, 0, 0);
            this.MainLayout.Controls.Add(this.ButtonsLayout, 0, 2);
            this.MainLayout.Depth = 0;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(390, 333);
            this.MainLayout.TabIndex = 0;
            // 
            // FormPanel
            // 
            this.FormPanel.AutoSize = true;
            this.FormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormPanel.ColumnCount = 1;
            this.FormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormPanel.Controls.Add(this.HideInSprint, 0, 8);
            this.FormPanel.Controls.Add(this.LevelPanel, 0, 0);
            this.FormPanel.Controls.Add(this.TimerOptions, 0, 7);
            this.FormPanel.Controls.Add(this.DisplayIntro, 0, 1);
            this.FormPanel.Controls.Add(this.LoadingText, 0, 6);
            this.FormPanel.Controls.Add(this.OverwriteLoadingText, 0, 5);
            this.FormPanel.Controls.Add(this.LevelName, 0, 2);
            this.FormPanel.Controls.Add(this.LevelSector, 0, 3);
            this.FormPanel.Controls.Add(this.LoadingBackground, 0, 4);
            this.FormPanel.Depth = 0;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(8, 8);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(8);
            this.FormPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.RowCount = 9;
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FormPanel.Size = new System.Drawing.Size(374, 264);
            this.FormPanel.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.AutoSize = true;
            this.ButtonsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonsLayout.ColumnCount = 3;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsLayout.Controls.Add(this.ConfirmBtn, 1, 1);
            this.ButtonsLayout.Controls.Add(this.CancelBtn, 2, 1);
            this.ButtonsLayout.Controls.Add(this.FormDivider, 0, 0);
            this.ButtonsLayout.Depth = 0;
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsLayout.Location = new System.Drawing.Point(0, 280);
            this.ButtonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 2;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsLayout.Size = new System.Drawing.Size(390, 53);
            this.ButtonsLayout.TabIndex = 1;
            // 
            // FormDivider
            // 
            this.FormDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonsLayout.SetColumnSpan(this.FormDivider, 3);
            this.FormDivider.Depth = 0;
            this.FormDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormDivider.Location = new System.Drawing.Point(0, 0);
            this.FormDivider.Margin = new System.Windows.Forms.Padding(0);
            this.FormDivider.MaximumSize = new System.Drawing.Size(0, 1);
            this.FormDivider.MinimumSize = new System.Drawing.Size(0, 1);
            this.FormDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.FormDivider.Name = "FormDivider";
            this.FormDivider.Size = new System.Drawing.Size(390, 1);
            this.FormDivider.TabIndex = 2;
            this.FormDivider.Text = "materialDivider1";
            // 
            // EditLevelPage
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MainLayout);
            this.Name = "EditLevelPage";
            this.PageName = "pages:editlevel";
            this.PageTitle = "Add or edit a level";
            this.Size = new System.Drawing.Size(390, 333);
            this.LevelPanel.ResumeLayout(false);
            this.LevelPanel.PerformLayout();
            this.TimerOptions.ResumeLayout(false);
            this.TimerOptions.PerformLayout();
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ButtonsLayout.ResumeLayout(false);
            this.ButtonsLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoadingBackground;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelSector;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField LevelFile;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoadingText;
        private MaterialSkin.Controls.MaterialCheckBox DisplayIntro;
        private MaterialSkin.Controls.MaterialCheckBox OverwriteLoadingText;
        private MaterialSkin.Controls.MaterialPanel LevelPanel;
        private MaterialSkin.Controls.MaterialFlatButton LocateLevel;
        private MaterialSkin.Controls.MaterialTableLayoutPanel TimerOptions;
        private MaterialSkin.Controls.MaterialLabel TimerTitle;
        private MaterialSkin.Controls.MaterialLabel TimerValue;
        private MaterialSkin.Controls.MaterialFlatButton TimerBtn;
        private MaterialSkin.Controls.MaterialCheckBox HideInSprint;
        private MaterialSkin.Controls.MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialTableLayoutPanel ButtonsLayout;
        private MaterialSkin.Controls.MaterialTableLayoutPanel FormPanel;
        private MaterialSkin.Controls.MaterialDivider FormDivider;
    }
}
