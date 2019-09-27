namespace CustomCampaign.Editor.Controls
{
    partial class InfoCard
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
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfilePicture.Location = new System.Drawing.Point(8, 8);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(16);
            this.ProfilePicture.MaximumSize = new System.Drawing.Size(48, 48);
            this.ProfilePicture.MinimumSize = new System.Drawing.Size(48, 48);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(48, 48);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 1;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfilePicture_Paint);
            // 
            // PizzaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProfilePicture);
            this.Name = "PizzaCard";
            this.Size = new System.Drawing.Size(512, 64);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePicture;
    }
}
