using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeManagementSystem
{    
    
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\-local-;Initial Catalog=cafe24;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignPge_Click(object sender, EventArgs e)
        {
            LoginForm loginFrm = new LoginForm();
            loginFrm.Show();

            this.Hide();
        }
        public bool emptyfields()
        {
            if (txtUserNameReg.Text == "" || txtPassReg.Text == "" || txtConfmPassReg.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void chkShowPassReg_CheckedChanged(object sender, EventArgs e)
        {
            txtPassReg.PasswordChar = chkShowPassReg.Checked ? '\0' : '*';
            txtConfmPassReg.PasswordChar = chkShowPassReg.Checked ? '\0' : '*';
        }

        private void btnSignUpReg_Click(object sender, EventArgs e)
        {
            if(emptyfields())
            {
                MessageBox.Show("All fileds are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectUserName = "SELECT * FROM administration WHERE admin_name = @usern";

                        using (SqlCommand checkUsername = new SqlCommand(selectUserName, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", txtUserNameReg.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string username = txtUserNameReg.Text.Substring(0,1).ToUpper() + txtUserNameReg.Text.Substring(1);  
                                MessageBox.Show(username + " is already taken.", "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else if (txtPassReg.Text != txtConfmPassReg.Text)
                            {
                                MessageBox.Show("The Password doesn't match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(txtPassReg.Text.Length < 8)
                            {
                                MessageBox.Show("The Password length minimum had the the 8 Caharecters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO administration (admin_name,admin_password,profile_image,admin_role,admin_status,date_reg) "+
                                    "VALUES (@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", txtUserNameReg.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txtPassReg.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", "");
                                    cmd.Parameters.AddWithValue("@role", "Cashier");
                                    cmd.Parameters.AddWithValue("@status", "Approval");
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginFrm = new LoginForm();
                                    loginFrm.Show();

                                    this.Hide();
                                }
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed" + ex, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
