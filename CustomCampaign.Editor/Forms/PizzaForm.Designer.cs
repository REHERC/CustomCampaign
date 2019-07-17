namespace CustomCampaign.Editor.Forms
{
    partial class PizzaForm
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
            this.FlowLayout = new MaterialSkin.Controls.MaterialFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Depth = 0;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(0, 64);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayout.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Padding = new System.Windows.Forms.Padding(8);
            this.FlowLayout.Size = new System.Drawing.Size(850, 386);
            this.FlowLayout.TabIndex = 0;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.FlowLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PizzaForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THE SIMPLES (The people behind custom campaign support for distance)";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlowLayoutPanel FlowLayout;
    }
}