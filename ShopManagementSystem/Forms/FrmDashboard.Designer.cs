namespace warehouse.NewFolder.Forms
{
    partial class FrmDashboard
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
            btnProducts = new PictureBox();
            btnCustomers = new PictureBox();
            btnEmployees = new PictureBox();
            btnLogout = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 50);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.Click += label1_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ButtonHighlight;
            btnProducts.Image = Properties.Resources.icons8_products_64;
            btnProducts.Location = new Point(3, 0);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(182, 155);
            btnProducts.SizeMode = PictureBoxSizeMode.Zoom;
            btnProducts.TabIndex = 1;
            btnProducts.TabStop = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = SystemColors.ButtonHighlight;
            btnCustomers.Image = Properties.Resources.icons8_customers_100;
            btnCustomers.Location = new Point(3, 0);
            btnCustomers.Margin = new Padding(3, 4, 3, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(183, 149);
            btnCustomers.SizeMode = PictureBoxSizeMode.Zoom;
            btnCustomers.TabIndex = 2;
            btnCustomers.TabStop = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = SystemColors.ButtonHighlight;
            btnEmployees.Image = Properties.Resources.icons8_manager_48;
            btnEmployees.Location = new Point(3, 0);
            btnEmployees.Margin = new Padding(3, 4, 3, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(180, 152);
            btnEmployees.SizeMode = PictureBoxSizeMode.Zoom;
            btnEmployees.TabIndex = 3;
            btnEmployees.TabStop = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonHighlight;
            btnLogout.Image = Properties.Resources.icons8_login_48;
            btnLogout.Location = new Point(3, 0);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(183, 155);
            btnLogout.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogout.TabIndex = 4;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_48;
            pictureBox2.Location = new Point(1475, 14);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(48, 170);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 28;
            label2.Text = "PRODUCTS";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(38, 165);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 29;
            label3.Text = "CUSTOMERS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(43, 171);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 30;
            label4.Text = "EMPLOYEE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(64, 171);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 31;
            label5.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_close_window_48;
            pictureBox1.Location = new Point(1030, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(228, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 207);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(btnEmployees);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(228, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 207);
            panel2.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(btnCustomers);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(699, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 207);
            panel3.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(702, 328);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 207);
            panel4.TabIndex = 35;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1084, 545);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)btnProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox btnProducts;
        private PictureBox btnCustomers;
        private PictureBox btnEmployees;
        private PictureBox btnLogout;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}