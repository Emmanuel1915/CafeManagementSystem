namespace CafeManagementSystem
{
    partial class AdminAddCashierForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            administrator_imageview = new PictureBox();
            btnimport = new Button();
            btnadminAddUser_delete = new Button();
            btnadminAddUser_update = new Button();
            btnadminAddUser_clear = new Button();
            btnadminAddUser_Add = new Button();
            cmbadminAddUser_status = new ComboBox();
            cmbadminAddUser_role = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            adminAddUser_password = new TextBox();
            label4 = new Label();
            adminAddUser_name = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)administrator_imageview).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnimport);
            panel1.Controls.Add(btnadminAddUser_delete);
            panel1.Controls.Add(btnadminAddUser_update);
            panel1.Controls.Add(btnadminAddUser_clear);
            panel1.Controls.Add(btnadminAddUser_Add);
            panel1.Controls.Add(cmbadminAddUser_status);
            panel1.Controls.Add(cmbadminAddUser_role);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(adminAddUser_password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(adminAddUser_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 473);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(administrator_imageview);
            panel3.Location = new Point(72, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(90, 95);
            panel3.TabIndex = 14;
            // 
            // administrator_imageview
            // 
            administrator_imageview.Location = new Point(3, 3);
            administrator_imageview.Name = "administrator_imageview";
            administrator_imageview.Size = new Size(84, 89);
            administrator_imageview.SizeMode = PictureBoxSizeMode.StretchImage;
            administrator_imageview.TabIndex = 2;
            administrator_imageview.TabStop = false;
            // 
            // btnimport
            // 
            btnimport.BackColor = Color.Peru;
            btnimport.FlatStyle = FlatStyle.Popup;
            btnimport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnimport.ForeColor = Color.White;
            btnimport.Location = new Point(77, 149);
            btnimport.Name = "btnimport";
            btnimport.Size = new Size(82, 32);
            btnimport.TabIndex = 13;
            btnimport.Text = "IMPORT";
            btnimport.UseVisualStyleBackColor = false;
            btnimport.Click += btnimport_Click;
            // 
            // btnadminAddUser_delete
            // 
            btnadminAddUser_delete.BackColor = Color.Peru;
            btnadminAddUser_delete.FlatStyle = FlatStyle.Popup;
            btnadminAddUser_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadminAddUser_delete.ForeColor = Color.White;
            btnadminAddUser_delete.Location = new Point(24, 409);
            btnadminAddUser_delete.Name = "btnadminAddUser_delete";
            btnadminAddUser_delete.Size = new Size(95, 38);
            btnadminAddUser_delete.TabIndex = 12;
            btnadminAddUser_delete.Text = "DELETE";
            btnadminAddUser_delete.UseVisualStyleBackColor = false;
            // 
            // btnadminAddUser_update
            // 
            btnadminAddUser_update.BackColor = Color.Peru;
            btnadminAddUser_update.FlatStyle = FlatStyle.Popup;
            btnadminAddUser_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadminAddUser_update.ForeColor = Color.White;
            btnadminAddUser_update.Location = new Point(143, 355);
            btnadminAddUser_update.Name = "btnadminAddUser_update";
            btnadminAddUser_update.Size = new Size(95, 38);
            btnadminAddUser_update.TabIndex = 11;
            btnadminAddUser_update.Text = "UPDATE";
            btnadminAddUser_update.UseVisualStyleBackColor = false;
            // 
            // btnadminAddUser_clear
            // 
            btnadminAddUser_clear.BackColor = Color.Peru;
            btnadminAddUser_clear.FlatStyle = FlatStyle.Popup;
            btnadminAddUser_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadminAddUser_clear.ForeColor = Color.White;
            btnadminAddUser_clear.Location = new Point(143, 409);
            btnadminAddUser_clear.Name = "btnadminAddUser_clear";
            btnadminAddUser_clear.Size = new Size(95, 38);
            btnadminAddUser_clear.TabIndex = 10;
            btnadminAddUser_clear.Text = "CLEAR";
            btnadminAddUser_clear.UseVisualStyleBackColor = false;
            // 
            // btnadminAddUser_Add
            // 
            btnadminAddUser_Add.BackColor = Color.Peru;
            btnadminAddUser_Add.FlatStyle = FlatStyle.Popup;
            btnadminAddUser_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadminAddUser_Add.ForeColor = Color.White;
            btnadminAddUser_Add.Location = new Point(24, 355);
            btnadminAddUser_Add.Name = "btnadminAddUser_Add";
            btnadminAddUser_Add.Size = new Size(95, 38);
            btnadminAddUser_Add.TabIndex = 9;
            btnadminAddUser_Add.Text = "ADD";
            btnadminAddUser_Add.UseVisualStyleBackColor = false;
            btnadminAddUser_Add.Click += btnadminAddUser_Add_Click;
            // 
            // cmbadminAddUser_status
            // 
            cmbadminAddUser_status.BackColor = SystemColors.Menu;
            cmbadminAddUser_status.FormattingEnabled = true;
            cmbadminAddUser_status.Items.AddRange(new object[] { "active", "approved", "applied" });
            cmbadminAddUser_status.Location = new Point(98, 300);
            cmbadminAddUser_status.Name = "cmbadminAddUser_status";
            cmbadminAddUser_status.Size = new Size(155, 23);
            cmbadminAddUser_status.TabIndex = 8;
            // 
            // cmbadminAddUser_role
            // 
            cmbadminAddUser_role.BackColor = SystemColors.Menu;
            cmbadminAddUser_role.FormattingEnabled = true;
            cmbadminAddUser_role.Items.AddRange(new object[] { "admin", "manager", "cashier", "waiter", "cleaner", "master" });
            cmbadminAddUser_role.Location = new Point(98, 268);
            cmbadminAddUser_role.Name = "cmbadminAddUser_role";
            cmbadminAddUser_role.Size = new Size(155, 23);
            cmbadminAddUser_role.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 300);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 268);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Role :";
            // 
            // adminAddUser_password
            // 
            adminAddUser_password.BackColor = SystemColors.Menu;
            adminAddUser_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddUser_password.Location = new Point(98, 235);
            adminAddUser_password.Name = "adminAddUser_password";
            adminAddUser_password.Size = new Size(155, 25);
            adminAddUser_password.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 236);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // adminAddUser_name
            // 
            adminAddUser_name.BackColor = SystemColors.Menu;
            adminAddUser_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddUser_name.Location = new Point(98, 204);
            adminAddUser_name.Name = "adminAddUser_name";
            adminAddUser_name.Size = new Size(155, 25);
            adminAddUser_name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 205);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "User Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 1;
            label1.Text = "User Form :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(304, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 483);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Peru;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(7, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(422, 411);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 0;
            label2.Text = "User's Data";
            // 
            // AdminAddCashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddCashierForm";
            Size = new Size(740, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)administrator_imageview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private ComboBox cmbadminAddUser_status;
        private ComboBox cmbadminAddUser_role;
        private Label label7;
        private Label label5;
        private TextBox adminAddUser_password;
        private Label label4;
        private TextBox adminAddUser_name;
        private Label label3;
        private Button btnadminAddUser_delete;
        private Button btnadminAddUser_update;
        private Button btnadminAddUser_clear;
        private Button btnadminAddUser_Add;
        private DataGridView dataGridView1;
        private PictureBox administrator_imageview;
        private Button btnimport;
        private Panel panel3;
    }
}
