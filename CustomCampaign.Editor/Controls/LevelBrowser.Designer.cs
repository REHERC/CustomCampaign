namespace CustomCampaign.Editor.Controls
{
    partial class LevelBrowser
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
            this.MainPanel = new MaterialSkin.Controls.MaterialTableLayoutPanel();
            this.ListPanel = new MaterialSkin.Controls.MaterialPanel();
            this.Levels = new MaterialSkin.Controls.MaterialListBox();
            this.PreviewPanel = new MaterialSkin.Controls.MaterialPanel();
            this.FileSize = new MaterialSkin.Controls.MaterialLabel();
            this.LevelName = new MaterialSkin.Controls.MaterialLabel();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.Divider = new MaterialSkin.Controls.MaterialDivider();
            this.MainPanel.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.ListPanel, 0, 0);
            this.MainPanel.Controls.Add(this.PreviewPanel, 0, 2);
            this.MainPanel.Controls.Add(this.Divider, 0, 1);
            this.MainPanel.Depth = 0;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.MainPanel.Size = new System.Drawing.Size(640, 480);
            this.MainPanel.TabIndex = 0;
            // 
            // ListPanel
            // 
            this.ListPanel.Controls.Add(this.Levels);
            this.ListPanel.Depth = 0;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ListPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Padding = new System.Windows.Forms.Padding(16, 0, 0, 4);
            this.ListPanel.Size = new System.Drawing.Size(640, 383);
            this.ListPanel.TabIndex = 1;
            // 
            // Levels
            // 
            this.Levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Levels.Depth = 0;
            this.Levels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Levels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Levels.Font = new System.Drawing.Font("Roboto", 12F);
            this.Levels.FormattingEnabled = true;
            this.Levels.ItemHeight = 36;
            this.Levels.Location = new System.Drawing.Point(16, 0);
            this.Levels.Margin = new System.Windows.Forms.Padding(0);
            this.Levels.MouseState = MaterialSkin.MouseState.HOVER;
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(624, 379);
            this.Levels.TabIndex = 0;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.Levels_SelectedIndexChanged);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.FileSize);
            this.PreviewPanel.Controls.Add(this.LevelName);
            this.PreviewPanel.Controls.Add(this.Thumbnail);
            this.PreviewPanel.Depth = 0;
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(0, 384);
            this.PreviewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PreviewPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Padding = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.PreviewPanel.Size = new System.Drawing.Size(640, 96);
            this.PreviewPanel.TabIndex = 0;
            // 
            // FileSize
            // 
            this.FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSize.Depth = 0;
            this.FileSize.Font = new System.Drawing.Font("Roboto", 14F);
            this.FileSize.FontSize = 14;
            this.FileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FileSize.FormLabel = false;
            this.FileSize.Location = new System.Drawing.Point(164, 38);
            this.FileSize.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.FileSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(468, 24);
            this.FileSize.TabIndex = 2;
            this.FileSize.Text = "0 Kb";
            // 
            // LevelName
            // 
            this.LevelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelName.Depth = 0;
            this.LevelName.Font = new System.Drawing.Font("Roboto", 18F);
            this.LevelName.FontSize = 18;
            this.LevelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LevelName.FormLabel = false;
            this.LevelName.Location = new System.Drawing.Point(163, 8);
            this.LevelName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LevelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LevelName.Name = "LevelName";
            this.LevelName.Size = new System.Drawing.Size(469, 29);
            this.LevelName.TabIndex = 1;
            this.LevelName.Text = "Level name";
            // 
            // Thumbnail
            // 
            this.Thumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thumbnail.Image = global::CustomCampaign.Editor.Resx.Resources.NoPreview;
            this.Thumbnail.Location = new System.Drawing.Point(16, 8);
            this.Thumbnail.Margin = new System.Windows.Forms.Padding(8);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(142, 80);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 0;
            this.Thumbnail.TabStop = false;
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Divider.Depth = 0;
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.Location = new System.Drawing.Point(0, 383);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.MaximumSize = new System.Drawing.Size(0, 1);
            this.Divider.MinimumSize = new System.Drawing.Size(0, 1);
            this.Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(640, 1);
            this.Divider.TabIndex = 2;
            this.Divider.Text = "materialDivider1";
            // 
            // LevelBrowser
            // 
            this.Controls.Add(this.MainPanel);
            this.Name = "LevelBrowser";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.LevelBrowser_Load);
            this.MainPanel.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTableLayoutPanel MainPanel;
        private MaterialSkin.Controls.MaterialPanel PreviewPanel;
        private System.Windows.Forms.PictureBox Thumbnail;
        private MaterialSkin.Controls.MaterialLabel LevelName;
        private MaterialSkin.Controls.MaterialPanel ListPanel;
        private MaterialSkin.Controls.MaterialListBox Levels;
        private MaterialSkin.Controls.MaterialDivider Divider;
        private MaterialSkin.Controls.MaterialLabel FileSize;
    }
}
