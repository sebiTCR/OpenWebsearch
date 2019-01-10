using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWebsearch
{
    public partial class Browser : Form
    {
        public Browser()
        {
            string DSE = "www.duckduckgo.com" ;
            InitializeComponent();
        }

        private void Homeb_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("www.duckduckgo.com");
        }
    }
}
