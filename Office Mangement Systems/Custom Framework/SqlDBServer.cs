using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace Custom_Framework
{
    public class SqlDBServer
    {
        private string _connString;
        public SqlDBServer(string connString)
        {
            this._connString = connString;
        }
        public object GetScalarValue(string procedureName)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        //Method Overloading
        public object GetScalarValue(string procedureName, DBParameter parameter)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
        //Method Overloading
        public object GetScalarValue(string procedureName, DBParameter[] parameter)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    foreach (var item in parameter)
                    {
                        cmd.Parameters.AddWithValue(item.Parameter, item.Value);
                    }
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }

        public DataTable GetDataList(string procedureName)
        {
           System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
        public DataTable GetDataList(string procedureName , DBParameter parameter)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
        public DataTable GetDataList(string procedureName , DBParameter [] parameters)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Parameter, item.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public void SaveOrUpdate(string storedProcedure , object obj)
        {
            using(SqlConnection conn = new SqlConnection(_connString))
            {
                using(SqlCommand cmd = new SqlCommand(storedProcedure , conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags);

                    foreach (var item in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + item.Name , item.GetValue(obj , null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
