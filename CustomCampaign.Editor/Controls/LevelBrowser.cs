using CustomCampaign.Editor.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Controls
{
    public partial class LevelBrowser : MaterialSkin.Controls.MaterialUserControl
    {
        private LevelBrowserLocation _searchLocation = LevelBrowserLocation.Project;
        public LevelBrowserLocation SearchLocation
        {
            get => _searchLocation;
            set
            {
                _searchLocation = value;

            }
        }


        public LevelBrowser()
        {
            InitializeComponent();
        }
    }
}
