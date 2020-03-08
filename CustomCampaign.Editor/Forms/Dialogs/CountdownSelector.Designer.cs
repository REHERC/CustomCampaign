namespace CustomCampaign.Editor.Forms.Dialogs
{
    partial class CountdownSelector
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Seconds = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.Minutes = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.Hours = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.MainLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Miliseconds = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.HoursLbl = new MaterialSkin.Controls.MaterialLabel();
            this.MinutesLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SecondsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.MilisecondsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ActionPanel = new MaterialSkin.Controls.MaterialPanel();
            this.ButttonsLayout = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ConfirmBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NoteLbl = new MaterialSkin.Controls.MaterialLabel();
            this.MainLayout.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.ButttonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seconds
            // 
            this.Seconds.DecimalPlaces = 0;
            this.Seconds.Depth = 0;
            this.Seconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seconds.Hexadecimal = false;
            this.Seconds.Hint = "";
            this.Seconds.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Seconds.Location = new System.Drawing.Point(334, 39);
            this.Seconds.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Seconds.MaxLength = 32767;
            this.Seconds.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Seconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.Seconds.Name = "Seconds";
            this.Seconds.ReadOnly = false;
            this.Seconds.SelectedText = "";
            this.Seconds.SelectionLength = 0;
            this.Seconds.SelectionStart = 0;
            this.Seconds.Size = new System.Drawing.Size(137, 26);
            this.Seconds.TabIndex = 2;
            this.Seconds.TabStop = false;
            this.Seconds.Text = "0";
            this.Seconds.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Seconds.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Minutes
            // 
            this.Minutes.DecimalPlaces = 0;
            this.Minutes.Depth = 0;
            this.Minutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minutes.Hexadecimal = false;
            this.Minutes.Hint = "";
            this.Minutes.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Minutes.Location = new System.Drawing.Point(173, 39);
            this.Minutes.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minutes.MaxLength = 32767;
            this.Minutes.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Minutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.Minutes.Name = "Minutes";
            this.Minutes.ReadOnly = false;
            this.Minutes.SelectedText = "";
            this.Minutes.SelectionLength = 0;
            this.Minutes.SelectionStart = 0;
            this.Minutes.Size = new System.Drawing.Size(137, 26);
            this.Minutes.TabIndex = 1;
            this.Minutes.TabStop = false;
            this.Minutes.Text = "0";
            this.Minutes.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Minutes.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Hours
            // 
            this.Hours.DecimalPlaces = 0;
            this.Hours.Depth = 0;
            this.Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hours.Hexadecimal = false;
            this.Hours.Hint = "";
            this.Hours.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Hours.Location = new System.Drawing.Point(12, 39);
            this.Hours.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.Hours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Hours.MaxLength = 32767;
            this.Hours.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Hours.MouseState = MaterialSkin.MouseState.HOVER;
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = false;
            this.Hours.SelectedText = "";
            this.Hours.SelectionLength = 0;
            this.Hours.SelectionStart = 0;
            this.Hours.Size = new System.Drawing.Size(137, 26);
            this.Hours.TabIndex = 0;
            this.Hours.TabStop = false;
            this.Hours.Text = "0";
            this.Hours.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Hours.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MainLayout
            // 
            this.MainLayout.AutoSize = true;
            this.MainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainLayout.ColumnCount = 4;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.Controls.Add(this.Hours, 0, 1);
            this.MainLayout.Controls.Add(this.Minutes, 1, 1);
            this.MainLayout.Controls.Add(this.Seconds, 2, 1);
            this.MainLayout.Controls.Add(this.Miliseconds, 3, 1);
            this.MainLayout.Controls.Add(this.HoursLbl, 0, 0);
            this.MainLayout.Controls.Add(this.MinutesLbl, 1, 0);
            this.MainLayout.Controls.Add(this.SecondsLbl, 2, 0);
            this.MainLayout.Controls.Add(this.MilisecondsLbl, 3, 0);
            this.MainLayout.Controls.Add(this.ActionPanel, 0, 2);
            this.MainLayout.Depth = 0;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLayout.Location = new System.Drawing.Point(4, 40);
            this.MainLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.MainLayout.Size = new System.Drawing.Size(646, 133);
            this.MainLayout.TabIndex = 0;
            // 
            // Miliseconds
            // 
            this.Miliseconds.DecimalPlaces = 0;
            this.Miliseconds.Depth = 0;
            this.Miliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miliseconds.Hexadecimal = false;
            this.Miliseconds.Hint = "";
            this.Miliseconds.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Miliseconds.Location = new System.Drawing.Point(495, 39);
            this.Miliseconds.Margin = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.Miliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Miliseconds.MaxLength = 32767;
            this.Miliseconds.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Miliseconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.Miliseconds.Name = "Miliseconds";
            this.Miliseconds.ReadOnly = false;
            this.Miliseconds.SelectedText = "";
            this.Miliseconds.SelectionLength = 0;
            this.Miliseconds.SelectionStart = 0;
            this.Miliseconds.Size = new System.Drawing.Size(139, 26);
            this.Miliseconds.TabIndex = 3;
            this.Miliseconds.TabStop = false;
            this.Miliseconds.Text = "0";
            this.Miliseconds.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Miliseconds.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // HoursLbl
            // 
            this.HoursLbl.AutoSize = true;
            this.HoursLbl.Depth = 0;
            this.HoursLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.HoursLbl.FontSize = 11;
            this.HoursLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HoursLbl.FormLabel = true;
            this.HoursLbl.Location = new System.Drawing.Point(10, 12);
            this.HoursLbl.Margin = new System.Windows.Forms.Padding(10, 12, 10, 4);
            this.HoursLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.HoursLbl.Name = "HoursLbl";
            this.HoursLbl.Size = new System.Drawing.Size(141, 19);
            this.HoursLbl.TabIndex = 1;
            this.HoursLbl.Text = "Hours (0-99)";
            // 
            // MinutesLbl
            // 
            this.MinutesLbl.AutoSize = true;
            this.MinutesLbl.Depth = 0;
            this.MinutesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinutesLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.MinutesLbl.FontSize = 11;
            this.MinutesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinutesLbl.FormLabel = true;
            this.MinutesLbl.Location = new System.Drawing.Point(171, 12);
            this.MinutesLbl.Margin = new System.Windows.Forms.Padding(10, 12, 10, 4);
            this.MinutesLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinutesLbl.Name = "MinutesLbl";
            this.MinutesLbl.Size = new System.Drawing.Size(141, 19);
            this.MinutesLbl.TabIndex = 1;
            this.MinutesLbl.Text = "Minutes (0-59)";
            // 
            // SecondsLbl
            // 
            this.SecondsLbl.AutoSize = true;
            this.SecondsLbl.Depth = 0;
            this.SecondsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.SecondsLbl.FontSize = 11;
            this.SecondsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SecondsLbl.FormLabel = true;
            this.SecondsLbl.Location = new System.Drawing.Point(332, 12);
            this.SecondsLbl.Margin = new System.Windows.Forms.Padding(10, 12, 10, 4);
            this.SecondsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SecondsLbl.Name = "SecondsLbl";
            this.SecondsLbl.Size = new System.Drawing.Size(141, 19);
            this.SecondsLbl.TabIndex = 1;
            this.SecondsLbl.Text = "Seconds (0-59)";
            // 
            // MilisecondsLbl
            // 
            this.MilisecondsLbl.AutoSize = true;
            this.MilisecondsLbl.Depth = 0;
            this.MilisecondsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MilisecondsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.MilisecondsLbl.FontSize = 11;
            this.MilisecondsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MilisecondsLbl.FormLabel = true;
            this.MilisecondsLbl.Location = new System.Drawing.Point(493, 12);
            this.MilisecondsLbl.Margin = new System.Windows.Forms.Padding(10, 12, 10, 4);
            this.MilisecondsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MilisecondsLbl.Name = "MilisecondsLbl";
            this.MilisecondsLbl.Size = new System.Drawing.Size(143, 19);
            this.MilisecondsLbl.TabIndex = 1;
            this.MilisecondsLbl.Text = "Miliseconds (0-999)";
            // 
            // ActionPanel
            // 
            this.MainLayout.SetColumnSpan(this.ActionPanel, 4);
            this.ActionPanel.Controls.Add(this.ButttonsLayout);
            this.ActionPanel.Depth = 0;
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionPanel.Location = new System.Drawing.Point(0, 69);
            this.ActionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ActionPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Padding = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.ActionPanel.Size = new System.Drawing.Size(646, 64);
            this.ActionPanel.TabIndex = 4;
            // 
            // ButttonsLayout
            // 
            this.ButttonsLayout.AutoSize = true;
            this.ButttonsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButttonsLayout.ColumnCount = 3;
            this.ButttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButttonsLayout.Controls.Add(this.ConfirmBtn, 1, 0);
            this.ButttonsLayout.Controls.Add(this.CancelBtn, 2, 0);
            this.ButttonsLayout.Controls.Add(this.NoteLbl, 0, 0);
            this.ButttonsLayout.Depth = 0;
            this.ButttonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButttonsLayout.Location = new System.Drawing.Point(10, 14);
            this.ButttonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ButttonsLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButttonsLayout.Name = "ButttonsLayout";
            this.ButttonsLayout.RowCount = 1;
            this.ButttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButttonsLayout.Size = new System.Drawing.Size(626, 36);
            this.ButttonsLayout.TabIndex = 5;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.AutoSize = true;
            this.ConfirmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmBtn.Depth = 0;
            this.ConfirmBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfirmBtn.Header = false;
            this.ConfirmBtn.Icon = null;
            this.ConfirmBtn.Location = new System.Drawing.Point(464, 0);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ConfirmBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Primary = true;
            this.ConfirmBtn.Size = new System.Drawing.Size(81, 36);
            this.ConfirmBtn.TabIndex = 6;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(553, 0);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Depth = 0;
            this.NoteLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.NoteLbl.FontSize = 11;
            this.NoteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NoteLbl.FormLabel = false;
            this.NoteLbl.Location = new System.Drawing.Point(0, 9);
            this.NoteLbl.Margin = new System.Windows.Forms.Padding(0, 9, 0, 8);
            this.NoteLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Size = new System.Drawing.Size(364, 19);
            this.NoteLbl.TabIndex = 1;
            this.NoteLbl.Text = "Set an absolute time of 0 to use the sprint stopwatch";
            // 
            // CountdownSelector
            // 
            this.AcceptButton = this.ConfirmBtn;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bar = false;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(654, 173);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 0);
            this.Name = "CountdownSelector";
            this.Padding = new System.Windows.Forms.Padding(4, 40, 4, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Countdown configuration";
            this.Load += new System.EventHandler(this.CountdownSelector_Load);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.ButttonsLayout.ResumeLayout(false);
            this.ButttonsLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialNumericUpDown Seconds;
        private MaterialSkin.Controls.MaterialNumericUpDown Minutes;
        private MaterialSkin.Controls.MaterialNumericUpDown Hours;
        private MaterialSkin.Controls.MaterialTableLayoutPanel MainLayout;
        private MaterialSkin.Controls.MaterialNumericUpDown Miliseconds;
        private MaterialSkin.Controls.MaterialLabel HoursLbl;
        private MaterialSkin.Controls.MaterialLabel MinutesLbl;
        private MaterialSkin.Controls.MaterialLabel SecondsLbl;
        private MaterialSkin.Controls.MaterialLabel MilisecondsLbl;
        private MaterialSkin.Controls.MaterialPanel ActionPanel;
        private MaterialSkin.Controls.MaterialTableLayoutPanel ButttonsLayout;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmBtn;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private MaterialSkin.Controls.MaterialLabel NoteLbl;
    }
}
