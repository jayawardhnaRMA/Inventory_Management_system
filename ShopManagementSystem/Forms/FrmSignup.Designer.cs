namespace warehouse.ShopManagementSystem.Forms
{
    partial class FrmSignup
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
            btnBackLogin = new Button();
            btnRegister = new Button();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            Password = new Label();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnClear = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnBackLogin
            // 
            btnBackLogin.BackColor = Color.DarkBlue;
            btnBackLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBackLogin.ForeColor = SystemColors.ButtonHighlight;
            btnBackLogin.Location = new Point(965, 503);
            btnBackLogin.Margin = new Padding(4, 3, 4, 3);
            btnBackLogin.Name = "btnBackLogin";
            btnBackLogin.Size = new Size(118, 33);
            btnBackLogin.TabIndex = 15;
            btnBackLogin.Text = "LOGIN";
            btnBackLogin.UseVisualStyleBackColor = false;
            btnBackLogin.Click += btnBackLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkBlue;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(542, 503);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 33);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFullName
            // 
            txtFullName.ForeColor = SystemColors.ActiveCaption;
            txtFullName.Location = new Point(782, 246);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 30);
            txtFullName.TabIndex = 13;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.ActiveCaption;
            txtUsername.Location = new Point(782, 167);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 30);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(611, 334);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 10;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(580, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(6, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 606);
            panel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(672, 368);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(118, 33);
            button3.TabIndex = 20;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnClear_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(701, 275);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 30);
            textBox3.TabIndex = 19;
            textBox3.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(86, 427);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 76);
            label1.TabIndex = 1;
            label1.Text = "Inventory\r\nManagement";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(701, 204);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 31);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.what_is_inventory_management_techniques_practices_benefits___1_;
            pictureBox1.Location = new Point(44, 47);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(519, 275);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 17;
            label9.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(519, 148);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 23);
            label8.TabIndex = 16;
            label8.Text = "FullName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 98);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 9;
            label6.Text = "Username";
            // 
            // button2
            // 
            button2.Location = new Point(848, 368);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 33);
            button2.TabIndex = 15;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnBackLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 204);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 23);
            label7.TabIndex = 10;
            label7.Text = "Role";
            // 
            // button1
            // 
            button1.Location = new Point(506, 368);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 14;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegister_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(701, 98);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 30);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += txtUsername_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(701, 148);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 30);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += txtFullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(734, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 50);
            label2.TabIndex = 2;
            label2.Text = "SIGN UP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(584, 250);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 16;
            label5.Text = "FullName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(598, 412);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(85, 23);
            Password.TabIndex = 17;
            Password.Text = "Password";
            // 
            // cmbRole
            // 
            cmbRole.ForeColor = SystemColors.ActiveCaption;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(782, 324);
            cmbRole.Margin = new Padding(4, 3, 4, 3);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(188, 31);
            cmbRole.TabIndex = 18;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(786, 404);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 30);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            //
            // chkShowPassword
            //
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(786, 442);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(165, 27);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkBlue;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(758, 503);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 33);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_48;
            pictureBox2.Location = new Point(1099, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1166, 613);
            Controls.Add(pictureBox2);
            Controls.Add(chkShowPassword);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(cmbRole);
            Controls.Add(Password);
            Controls.Add(label5);
            Controls.Add(btnBackLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSignup";
            Load += FrmSignup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackLogin;
        private Button btnRegister;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label Password;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnClear;
        private Button button3;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Button button2;
        private Label label7;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
    }
}