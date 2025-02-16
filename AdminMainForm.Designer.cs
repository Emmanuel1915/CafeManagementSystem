namespace CafeManagementSystem
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            close = new Label();
            panel1 = new Panel();
            adminAddCashierForm1 = new AdminAddCashierForm();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            btnCustomer = new Button();
            btnAddProducts = new Button();
            btnAddCashier = new Button();
            btnDashbord = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminAddCashierForm2 = new AdminAddCashierForm();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(964, 9);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 31;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(adminAddCashierForm1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 41);
            panel1.TabIndex = 32;
            // 
            // adminAddCashierForm1
            // 
            adminAddCashierForm1.Location = new Point(215, 41);
            adminAddCashierForm1.Name = "adminAddCashierForm1";
            adminAddCashierForm1.Size = new Size(900, 755);
            adminAddCashierForm1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 32;
            label1.Text = "Me Too cafe Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnCustomer);
            panel2.Controls.Add(btnAddProducts);
            panel2.Controls.Add(btnAddCashier);
            panel2.Controls.Add(btnDashbord);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 527);
            panel2.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Peru;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveBorder;
            label5.Location = new Point(47, 128);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 40;
            label5.Text = "Admin's Portal";
            // 
            // btnCustomer
            // 
            btnCustomer.FlatStyle = FlatStyle.Popup;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(21, 344);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(157, 43);
            btnCustomer.TabIndex = 38;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddProducts
            // 
            btnAddProducts.FlatStyle = FlatStyle.Popup;
            btnAddProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProducts.Location = new Point(21, 295);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(157, 43);
            btnAddProducts.TabIndex = 37;
            btnAddProducts.Text = "Add Products";
            btnAddProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddCashier
            // 
            btnAddCashier.FlatStyle = FlatStyle.Popup;
            btnAddCashier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCashier.Location = new Point(21, 246);
            btnAddCashier.Name = "btnAddCashier";
            btnAddCashier.Size = new Size(157, 43);
            btnAddCashier.TabIndex = 36;
            btnAddCashier.Text = "Add Cashier";
            btnAddCashier.UseVisualStyleBackColor = true;
            // 
            // btnDashbord
            // 
            btnDashbord.FlatStyle = FlatStyle.Popup;
            btnDashbord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashbord.Location = new Point(21, 197);
            btnDashbord.Name = "btnDashbord";
            btnDashbord.Size = new Size(157, 43);
            btnDashbord.TabIndex = 34;
            btnDashbord.Text = "Dashboard";
            btnDashbord.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Peru;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(130, 166);
            label4.Name = "label4";
            label4.Size = new Size(39, 16);
            label4.TabIndex = 35;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Peru;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(19, 163);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 34;
            label3.Text = "User Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminAddCashierForm2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(215, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 527);
            panel3.TabIndex = 34;
            // 
            // adminAddCashierForm2
            // 
            adminAddCashierForm2.Location = new Point(0, 0);
            adminAddCashierForm2.Name = "adminAddCashierForm2";
            adminAddCashierForm2.Size = new Size(773, 524);
            adminAddCashierForm2.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(21, 457);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 43);
            btnLogout.TabIndex = 42;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 568);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label close;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button btnCustomer;
        private Button btnAddProducts;
        private Button btnAddCashier;
        private Button btnDashbord;
        private Label label5;
        private Panel panel3;
        private AdminAddCashierForm adminAddCashierForm1;
        private AdminAddCashierForm adminAddCashierForm2;
        private Button btnLogout;
    }
}