using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeManagementSystem
{
    internal class AdminAddUsersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\-local-;Initial Catalog=cafe24;Integrated Security=True");

        public int ID { get; set; }
        public string Username{ set; get; }
        public string Password{ set; get; }
        public string Status { set; get; }
        public string Role { set; get; }
        public string DateRegister { set; get; }
        public List<AdminAddUsersData> userListDate()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM administration";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AdminAddUsersData userData = new AdminAddUsersData();
                            userData.ID = (int)reader["administrationID"];
                            userData.Username = reader["admin_name"].ToString();
                            userData.Password = reader["admin_password"].ToString();
                            userData.Status = reader["admin_status"].ToString();
                            userData.Role = reader["admin_role"].ToString();
                            userData.DateRegister = reader["date_reg"].ToString();

                            listData.Add(userData);
                        }

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection failed" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }

    }
}
