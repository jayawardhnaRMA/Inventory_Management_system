namespace warehouse.NewFolder.Forms
{
    partial class FrmCustomers
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
            dgvCustomers = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnLoad = new Button();
            txtPhone = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(560, 8);
            label1.Name = "label1";
            label1.Size = new Size(242, 50);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMERS";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(21, 112);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1235, 286);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 429);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(352, 429);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(637, 429);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(960, 429);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(85, 426);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(216, 27);
            txtCustomerName.TabIndex = 9;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(695, 426);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1036, 426);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(843, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(413, 27);
            txtSearch.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkBlue;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(235, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 38);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkBlue;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(436, 484);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 38);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkBlue;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(656, 484);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 38);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkBlue;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(854, 484);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 17;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(716, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 38);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkBlue;
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(1068, 484);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 38);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(416, 425);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(136, 27);
            txtPhone.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_48;
            pictureBox2.Location = new Point(1204, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_back_button_32;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            //
            // FrmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1280, 533);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(txtPhone);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCustomers);
            Controls.Add(label1);
            Name = "FrmCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCustomers";
            Load += FrmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCustomers;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private Button btnLoad;
        private TextBox txtPhone;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}