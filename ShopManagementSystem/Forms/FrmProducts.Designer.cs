namespace warehouse.NewFolder.Forms
{
    partial class FrmProducts
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtReorderLevel = new TextBox();
            txtQuantity = new TextBox();
            txtSupplier = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnLoad = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(51, 124);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1203, 255);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 13);
            label1.Name = "label1";
            label1.Size = new Size(217, 50);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTS";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(123, 420);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(322, 30);
            txtProductName.TabIndex = 2;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(635, 420);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(273, 30);
            txtCategory.TabIndex = 3;
            txtCategory.TextChanged += txtCategory_TextChanged;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(537, 502);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(278, 30);
            txtReorderLevel.TabIndex = 4;
            txtReorderLevel.TextChanged += txtReorderLevel_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(156, 502);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(140, 30);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(984, 502);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(278, 30);
            txtSupplier.TabIndex = 6;
            txtSupplier.TextChanged += txtSupplier_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1052, 416);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 30);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(51, 427);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(537, 423);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(984, 423);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 10;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(51, 505);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(379, 505);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 12;
            label6.Text = "Recoder Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(893, 505);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 13;
            label7.Text = "Supplier";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(156, 575);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(382, 575);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 34);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(635, 575);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 34);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(873, 575);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 34);
            btnClear.TabIndex = 17;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(480, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 34);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(635, 78);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(619, 30);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Navy;
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(1078, 575);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(118, 34);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_back_button_32;
            pictureBox1.Location = new Point(22, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_48;
            pictureBox2.Location = new Point(1224, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1288, 621);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoad);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(txtSupplier);
            Controls.Add(txtQuantity);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtReorderLevel;
        private TextBox txtQuantity;
        private TextBox txtSupplier;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnLoad;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}