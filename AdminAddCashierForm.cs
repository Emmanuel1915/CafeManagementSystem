using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CafeManagementSystem
{

    public partial class AdminAddCashierForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\-local-;Initial Catalog=cafe24;Integrated Security=True");

        public AdminAddCashierForm()
        {
            InitializeComponent();

            DisplayAddUsersData();
        }

        public void DisplayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.userListDate();

            dataGridView1.DataSource = listData;
        }

        public bool emptyfields()
        {
            if (adminAddUser_name.Text == "" || adminAddUser_password.Text == "" || cmbadminAddUser_role.Text == "" || cmbadminAddUser_status.Text == "" || administrator_imageview.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnadminAddUser_Add_Click(object sender, EventArgs e)
        {
            if (emptyfields())
            {
                MessageBox.Show("The fields must be filled.!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    string SelectUser = "SELECT * FROM administration WHERE admin_name=@usern";

                    using (SqlCommand checkuser = new SqlCommand(SelectUser, connect))
                    {
                        checkuser.Parameters.AddWithValue("@usern", adminAddUser_name.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("The Entered User has been Registered already!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            string insertData = "INSERT INTO administration (admin_name,admin_password,profile_image,admin_role,admin_status,date_reg)"
                                + "VALUES (@usern , @Password, @image , @role, @status, @date)";
                            DateTime today = DateTime.Today;

                            string path = Path.Combine(@"C:\Users\ASUS\source\repos\CafeManagementSystem\CafeManagementSystem\Use_Directory\" + adminAddUser_name.Text.Trim()+ ".jpg");
                            string directoryPath = Path.GetDirectoryName(path);

                            if(!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);   
                            }

                            File.Copy(administrator_imageview.ImageLocation, path, true);

                            using (SqlCommand checkinsert = new SqlCommand(insertData, connect))
                            {
                                checkinsert.Parameters.AddWithValue("@usern", adminAddUser_name.Text.Trim());
                                checkinsert.Parameters.AddWithValue("@Password", adminAddUser_password.Text.Trim());
                                checkinsert.Parameters.AddWithValue("@image", path);
                                checkinsert.Parameters.AddWithValue("@role", cmbadminAddUser_role.Text.Trim());
                                checkinsert.Parameters.AddWithValue("@status", cmbadminAddUser_status.Text.Trim());
                                checkinsert.Parameters.AddWithValue("@date", today);

                                checkinsert.ExecuteNonQuery();

                                MessageBox.Show("User Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Connection was failed due to following Reason : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog filer = new OpenFileDialog();
                filer.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if(filer.ShowDialog() == DialogResult.OK)
                {
                    imagePath = filer.FileName;
                    administrator_imageview.ImageLocation = imagePath; 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Connection was failed due to following Reason : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}
