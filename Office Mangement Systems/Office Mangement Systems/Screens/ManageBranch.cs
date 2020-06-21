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
    public partial class ManageBranch : MaterialSkin.Controls.MaterialForm
    {
        public ManageBranch()
        {
            InitializeComponent();
        }
        public bool IsUpdated { get; set; }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard board = new DashBoard();
            board.Show();
        }

        private void ManageBranch_Load(object sender, EventArgs e)
        {

            LoadDataIntoGridView();
        }

        private void LoadDataIntoGridView()
        {
            ListData.LoadingData.LoadDataIntoDataGridView(dataGridView, "GetAllBranches");
        }

        private void ShowBranchInfo(int v1, bool v2)
        {
            BranchInfo info = new BranchInfo();
            info.Id = v1;
            info.IsUpdated = v2;
            info.ShowDialog();
            LoadDataIntoGridView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBranchInfo(0, false);
           
        }
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            int rowIndex = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int index = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["Branch Id"].Value);
            ShowBranchInfo(index, true);
        }
    }
}
