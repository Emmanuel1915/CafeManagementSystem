namespace CafeManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label7 = new Label();
            chkShowPassSign = new CheckBox();
            btnSignIn = new Button();
            txtPassSign = new TextBox();
            label4 = new Label();
            txtUserNameSign = new TextBox();
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnRegisterPge = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(372, 173);
            label7.Name = "label7";
            label7.Size = new Size(105, 18);
            label7.TabIndex = 37;
            label7.Text = "User Name :";
            // 
            // chkShowPassSign
            // 
            chkShowPassSign.AutoSize = true;
            chkShowPassSign.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassSign.ForeColor = Color.DarkRed;
            chkShowPassSign.Location = new Point(372, 297);
            chkShowPassSign.Name = "chkShowPassSign";
            chkShowPassSign.Size = new Size(120, 18);
            chkShowPassSign.TabIndex = 36;
            chkShowPassSign.Text = "Show Password";
            chkShowPassSign.UseVisualStyleBackColor = true;
            chkShowPassSign.CheckedChanged += chkShowPassSign_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(111, 78, 55);
            btnSignIn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.PeachPuff;
            btnSignIn.Location = new Point(372, 363);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(120, 42);
            btnSignIn.TabIndex = 35;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassSign
            // 
            txtPassSign.BackColor = SystemColors.Control;
            txtPassSign.Cursor = Cursors.IBeam;
            txtPassSign.Location = new Point(372, 268);
            txtPassSign.Name = "txtPassSign";
            txtPassSign.PasswordChar = '*';
            txtPassSign.Size = new Size(244, 23);
            txtPassSign.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(372, 244);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 33;
            label4.Text = "Password :";
            // 
            // txtUserNameSign
            // 
            txtUserNameSign.BackColor = SystemColors.Control;
            txtUserNameSign.Cursor = Cursors.IBeam;
            txtUserNameSign.Location = new Point(372, 198);
            txtUserNameSign.Name = "txtUserNameSign";
            txtUserNameSign.Size = new Size(244, 23);
            txtUserNameSign.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(372, 80);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 31;
            label2.Text = "LOG IN";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(639, 10);
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
            panel1.Controls.Add(btnRegisterPge);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 421);
            panel1.TabIndex = 29;
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
            // btnRegisterPge
            // 
            btnRegisterPge.BackColor = SystemColors.Control;
            btnRegisterPge.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterPge.ForeColor = Color.SaddleBrown;
            btnRegisterPge.Location = new Point(39, 363);
            btnRegisterPge.Name = "btnRegisterPge";
            btnRegisterPge.Size = new Size(235, 42);
            btnRegisterPge.TabIndex = 10;
            btnRegisterPge.Text = "REGISTER";
            btnRegisterPge.UseVisualStyleBackColor = false;
            btnRegisterPge.Click += btnRegisterPge_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(79, 342);
            label5.Name = "label5";
            label5.Size = new Size(143, 14);
            label5.TabIndex = 9;
            label5.Text = "Don't have an Account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 421);
            Controls.Add(label7);
            Controls.Add(chkShowPassSign);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassSign);
            Controls.Add(label4);
            Controls.Add(txtUserNameSign);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private CheckBox chkShowPassSign;
        private Button btnSignIn;
        private TextBox txtPassSign;
        private Label label4;
        private TextBox txtUserNameSign;
        private Label label2;
        private Label close;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnRegisterPge;
        private Label label5;
    }
}