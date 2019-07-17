using MaterialSkin.Controls;
using System;
using System.ComponentModel;

namespace CustomCampaign.Editor.Classes
{
    public class Page : MaterialUserControl
    {
        public event Action<Page> TitleChanged = (sender) => { };

        private string _pageTitle;
        [Category("Page Settings")]
        public string PageTitle
        {
            get
            {
                return _pageTitle;
            }
            set
            {
                _pageTitle = value;
                TitleChanged(this);
            }
        }

        public Page()
        {
            
        }

        [Category("Page Settings")]
        public string PageName { get; set; }

        public virtual void OnDisplay()
        { }

        public void ClosePage()
        {
            Globals.MainWindow.Pages.Remove(this);
            Dispose();
        }
    }
}
