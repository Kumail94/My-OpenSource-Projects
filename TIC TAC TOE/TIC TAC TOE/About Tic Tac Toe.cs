using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class About_Tic_Tac_Toe : Form
    {
        public About_Tic_Tac_Toe()
        {
            InitializeComponent();
        }

        private void About_Tic_Tac_Toe_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Pharmacy_Application obj = new Pharmacy_Application();
            obj.ShowDialog();
        }
    }
}
