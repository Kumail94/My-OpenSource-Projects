using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Sets_and_DataTables
{

    public partial class DataTables : Form
    {
        private DataTable table;
        private SqlDataAdapter adapter;
        private DataView _viewz;
        private SqlCommandBuilder cmb;
        private SqlCommand cmd;
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString);
        private DataColumn columns;    
        public DataTables()
        {
            InitializeComponent();
         
        }
        private void SortGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void DataTables_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetRecords();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
        }
        private DataTable GetRecords()
        {
            table = new DataTable();
            columns = new DataColumn();
            columns.ColumnName = "Id";
            columns.DataType = typeof(int);
            columns.AutoIncrement = true;
            table.Columns.Add(columns);
                using (cmd = new SqlCommand("sp_Records", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            
        return table;
        }
        private void NameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NameRadioButton.Checked)
            {
                _viewz = new DataView();
                _viewz = table.DefaultView;
                _viewz.Sort = "Name ASC";
            }
            else
            {
                _viewz = new DataView();
                _viewz = table.DefaultView;
                _viewz.Sort = "Salary ASC";
            }
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _viewz = new DataView();
            _viewz = table.DefaultView;
            _viewz.RowFilter = "Name LIKE '%" + SearchTextBox.Text + "%'";

            //var data = from myRows in table.AsEnumerable()
            //           where myRows.Field<string>("Name").Contains(SearchTextBox.Text)
            //           select myRows;
            //if (data.Any())
            //{
            //    dataGridView.DataSource = data.CopyToDataTable<DataRow>();
            //}
            //else
            //{
            //    MessageBox.Show("Searched Record does not exists in Grid View:", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Record.?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(result == DialogResult.Yes)
            {
                int index = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dataGridView.Rows.RemoveAt(index);
                cmb = new SqlCommandBuilder(adapter);
                adapter.Update(table);
                MessageBox.Show("Record has been deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var rowIndex = dataGridView.HitTest(e.X, e.Y);
                dataGridView.ClearSelection();
                dataGridView.Rows[rowIndex.RowIndex].Selected = true;
            }
        }
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Information emp = new Employee_Information();
            emp.ShowDialog();
            if (emp.IsCanceled == false)
            {
                table.Rows.Add(null, emp.EmployeeName, emp.Department, emp.ContactNo, emp.Salary);
                cmb = new SqlCommandBuilder(adapter);
                adapter.Update(table);
                MessageBox.Show("New Record is Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Information employee = new Employee_Information();
            employee.IsUpdate = true;
            int rowIndex = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataRow rows = table.Rows[rowIndex];
            employee.EmployeeName = rows["Name"].ToString();
            employee.Department = rows["Department"].ToString();
            employee.ContactNo = rows["Contacts"].ToString();
            employee.Salary = Convert.ToDecimal(rows["Salary"].ToString());
            employee.ShowDialog();
            if (!employee.IsCanceled)
            {
                rows["Name"] = employee.EmployeeName;
                rows["Department"] = employee.Department;
                rows["Contacts"] = employee.ContactNo;
                rows["Salary"] = employee.Salary;

                cmb = new SqlCommandBuilder(adapter);
                adapter.Update(table);
                MessageBox.Show("Record is Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LinkLabe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DataRows_and_Views obj = new DataRows_and_Views();
            obj.ShowDialog();
        }

        private void ContextStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}