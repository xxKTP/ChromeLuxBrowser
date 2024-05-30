using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using Microsoft.Web.WebView2.Core;
 using Microsoft.Web.WebView2.WinForms;

namespace ChromeLux_Browser_1._0._1
{
    public partial class Form1 : Form
    {

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }


       public async Task Intizated()
        {
            await webView21.EnsureCoreWebView2Async();
        }

       public async void InitBrowser()
        {
            await Intizated();
            webView21.CoreWebView2.Navigate("Https://www.google.com");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("Https://www.google.com");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.roblox.com/home");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.youtube.com/");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.instagram.com/");
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://discord.com/login");
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://x.com/home");
        }
    }
}
