namespace CustomCampaign.Editor.Forms
{
    partial class ExportProgressDialog
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
            this.MainPanel = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Status = new MaterialSkin.Controls.MaterialLabel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.Controls.Add(this.Progress, 0, 1);
            this.MainPanel.Controls.Add(this.Status, 0, 0);
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(4, 40);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 2;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.Size = new System.Drawing.Size(488, 71);
            this.MainPanel.TabIndex = 0;
            // 
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress.Location = new System.Drawing.Point(8, 39);
            this.Progress.Margin = new System.Windows.Forms.Padding(8);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(472, 24);
            this.Progress.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Depth = 0;
            this.Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status.FontSize = 11;
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.FormLabel = false;
            this.Status.Location = new System.Drawing.Point(8, 8);
            this.Status.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(472, 19);
            this.Status.TabIndex = 1;
            this.Status.Text = "Running task...";
            // 
            // ExportProgressDialog
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(496, 115);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 0);
            this.Name = "ExportProgressDialog";
            this.Padding = new System.Windows.Forms.Padding(4, 40, 4, 4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Exporting campaign...";
            this.Load += new System.EventHandler(this.ExportProgressDialog_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTableLayoutPanel MainPanel;
        private System.Windows.Forms.ProgressBar Progress;
        private MaterialSkin.Controls.MaterialLabel Status;
    }
}