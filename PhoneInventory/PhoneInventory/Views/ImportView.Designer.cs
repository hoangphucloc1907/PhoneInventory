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
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txtTotal = new TextBox();
            txtUnitPrice = new TextBox();
            txtEmployeeId = new TextBox();
            txtSupplierId = new TextBox();
            txtQuantity = new TextBox();
            txtProductId = new TextBox();
            label9 = new Label();
            dateImportDate = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            txtImportId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_import, ID, Tong, nameuser, Day, nameProduct, Quantity, Amount, Name });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 239);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(2534, 1072);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1311);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 218);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(2331, 109);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(153, 46);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(2089, 113);
            textBox4.Margin = new Padding(5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 39);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1879, 81);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 91);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(1333, 68);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(250, 104);
            button4.TabIndex = 15;
            button4.Text = "Clear All";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(1014, 68);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(250, 104);
            button3.TabIndex = 14;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(680, 68);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(250, 104);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(343, 68);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(250, 104);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(txtEmployeeId);
            groupBox2.Controls.Add(txtSupplierId);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(txtProductId);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateImportDate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtImportId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 239);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(2171, 169);
            txtTotal.Margin = new Padding(5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(274, 61);
            txtTotal.TabIndex = 53;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 15F);
            txtUnitPrice.Location = new Point(1616, 163);
            txtUnitPrice.Margin = new Padding(5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(228, 61);
            txtUnitPrice.TabIndex = 52;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 15F);
            txtEmployeeId.Location = new Point(342, 148);
            txtEmployeeId.Margin = new Padding(5);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(245, 61);
            txtEmployeeId.TabIndex = 51;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Segoe UI", 15F);
            txtSupplierId.Location = new Point(947, 39);
            txtSupplierId.Margin = new Padding(5);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(275, 61);
            txtSupplierId.TabIndex = 50;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(947, 146);
            txtQuantity.Margin = new Padding(5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(275, 61);
            txtQuantity.TabIndex = 49;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 15F);
            txtProductId.Location = new Point(1616, 39);
            txtProductId.Margin = new Padding(5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(228, 61);
            txtProductId.TabIndex = 48;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(1332, 39);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(292, 61);
            label9.TabIndex = 47;
            label9.Text = "Tên sản phẩm";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateImportDate
            // 
            dateImportDate.Font = new Font("Segoe UI", 15F);
            dateImportDate.Format = DateTimePickerFormat.Short;
            dateImportDate.Location = new Point(2171, 47);
            dateImportDate.Margin = new Padding(5);
            dateImportDate.Name = "dateImportDate";
            dateImportDate.Size = new Size(274, 61);
            dateImportDate.TabIndex = 46;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1935, 163);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 67);
            label8.TabIndex = 45;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(667, 146);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 61);
            label5.TabIndex = 42;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImportId
            // 
            txtImportId.Font = new Font("Segoe UI", 15F);
            txtImportId.Location = new Point(329, 31);
            txtImportId.Margin = new Padding(5);
            txtImportId.Name = "txtImportId";
            txtImportId.Size = new Size(224, 61);
            txtImportId.TabIndex = 41;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(654, 31);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 64);
            label2.TabIndex = 39;
            label2.Text = "Nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(95, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 91);
            label1.TabIndex = 38;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(95, 133);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 91);
            label3.TabIndex = 40;
            label3.Text = "Người nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1343, 148);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 70);
            label6.TabIndex = 43;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1935, 39);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(226, 69);
            label7.TabIndex = 44;
            label7.Text = "Ngày nhập";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImportView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockIn";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_import;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tong;
        private DataGridViewTextBoxColumn nameuser;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Name;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox txtTotal;
        private TextBox txtUnitPrice;
        private TextBox txtEmployeeId;
        private TextBox txtSupplierId;
        private TextBox txtQuantity;
        private TextBox txtProductId;
        private Label label9;
        private DateTimePicker dateImportDate;
        private Label label8;
        private Label label5;
        private TextBox txtImportId;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}