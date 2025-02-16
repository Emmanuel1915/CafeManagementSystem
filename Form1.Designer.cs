namespace CafeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtConfmPassReg = new TextBox();
            label3 = new Label();
            label7 = new Label();
            chkShowPassReg = new CheckBox();
            btnSignUpReg = new Button();
            txtPassReg = new TextBox();
            label4 = new Label();
            txtUserNameReg = new TextBox();
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnSignPge = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtConfmPassReg
            // 
            txtConfmPassReg.BackColor = SystemColors.Control;
            txtConfmPassReg.Cursor = Cursors.IBeam;
            txtConfmPassReg.Location = new Point(377, 305);
            txtConfmPassReg.Name = "txtConfmPassReg";
            txtConfmPassReg.PasswordChar = '*';
            txtConfmPassReg.Size = new Size(244, 23);
            txtConfmPassReg.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(377, 281);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 29;
            label3.Text = "Confirm Password :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(377, 144);
            label7.Name = "label7";
            label7.Size = new Size(105, 18);
            label7.TabIndex = 28;
            label7.Text = "User Name :";
            // 
            // chkShowPassReg
            // 
            chkShowPassReg.AutoSize = true;
            chkShowPassReg.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassReg.ForeColor = Color.DarkRed;
            chkShowPassReg.Location = new Point(377, 334);
            chkShowPassReg.Name = "chkShowPassReg";
            chkShowPassReg.Size = new Size(120, 18);
            chkShowPassReg.TabIndex = 27;
            chkShowPassReg.Text = "Show Password";
            chkShowPassReg.UseVisualStyleBackColor = true;
            chkShowPassReg.CheckedChanged += chkShowPassReg_CheckedChanged;
            // 
            // btnSignUpReg
            // 
            btnSignUpReg.BackColor = Color.FromArgb(111, 78, 55);
            btnSignUpReg.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUpReg.ForeColor = Color.PeachPuff;
            btnSignUpReg.Location = new Point(377, 374);
            btnSignUpReg.Name = "btnSignUpReg";
            btnSignUpReg.Size = new Size(120, 42);
            btnSignUpReg.TabIndex = 28;
            btnSignUpReg.Text = "SIGN UP";
            btnSignUpReg.UseVisualStyleBackColor = false;
            btnSignUpReg.Click += btnSignUpReg_Click;
            // 
            // txtPassReg
            // 
            txtPassReg.BackColor = SystemColors.Control;
            txtPassReg.Cursor = Cursors.IBeam;
            txtPassReg.Location = new Point(377, 239);
            txtPassReg.Name = "txtPassReg";
            txtPassReg.PasswordChar = '*';
            txtPassReg.Size = new Size(244, 23);
            txtPassReg.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(377, 215);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 24;
            label4.Text = "Password :";
            // 
            // txtUserNameReg
            // 
            txtUserNameReg.BackColor = SystemColors.Control;
            txtUserNameReg.Cursor = Cursors.IBeam;
            txtUserNameReg.Location = new Point(377, 169);
            txtUserNameReg.Name = "txtUserNameReg";
            txtUserNameReg.Size = new Size(244, 23);
            txtUserNameReg.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(377, 75);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 22;
            label2.Text = "REGISTER";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(659, 10);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 30;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSignPge);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 450);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(39, 24);
            label6.Name = "label6";
            label6.Size = new Size(256, 22);
            label6.TabIndex = 9;
            label6.Text = "ME TOO Cafe Management";
            // 
            // btnSignPge
            // 
            btnSignPge.BackColor = SystemColors.Control;
            btnSignPge.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignPge.ForeColor = Color.SaddleBrown;
            btnSignPge.Location = new Point(40, 384);
            btnSignPge.Name = "btnSignPge";
            btnSignPge.Size = new Size(235, 42);
            btnSignPge.TabIndex = 29;
            btnSignPge.Text = "SIGN IN";
            btnSignPge.UseVisualStyleBackColor = false;
            btnSignPge.Click += btnSignPge_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(80, 363);
            label5.Name = "label5";
            label5.Size = new Size(159, 14);
            label5.TabIndex = 9;
            label5.Text = "Already have an Account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(txtConfmPassReg);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(chkShowPassReg);
            Controls.Add(btnSignUpReg);
            Controls.Add(txtPassReg);
            Controls.Add(label4);
            Controls.Add(txtUserNameReg);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfmPassReg;
        private Label label3;
        private Label label7;
        private CheckBox chkShowPassReg;
        private Button btnSignUpReg;
        private TextBox txtPassReg;
        private Label label4;
        private TextBox txtUserNameReg;
        private Label label2;
        private Label close;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnSignPge;
        private Label label5;
    }
}
