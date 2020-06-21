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
    public partial class DataRows_and_Views : Form
    {
        private DataTable table;
        private DataRow _rows;
        private int index;
        public DataRows_and_Views()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DataTables obj = new DataTables();
            obj.ShowDialog();
        }


        private void DataRows_and_Views_Load(object sender, EventArgs e)
        {
            table = GetRecords();
            FirstNameTextBox.DataBindings.Add("Text", table, "First Name");
            LastNameTextBox.DataBindings.Add("Text", table, "Last Name");
        }

        private DataTable GetRecords()
        {
            table = new DataTable();
            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");

            table.Rows.Add("Kumail" ,"Ali");
            table.Rows.Add("Zaigham" , "Rizvi");
            table.Rows.Add("Akhlaque", "Mughal");
            table.Rows.Add("Shoaib", "Syed");
            table.Rows.Add("Sikandar", "Mahmood");

            return table;
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            _rows = table.Rows[0];
            FirstNameTextBox.Text = _rows["First Name"].ToString();
            LastNameTextBox.Text = _rows["Last Name"].ToString();
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if(index < 0)
            {
                _rows = table.Rows[table.Rows.Count - 1];
                index = table.Rows.Count - 1;
            }
            else
            {
                _rows = table.Rows[index];
                index --;
            }
            FirstNameTextBox.Text = _rows["First Name"].ToString();
            LastNameTextBox.Text = _rows["Last Name"].ToString();

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(index < table.Rows.Count-1)
            {
              
                _rows = table.Rows[index];
                index += 1;
            }
            else
            {
                _rows = table.Rows[table.Rows.Count - 1];
                index = 0;
            }
            FirstNameTextBox.Text = _rows["First Name"].ToString();
            LastNameTextBox.Text = _rows["Last Name"].ToString();

        }
        private void LastButton_Click(object sender, EventArgs e)
        {
            _rows = table.Rows[table.Rows.Count - 1];
            FirstNameTextBox.Text = _rows["First Name"].ToString();
            LastNameTextBox.Text = _rows["Last Name"].ToString();
        }
    }
}
