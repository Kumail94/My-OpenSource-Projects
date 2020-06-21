using Custom_Framework;
using Office_Mangement_Systems.App_Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Office_Mangement_Systems.ListData
{
    class LoadingData
    {
        public static void LoadDataIntoDataGridView(DataGridView dtg, string storedProcedure)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            dtg.DataSource = db.GetDataList(storedProcedure);
            dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.MultiSelect = false;

        }
        public static void LoadDataInComboBox(ComboBox combo , string storedProcedure , DBParameter parameter)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            combo.DataSource = db.GetDataList(storedProcedure , parameter);
            combo.DisplayMember = "Description";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        public static void LoadDataInComboBox(ComboBox combo, string storedProcedure, DBParameter[] parameter)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            combo.DataSource = db.GetDataList(storedProcedure, parameter);
            combo.DisplayMember = "Description";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public static void LoadDataInComboBox(ComboBox combo, string storedProcedure)
        {
            SqlDBServer db = new SqlDBServer(ConnectionStrings.DBConnection());
            combo.DataSource = db.GetDataList(storedProcedure);
            combo.DisplayMember = "Description";
            combo.ValueMember = "ID";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

    }
}
