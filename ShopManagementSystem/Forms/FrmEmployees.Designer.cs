namespace warehouse.NewFolder.Forms
{
    partial class FrmEmployees
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
            label1 = new Label();
            dgvEmployees = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtEmployeeName = new TextBox();
            txtPhone = new TextBox();
            txtSearch = new TextBox();
            txtEmail = new TextBox();
            cmbGender = new ComboBox();
            dtpHireDate = new DateTimePicker();
            chkIsActive = new CheckBox();
            txtJobTitle = new TextBox();
            label9 = new Label();
            txtSalary = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnLoad = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(569, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEES";
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(46, 88);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1187, 199);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(130, 322);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(601, 319);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(75, 372);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(854, 323);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 6;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(453, 365);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 7;
            label7.Text = "Job Title";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(844, 365);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 8;
            label8.Text = "Hire Date";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(226, 319);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(314, 27);
            txtEmployeeName.TabIndex = 9;
            txtEmployeeName.TextChanged += txtEmployeeName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(156, 365);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(219, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(893, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(314, 27);
            txtSearch.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(919, 316);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(684, 311);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(85, 28);
            cmbGender.TabIndex = 13;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(947, 360);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(250, 27);
            dtpHireDate.TabIndex = 14;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkIsActive.Location = new Point(963, 423);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(87, 24);
            chkIsActive.TabIndex = 15;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(550, 362);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(219, 27);
            txtJobTitle.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(514, 426);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 17;
            label9.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(591, 423);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(277, 27);
            txtSalary.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkBlue;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(194, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 38);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkBlue;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(405, 480);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 38);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkBlue;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(615, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 38);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button3_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkBlue;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(834, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 22;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button4_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(765, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 38);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button5_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkBlue;
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(1032, 480);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 38);
            btnLoad.TabIndex = 24;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_back_button_32;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_48;
            pictureBox2.Location = new Point(1213, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1273, 538);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSalary);
            Controls.Add(label9);
            Controls.Add(txtJobTitle);
            Controls.Add(chkIsActive);
            Controls.Add(dtpHireDate);
            Controls.Add(cmbGender);
            Controls.Add(txtEmail);
            Controls.Add(txtSearch);
            Controls.Add(txtPhone);
            Controls.Add(txtEmployeeName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvEmployees);
            Controls.Add(label1);
            Name = "FrmEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmployees";
            Load += FrmEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmployees;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmployeeName;
        private TextBox txtPhone;
        private TextBox txtSearch;
        private TextBox txtEmail;
        private ComboBox cmbGender;
        private DateTimePicker dtpHireDate;
        private CheckBox chkIsActive;
        private TextBox txtJobTitle;
        private Label label9;
        private TextBox txtSalary;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private Button btnLoad;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}