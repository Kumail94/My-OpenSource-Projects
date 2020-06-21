using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Sets_and_DataTables
{
    public partial class WEB_BROWSER : Form
    {
        public WEB_BROWSER()
        {
            InitializeComponent();
        }
        string google = "http://www.google.com";
        private void WEB_BROWSER_Load(object sender, EventArgs e)
        {
            Navigation(google);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            Navigation(toolStripComboBox.Text);
        }

        private void Navigation(string google)
        {
            webBrowser.Navigate(google);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTables table = new DataTables();
            table.ShowDialog();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
