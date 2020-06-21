using Custom_Framework;
using Office_Mangement_Systems.App_Settings;
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
    public partial class Login :MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public bool IsUpdated { get; set; }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            if (IsValid())
            {
                bool isLoginCorrectDetails = Convert.ToBoolean(db.GetScalarValue("sp_UserLogin", GetParameters()));

                if (isLoginCorrectDetails)
                {
                    GetLoginSettings();

                    MessageBox.Show("Login Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashBoard board = new DashBoard();
                    board.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("User or Password is In-Valid", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void GetLoginSettings()
        {
            LoggedInSettings.LoggedInUser.UserName = materialSingleLineTextField1.Text.Trim().ToString();
        }

        private DBParameter[] GetParameters()
        {
            List<DBParameter> parameters = new List<DBParameter>();
            DBParameter p1 = new DBParameter();
            p1.Parameter = "@UserName";
            p1.Value = materialSingleLineTextField1.Text;
            parameters.Add(p1);
            DBParameter p2 = new DBParameter();
            p2.Parameter = "@Password";
            p2.Value = materialSingleLineTextField2.Text;
            parameters.Add(p2);
            return parameters.ToArray();
        }
        private bool IsValid()
        {
           if(materialSingleLineTextField1.Text.Trim().Equals(string.Empty) || materialSingleLineTextField2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Fields are required!", "Message" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
