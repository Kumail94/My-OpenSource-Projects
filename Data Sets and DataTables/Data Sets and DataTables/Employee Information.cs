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
    public partial class Employee_Information : Form
    {
        public Employee_Information()
        {
            InitializeComponent();
        }
        private string name;
        private string depat;
        private string contact;
        private decimal salary;
        private bool isCanceled;
        private bool isUpdated;
        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return depat; }
            set { depat = value; }
        }
        public string ContactNo
        {
            get { return contact; }
            set { contact = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public bool IsCanceled
        {
            get { return isCanceled; }
            set { isCanceled = value; }
        }
         public bool IsUpdate
        {
            get { return isUpdated; }
            set { isUpdated = value; }
        }

        private void Employee_Information_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                SaveButton.Text = "Update";
                textBox1.Text = this.EmployeeName;
                textBox2.Text = this.Department;
                textBox3.Text = this.ContactNo;
                textBox4.Text = this.Salary.ToString();

                IsCanceled = false;
                this.EmployeeName = textBox1.Text.ToString();
                this.Department = textBox2.Text.ToString();
                this.ContactNo = textBox3.Text.ToString();
                this.Salary = Convert.ToDecimal(textBox4.Text.ToString());

            }
            else
            {
                SaveButton.Text = "Save";
            }
            
        }
        private bool IsValid()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field are required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.BackColor = Color.Yellow;
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field are required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.Yellow;
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field are required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.BackColor = Color.Yellow;
                textBox3.Focus();
                return false;
            }
            if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Field are required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.Yellow;
                textBox4.Focus();
                return false;
            }
            
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (isCanceled)
            {
                Application.Exit();
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Voice_Testing testing = new Voice_Testing();
            testing.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                IsCanceled = false;
                EmployeeName = this.textBox1.Text.ToString();
                Department = this.textBox2.Text.ToString();
                ContactNo = this.textBox3.Text.ToString();
                Salary = Convert.ToDecimal(this.textBox4.Text.ToString());
            }
            this.Close();
        }
    }
}
