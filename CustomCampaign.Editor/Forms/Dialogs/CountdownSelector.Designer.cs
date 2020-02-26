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
            this.materialTableLayoutPanel1 = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Seconds = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.Minutes = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.Hours = new MaterialSkin.Controls.MaterialNumericUpDown();
            this.materialTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTableLayoutPanel1
            // 
            this.materialTableLayoutPanel1.AutoSize = true;
            this.materialTableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialTableLayoutPanel1.ColumnCount = 3;
            this.materialTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.materialTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.materialTableLayoutPanel1.Controls.Add(this.Hours, 0, 0);
            this.materialTableLayoutPanel1.Controls.Add(this.Minutes, 1, 0);
            this.materialTableLayoutPanel1.Controls.Add(this.Seconds, 2, 0);
            this.materialTableLayoutPanel1.Depth = 0;
            this.materialTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.materialTableLayoutPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTableLayoutPanel1.Name = "materialTableLayoutPanel1";
            this.materialTableLayoutPanel1.RowCount = 1;
            this.materialTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.materialTableLayoutPanel1.Size = new System.Drawing.Size(613, 50);
            this.materialTableLayoutPanel1.TabIndex = 0;
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
            this.Seconds.Location = new System.Drawing.Point(420, 12);
            this.Seconds.Margin = new System.Windows.Forms.Padding(12);
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
            this.Seconds.Size = new System.Drawing.Size(181, 26);
            this.Seconds.TabIndex = 0;
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
            this.Minutes.Location = new System.Drawing.Point(216, 12);
            this.Minutes.Margin = new System.Windows.Forms.Padding(12);
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
            this.Minutes.Size = new System.Drawing.Size(180, 26);
            this.Minutes.TabIndex = 0;
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
            this.Hours.Location = new System.Drawing.Point(12, 12);
            this.Hours.Margin = new System.Windows.Forms.Padding(12);
            this.Hours.Maximum = new decimal(new int[] {
            23,
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
            this.Hours.Size = new System.Drawing.Size(180, 26);
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
            // CountdownSelector
            // 
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(613, 86);
            this.Controls.Add(this.materialTableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.Name = "CountdownSelector";
            this.Padding = new System.Windows.Forms.Padding(0, 36, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Timer configuration";
            this.materialTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTableLayoutPanel materialTableLayoutPanel1;
        private MaterialSkin.Controls.MaterialNumericUpDown Seconds;
        private MaterialSkin.Controls.MaterialNumericUpDown Minutes;
        private MaterialSkin.Controls.MaterialNumericUpDown Hours;
    }
}
