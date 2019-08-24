using CustomCampaign.Editor.Properties;
using CustomCampaign.Editor.Resx;

namespace CustomCampaign.Editor.Forms
{
    partial class Aaaaaaa
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
            this.SpookSlow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpookSlow)).BeginInit();
            this.SuspendLayout();
            // 
            // SpookSlow
            // 
            this.SpookSlow.BackColor = System.Drawing.Color.Transparent;
            this.SpookSlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpookSlow.Image = global::CustomCampaign.Editor.Resx.Images.SpookSlow;
            this.SpookSlow.Location = new System.Drawing.Point(8, 48);
            this.SpookSlow.Margin = new System.Windows.Forms.Padding(0);
            this.SpookSlow.Name = "SpookSlow";
            this.SpookSlow.Size = new System.Drawing.Size(280, 236);
            this.SpookSlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpookSlow.TabIndex = 0;
            this.SpookSlow.TabStop = false;
            // 
            // Aaaaaaa
            // 
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(296, 292);
            this.Controls.Add(this.SpookSlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Aaaaaaa";
            this.Padding = new System.Windows.Forms.Padding(8, 48, 8, 8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Title = "Ｓｋｅｌｅｔｏｎ";
            ((System.ComponentModel.ISupportInitialize)(this.SpookSlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpookSlow;
    }
}
