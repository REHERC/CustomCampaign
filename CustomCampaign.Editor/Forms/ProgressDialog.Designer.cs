using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    partial class ProgressDialog
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
            this.MainPanel = new MaterialSkin.Controls.MaterialPanel();
            this.HeaderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.HeaderLabel);
            this.MainPanel.Controls.Add(this.Progress);
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(16);
            this.MainPanel.Size = new System.Drawing.Size(360, 96);
            this.MainPanel.TabIndex = 0;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Depth = 0;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.HeaderLabel.FontSize = 11;
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.Location = new System.Drawing.Point(19, 24);
            this.HeaderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(53, 19);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Action";
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(19, 64);
            this.Progress.MarqueeAnimationSpeed = 10;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(322, 5);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Progress.TabIndex = 0;
            this.Progress.Value = 50;
            // 
            // ProgressDialog
            // 
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(360, 96);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Header = false;
            this.Name = "ProgressDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialPanel MainPanel;
        private ProgressBar Progress;
        private MaterialSkin.Controls.MaterialLabel HeaderLabel;
    }
}
