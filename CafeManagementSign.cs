using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class CafeManagementSign : UserControl
    {
        public CafeManagementSign()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         public void btnRegisterPge_Click(object sender, EventArgs e)
        {
            Form1 regForm = new Form1();
            regForm.Show();

            this.Hide();

        }
    }
}
