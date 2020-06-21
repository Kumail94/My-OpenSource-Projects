using Custom_Framework;
using Office_Mangement_Systems.App_Settings;
using Office_Mangement_Systems.Branches;
using Office_Mangement_Systems.Images;
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
    public partial class BranchInfo : MaterialSkin.Controls.MaterialForm
    {
        public BranchInfo()
        {
            InitializeComponent();
        }
        public bool IsUpdated { get; set; }
        public int Id { get; set; }
      

        private void panelz_Paint(object sender, PaintEventArgs e)
        {
        }
        private void BranchInfo_Load(object sender, EventArgs e)
        {
            LoadDataInComboBoxes();
            LoadDataInTextBoxes();
        }
        private void LoadDataInComboBoxes()
        {
            try
            {
                ListData.LoadingData.LoadDataInComboBox(comboBoxCITY, "sp_ListDataTyped", new DBParameter { Parameter = "@ID", Value = 1 });
                ListData.LoadingData.LoadDataInComboBox(comboBoxDISTRICT, "sp_ListDataTyped", new DBParameter { Parameter = "@ID", Value = 2 });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message.ToString());
            }
        }
        private void LoadDataInTextBoxes()
        {
            try
            {
                SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
                if (this.IsUpdated)
                {
                    DataTable table = db.GetDataList("GetBranchesByBranchId", new DBParameter { Parameter = "@BranchId", Value = this.Id });
                    DataRow rows = table.Rows[0];
                    materialSingleLineTextField1.Text = rows["Branch Name"].ToString();
                    materialSingleLineTextField2.Text = rows["Email"].ToString();
                    materialSingleLineTextField3.Text = rows["Website"].ToString();
                    pictureBox.Image = (rows["Branch Image"] is DBNull ? null : ImageManipulation.PutPhoto((byte[])rows["Branch Image"]));
                    comboBoxCITY.SelectedValue = rows["City Id"].ToString();
                    comboBoxDISTRICT.SelectedValue = rows["District Id"].ToString();
                    textBox4.Text = rows["Address Line"].ToString();
                    materialSingleLineTextField4.Text = rows["Telephone"].ToString();
                    materialSingleLineTextField5.Text = rows["Post Code"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message.ToString());
            }
        }
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Image";
            ofd.Filter = "Select Format (*.png;*.jpg; *.GIF)|(*.png;*.jpg; *.GIF)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(ofd.FileName);
            }
        }
        private bool IsFull()
        {
            if (materialSingleLineTextField1.Text.Trim().Equals(string.Empty) || materialSingleLineTextField2.Text.Trim().Equals(string.Empty) || materialSingleLineTextField3.Text.Trim().Equals(string.Empty) || textBox4.Text.Trim().Equals(string.Empty) || materialSingleLineTextField4.Text.Trim().Equals(string.Empty) || materialSingleLineTextField5.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Fields are required:", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private Branch GetBranch()
        {
            Branch branch = new Branch();
            branch.BranchId = (this.IsUpdated) ? this.Id : 0;
            branch.BranchName = materialSingleLineTextField1.Text;
            branch.Email = materialSingleLineTextField2.Text;
            branch.Website = materialSingleLineTextField3.Text;
            branch.AddressLine = textBox4.Text;
            branch.BranchImage = ((pictureBox.Image == null) ? null : Images.ImageManipulation.GetPhoto(pictureBox));
            branch.Telephone = materialSingleLineTextField4.Text;
            branch.CityId = Convert.ToInt32(comboBoxCITY.SelectedValue);
            branch.DistrictId = Convert.ToInt32(comboBoxDISTRICT.SelectedValue);
            branch.PostCode = materialSingleLineTextField5.Text;
            branch.CreatedBy = LoggedInSettings.LoggedInUser.UserName;
            return branch;
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void materialFlatButtonSave_Click(object sender, EventArgs e)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            try
            {
                if (IsFull())
                {
                    if (this.IsUpdated)
                    {

                        db.SaveOrUpdate("UpdateBranchRecords", GetBranch());
                        MessageBox.Show("Record has been updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ManageBranch manage = new ManageBranch();
                        manage.ShowDialog();
                    }
                    else
                    {
                        db.SaveOrUpdate("AddNewBranches", GetBranch());
                        MessageBox.Show("Record has been added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ManageBranch manage = new ManageBranch();
                        manage.ShowDialog();
                    }
                }
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("!Error:" + ex.Message.ToString());
            }
        }

        private void materialFlatButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard board = new DashBoard();
            board.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
