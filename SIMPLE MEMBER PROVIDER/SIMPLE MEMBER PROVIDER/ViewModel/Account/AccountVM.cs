using SIMPLE_MEMBER_PROVIDER.Models;
using SIMPLE_MEMBER_PROVIDER.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace SIMPLE_MEMBER_PROVIDER.ViewModel.Account
{
    public class AccountVM
    {
        public static List<SelectListItem> GetAllItems(int RoleId)
        {
            List<SelectListItem> roles = new List<SelectListItem>();
            using (SqlConnection conn = new SqlConnection(AppSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UserRoles", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        SelectListItem items = new SelectListItem();
                        items.Value = reader["RoleName"].ToString();
                        items.Text = reader["RoleName"].ToString();
                        roles.Add(items);
                    }

                }
            }
            return roles;
        }
        public static UserProfile GetProfile(int currentUserId)
        {
            UserProfile profile = new UserProfile();
            using (SqlConnection sql = new SqlConnection(AppSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("GetUserProfile", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Open();
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    profile.FullName = reader["FullName"].ToString();
                    profile.Email = reader["Email"].ToString();
                    profile.Address = reader["Address"].ToString();
                }
            }
            return profile;
        }
        public static void UpdateProfile(UserProfile user)
        {
            using (SqlConnection sql = new SqlConnection(AppSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateUserProfile", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Open();

                    cmd.Parameters.AddWithValue("@UserId", WebSecurity.CurrentUserId);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<UserLists> GetUserLists()
        {
            List<UserLists> users = new List<UserLists>();
            using(SqlConnection conn = new SqlConnection(AppSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllUserLists", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserLists list = new UserLists();
                        list.UserId = Convert.ToInt32(reader["Id"]);
                        list.UserName = reader["UserName"].ToString();
                        list.FullName = reader["FullName"].ToString();
                        list.Email = reader["Email"].ToString();
                        list.Address = reader["Address"].ToString();

                        users.Add(list);
                    }
                }
                return users;
            }
        }
    }
}