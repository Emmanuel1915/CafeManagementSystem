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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CafeManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\-local-;Initial Catalog=cafe24;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisterPge_Click(object sender, EventArgs e)
        {
            Form1 regFrm = new Form1();
            regFrm.Show();

            this.Hide();
        }

        public bool emptyfileds()
        {
            if (txtUserNameSign.Text == "" || txtPassSign.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void chkShowPassSign_CheckedChanged(object sender, EventArgs e)
        {
            txtPassSign.PasswordChar = chkShowPassSign.Checked ? '\0' : '*';
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(emptyfileds())
            {
                MessageBox.Show("The fields must be filled.!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectUserName = "SELECT * FROM administration WHERE admin_name = @usern and admin_password = @pass";
                        using (SqlCommand checkUsername = new SqlCommand(selectUserName, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", txtUserNameSign.Text.Trim());
                            checkUsername.Parameters.AddWithValue("@pass", txtPassSign.Text.Trim());
                            checkUsername.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {                                
                                MessageBox.Show("login Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminMainForm adminForm = new AdminMainForm();
                                adminForm.Show();

                                this.Hide();
                            }
                            else 
                            {
                                string username = txtUserNameSign.Text.Substring(0, 1).ToUpper() + txtUserNameSign.Text.Substring(1);
                                MessageBox.Show(username + "is not matched with Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed."+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
