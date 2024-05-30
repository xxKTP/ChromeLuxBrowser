using EasyTabs;
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

namespace ChromeLux_Browser_1._0._1
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

           AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }


        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "ChromeLux Browser"
                }
            };
        }
        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
