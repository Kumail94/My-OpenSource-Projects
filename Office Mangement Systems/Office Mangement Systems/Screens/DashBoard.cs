using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Mangement_Systems.Screens
{
    public partial class DashBoard : MaterialSkin.Controls.MaterialForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBranch manage = new ManageBranch();
            manage.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchInfo branch = new BranchInfo();
            branch.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EmployeeInfo employee = new EmployeeInfo();
            //employee.ShowDialog();
        }
    }
}
