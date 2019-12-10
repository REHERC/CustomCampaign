namespace CustomCampaign.Editor.Forms.Dialogs
{
    partial class LevelBrowserDialog
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
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ProjectTab = new System.Windows.Forms.TabPage();
            this.ProjectBrowser = new CustomCampaign.Editor.Controls.LevelBrowser();
            this.MyLevelsTab = new System.Windows.Forms.TabPage();
            this.MyLevelsBrowser = new CustomCampaign.Editor.Controls.LevelBrowser();
            this.ImportTab = new System.Windows.Forms.TabPage();
            this.BottomActions = new MaterialSkin.Controls.MaterialPanel();
            this.CancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.TabControl.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.MyLevelsTab.SuspendLayout();
            this.BottomActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelector.Location = new System.Drawing.Point(0, 40);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Primary = true;
            this.TabSelector.Size = new System.Drawing.Size(843, 36);
            this.TabSelector.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ProjectTab);
            this.TabControl.Controls.Add(this.MyLevelsTab);
            this.TabControl.Controls.Add(this.ImportTab);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 76);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(843, 299);
            this.TabControl.TabIndex = 1;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.ProjectBrowser);
            this.ProjectTab.Location = new System.Drawing.Point(4, 22);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Size = new System.Drawing.Size(835, 273);
            this.ProjectTab.TabIndex = 0;
            this.ProjectTab.Text = "Project Resources";
            this.ProjectTab.UseVisualStyleBackColor = true;
            // 
            // ProjectBrowser
            // 
            this.ProjectBrowser.Depth = 0;
            this.ProjectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectBrowser.Location = new System.Drawing.Point(0, 0);
            this.ProjectBrowser.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProjectBrowser.Name = "ProjectBrowser";
            this.ProjectBrowser.SearchLocation = CustomCampaign.Editor.Enums.LevelBrowserLocation.Project;
            this.ProjectBrowser.Size = new System.Drawing.Size(835, 273);
            this.ProjectBrowser.TabIndex = 0;
            // 
            // MyLevelsTab
            // 
            this.MyLevelsTab.Controls.Add(this.MyLevelsBrowser);
            this.MyLevelsTab.Location = new System.Drawing.Point(4, 22);
            this.MyLevelsTab.Name = "MyLevelsTab";
            this.MyLevelsTab.Size = new System.Drawing.Size(835, 273);
            this.MyLevelsTab.TabIndex = 1;
            this.MyLevelsTab.Text = "My Levels";
            this.MyLevelsTab.UseVisualStyleBackColor = true;
            // 
            // MyLevelsBrowser
            // 
            this.MyLevelsBrowser.Depth = 0;
            this.MyLevelsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyLevelsBrowser.Location = new System.Drawing.Point(0, 0);
            this.MyLevelsBrowser.MouseState = MaterialSkin.MouseState.HOVER;
            this.MyLevelsBrowser.Name = "MyLevelsBrowser";
            this.MyLevelsBrowser.SearchLocation = CustomCampaign.Editor.Enums.LevelBrowserLocation.MyLevels;
            this.MyLevelsBrowser.Size = new System.Drawing.Size(835, 273);
            this.MyLevelsBrowser.TabIndex = 1;
            // 
            // ImportTab
            // 
            this.ImportTab.Location = new System.Drawing.Point(4, 22);
            this.ImportTab.Name = "ImportTab";
            this.ImportTab.Size = new System.Drawing.Size(835, 273);
            this.ImportTab.TabIndex = 2;
            this.ImportTab.Text = "Import From File";
            this.ImportTab.UseVisualStyleBackColor = true;
            // 
            // BottomActions
            // 
            this.BottomActions.Controls.Add(this.CancelBtn);
            this.BottomActions.Depth = 0;
            this.BottomActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActions.Location = new System.Drawing.Point(0, 375);
            this.BottomActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.BottomActions.Name = "BottomActions";
            this.BottomActions.Padding = new System.Windows.Forms.Padding(0, 8, 16, 16);
            this.BottomActions.Size = new System.Drawing.Size(843, 64);
            this.BottomActions.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(755, 12);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Primary = false;
            this.CancelBtn.Size = new System.Drawing.Size(73, 36);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // LevelBrowserDialog
            // 
            this.Bar = false;
            this.ClientSize = new System.Drawing.Size(843, 439);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.BottomActions);
            this.Controls.Add(this.TabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.Name = "LevelBrowserDialog";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Title = "Select a level";
            this.TabControl.ResumeLayout(false);
            this.ProjectTab.ResumeLayout(false);
            this.MyLevelsTab.ResumeLayout(false);
            this.BottomActions.ResumeLayout(false);
            this.BottomActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage ProjectTab;
        private System.Windows.Forms.TabPage MyLevelsTab;
        private System.Windows.Forms.TabPage ImportTab;
        private MaterialSkin.Controls.MaterialPanel BottomActions;
        private MaterialSkin.Controls.MaterialFlatButton CancelBtn;
        private Controls.LevelBrowser ProjectBrowser;
        private Controls.LevelBrowser MyLevelsBrowser;
    }
}
