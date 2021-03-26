using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web2._0
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(adressBar.Text != "")
            {   
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.DocumentCompleted += Web_DocumentCompleted;
            web.Navigate(adressBar.Text);
            }
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            web.GoHome();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            web.Navigate("https://yandex.ru/");
        }

        private void adressBar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void adressBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                web.Navigate(adressBar.Text);
            }
        }
    }
}
