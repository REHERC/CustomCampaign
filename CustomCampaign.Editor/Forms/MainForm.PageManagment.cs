using CustomCampaign.Editor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomCampaign.Editor.Forms
{
    public partial class MainForm
    {
        public List<Page> Pages = new List<Page>();

        public void AddPageForce(Page page)
        {
            if (!HasPage(page.PageName))
            {
                RemovePage(page.PageName);
            }
            AddPage(page);
        }

        public T GetPage<T>(string name) where T : Page
        {
            try
            {
                foreach(Page page in Pages)
                {
                    if (page.PageName == name)
                        return (T)page;
                }
            }
            catch (Exception) { }
            return null;
        }

        public void AddPageSafe(Page page)
        {
            if (!HasPage(page.PageName))
            {
                AddPage(page);
                page.TitleChanged += (sender) =>
                {
                    if (sender.Visible)
                        Text = sender.PageTitle;
                };
            }
        }

        public void AddPage(Page page)
        {
            Pages.Add(page);
            MainPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }

        public void RemovePage(string name)
        {
            Page currentpage = GetPage(name);
            MainPanel.Controls.Remove(currentpage);
            Pages.Remove(currentpage);
            currentpage.Dispose();
        }

        public void SetPage(string name)
        {
            Page currentpage = GetPage(name);
            foreach (Page page in Pages)
            {
                page.Visible = false;
            }
            currentpage.Visible = true;
            //PageNameBackground.Visible = (bool)(currentpage.PageTitle != "");
            Text = currentpage.PageTitle;
            currentpage.OnDisplay();
            currentpage.Select();
            currentpage.Focus();
        }

        public bool HasPage(string name)
        {
            foreach (Page page in Pages)
            {
                if (page.PageName == name) return true;
            }
            return false;
        }

        public Page GetPage(string name)
        {
            if (Pages != null && Pages.Count > 0)
            {
                try
                {
                    return new List<Page>(from page in Pages where page.PageName == name select page).Last();
                }
                catch (Exception)
                {
                    return null; // new ErrorPage("Internal Error", "The page you requested for couldn't be loaded.", "If you see this message, please report it using the \"Bug report\" button on the top-right corner.");
                }
            }
            return new Page();
        }
    }
}
