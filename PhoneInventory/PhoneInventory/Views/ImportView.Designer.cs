namespace PhoneWarehouse.Views
{
    partial class ImportView
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
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            txtImportId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id_import = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Tong = new DataGridViewTextBoxColumn();
            nameuser = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateImportDate = new DateTimePicker();
            label9 = new Label();
            txtProductId = new TextBox();
            txtQuantity = new TextBox();
            txtSupplierId = new TextBox();
            txtEmployeeId = new TextBox();
            txtUnitPrice = new TextBox();
            txtTotal = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(1160, 35);
            button4.Name = "button4";
            button4.Size = new Size(154, 65);
            button4.TabIndex = 15;
            button4.Text = "Clear All";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(964, 35);
            button3.Name = "button3";
            button3.Size = new Size(154, 65);
            button3.TabIndex = 14;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(551, 35);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(505, 110);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 21;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-4, 893);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 136);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(1719, 62);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1569, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1455, 42);
            label4.Name = "label4";
            label4.Size = new Size(123, 57);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(758, 35);
            button2.Name = "button2";
            button2.Size = new Size(154, 65);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtImportId
            // 
            txtImportId.Font = new Font("Segoe UI", 15F);
            txtImportId.Location = new Point(230, 26);
            txtImportId.Name = "txtImportId";
            txtImportId.Size = new Size(212, 41);
            txtImportId.TabIndex = 16;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(914, 18);
            label3.Name = "label3";
            label3.Size = new Size(148, 57);
            label3.TabIndex = 14;
            label3.Text = "Người nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(446, 26);
            label2.Name = "label2";
            label2.Size = new Size(174, 40);
            label2.TabIndex = 13;
            label2.Text = "Nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(121, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 57);
            label1.TabIndex = 12;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_import, ID, Tong, nameuser, Day, nameProduct, Quantity, Amount, Name });
            dataGridView1.Location = new Point(-4, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 725);
            dataGridView1.TabIndex = 20;
            // 
            // id_import
            // 
            id_import.HeaderText = "ID";
            id_import.MinimumWidth = 6;
            id_import.Name = "id_import";
            // 
            // ID
            // 
            ID.HeaderText = "Số phiếu";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Tong
            // 
            Tong.HeaderText = "Nhà cung cấp";
            Tong.MinimumWidth = 6;
            Tong.Name = "Tong";
            // 
            // nameuser
            // 
            nameuser.HeaderText = "Người nhập";
            nameuser.MinimumWidth = 6;
            nameuser.Name = "nameuser";
            // 
            // Day
            // 
            Day.HeaderText = "Ngày nhập";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            // 
            // nameProduct
            // 
            nameProduct.HeaderText = "Tên sản phẩm";
            nameProduct.MinimumWidth = 6;
            nameProduct.Name = "nameProduct";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            Amount.HeaderText = "Đơn giá";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // Name
            // 
            Name.HeaderText = "Tổng giá";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(954, 103);
            label6.Name = "label6";
            label6.Size = new Size(108, 44);
            label6.TabIndex = 24;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1417, 23);
            label7.Name = "label7";
            label7.Size = new Size(139, 43);
            label7.TabIndex = 26;
            label7.Text = "Ngày nhập";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1443, 102);
            label8.Name = "label8";
            label8.Size = new Size(113, 42);
            label8.TabIndex = 28;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateImportDate
            // 
            dateImportDate.Font = new Font("Segoe UI", 15F);
            dateImportDate.Format = DateTimePickerFormat.Short;
            dateImportDate.Location = new Point(1551, 26);
            dateImportDate.Name = "dateImportDate";
            dateImportDate.Size = new Size(170, 41);
            dateImportDate.TabIndex = 30;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(55, 109);
            label9.Name = "label9";
            label9.Size = new Size(180, 38);
            label9.TabIndex = 31;
            label9.Text = "Tên sản phẩm";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 15F);
            txtProductId.Location = new Point(230, 109);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(212, 41);
            txtProductId.TabIndex = 32;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(626, 107);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(212, 41);
            txtQuantity.TabIndex = 33;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Segoe UI", 15F);
            txtSupplierId.Location = new Point(626, 26);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(212, 41);
            txtSupplierId.TabIndex = 34;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 15F);
            txtEmployeeId.Location = new Point(1066, 25);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(246, 41);
            txtEmployeeId.TabIndex = 35;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 15F);
            txtUnitPrice.Location = new Point(1066, 103);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(246, 41);
            txtUnitPrice.TabIndex = 36;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(1551, 105);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(246, 41);
            txtTotal.TabIndex = 37;
            // 
            // Phieunhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtTotal);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtEmployeeId);
            Controls.Add(txtSupplierId);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductId);
            Controls.Add(label9);
            Controls.Add(dateImportDate);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtImportId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockIn";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button1;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox txtImportId;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Label label4;
        private Button button5;
        private Label label8;
        private DateTimePicker dateImportDate;
        private Label label9;
        private TextBox txtProductId;
        private TextBox txtQuantity;
        private TextBox txtSupplierId;
        private TextBox txtEmployeeId;
        private TextBox txtUnitPrice;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn id_import;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tong;
        private DataGridViewTextBoxColumn nameuser;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Name;
    }
}