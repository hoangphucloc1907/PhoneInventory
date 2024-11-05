namespace PhoneWarehouse.Views
{
    partial class ExportView
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
            Viewdata = new DataGridView();
            id_export = new DataGridViewTextBoxColumn();
            exportId = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnX = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClose = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cbCustomer = new ComboBox();
            cbEmployee = new ComboBox();
            label4 = new Label();
            cbProductId = new ComboBox();
            txtTotal = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            dateExportDate = new DateTimePicker();
            label8 = new Label();
            txtExportId = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label3 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_export, exportId, Employee, Customer, Date, nameProduct, Quantity, UnitPrice, Total });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 285);
            Viewdata.Margin = new Padding(5, 5, 5, 5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1037);
            Viewdata.TabIndex = 42;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_export
            // 
            id_export.DataPropertyName = "id";
            id_export.HeaderText = "ID";
            id_export.MinimumWidth = 6;
            id_export.Name = "id_export";
            // 
            // exportId
            // 
            exportId.DataPropertyName = "ExportId";
            exportId.HeaderText = "Số phiếu";
            exportId.MinimumWidth = 6;
            exportId.Name = "exportId";
            // 
            // Employee
            // 
            Employee.DataPropertyName = "Employee";
            Employee.HeaderText = "Người bán";
            Employee.MinimumWidth = 6;
            Employee.Name = "Employee";
            // 
            // Customer
            // 
            Customer.DataPropertyName = "Customer";
            Customer.HeaderText = "Người mua";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Ngày bán";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // nameProduct
            // 
            nameProduct.DataPropertyName = "Product";
            nameProduct.HeaderText = "Tên sản phẩm";
            nameProduct.MinimumWidth = 6;
            nameProduct.Name = "nameProduct";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Đơn giá";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            // 
            // Total
            // 
            Total.DataPropertyName = "TotalPrice";
            Total.HeaderText = "Tổng giá";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnX);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1322);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(2534, 207);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            // 
            // btnX
            // 
            btnX.BackColor = SystemColors.Window;
            btnX.FlatAppearance.BorderColor = Color.White;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 15F);
            btnX.ForeColor = SystemColors.ControlText;
            btnX.Location = new Point(2720, 120);
            btnX.Margin = new Padding(5, 5, 5, 5);
            btnX.Name = "btnX";
            btnX.Size = new Size(55, 69);
            btnX.TabIndex = 25;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(2800, 120);
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 74);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(1708, 67);
            txtSearch.Margin = new Padding(5, 5, 5, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(795, 78);
            txtSearch.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1005, 49);
            btnClose.Margin = new Padding(5, 5, 5, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(250, 104);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(686, 49);
            btnClear.Margin = new Padding(5, 5, 5, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 104);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(352, 49);
            btnDelete.Margin = new Padding(5, 5, 5, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 104);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(15, 49);
            btnSave.Margin = new Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 104);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1432, 62);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 91);
            label2.TabIndex = 22;
            label2.Text = "Tìm kiếm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbCustomer);
            groupBox2.Controls.Add(cbEmployee);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbProductId);
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(txtUnitPrice);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(dateExportDate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtExportId);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 285);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Segoe UI", 15F);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(1470, 55);
            cbCustomer.Margin = new Padding(5);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(289, 62);
            cbCustomer.TabIndex = 76;
            // 
            // cbEmployee
            // 
            cbEmployee.Font = new Font("Segoe UI", 15F);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(246, 165);
            cbEmployee.Margin = new Padding(5);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(264, 62);
            cbEmployee.TabIndex = 75;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1220, 40);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(240, 84);
            label4.TabIndex = 74;
            label4.Text = "Khách hàng";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProductId
            // 
            cbProductId.Font = new Font("Segoe UI", 15F);
            cbProductId.FormattingEnabled = true;
            cbProductId.Location = new Point(852, 55);
            cbProductId.Margin = new Padding(5);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(290, 62);
            cbProductId.TabIndex = 73;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(2058, 170);
            txtTotal.Margin = new Padding(5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(275, 61);
            txtTotal.TabIndex = 72;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.ButtonHighlight;
            txtUnitPrice.Font = new Font("Segoe UI", 15F);
            txtUnitPrice.Location = new Point(1470, 166);
            txtUnitPrice.Margin = new Padding(5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(289, 61);
            txtUnitPrice.TabIndex = 71;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(852, 166);
            txtQuantity.Margin = new Padding(5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(255, 61);
            txtQuantity.TabIndex = 70;
            // 
            // dateExportDate
            // 
            dateExportDate.Font = new Font("Segoe UI", 15F);
            dateExportDate.Format = DateTimePickerFormat.Short;
            dateExportDate.Location = new Point(2059, 53);
            dateExportDate.Margin = new Padding(5);
            dateExportDate.Name = "dateExportDate";
            dateExportDate.Size = new Size(274, 61);
            dateExportDate.TabIndex = 68;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1850, 159);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 60);
            label8.TabIndex = 67;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtExportId
            // 
            txtExportId.BackColor = SystemColors.ButtonHighlight;
            txtExportId.Font = new Font("Segoe UI", 15F);
            txtExportId.Location = new Point(246, 55);
            txtExportId.Margin = new Padding(5);
            txtExportId.Name = "txtExportId";
            txtExportId.ReadOnly = true;
            txtExportId.Size = new Size(264, 61);
            txtExportId.TabIndex = 63;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(9, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 84);
            label1.TabIndex = 61;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1234, 161);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 63);
            label6.TabIndex = 65;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(576, 165);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 54);
            label5.TabIndex = 64;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(564, 53);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(292, 54);
            label9.TabIndex = 69;
            label9.Text = "Tên sản phẩm";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(9, 150);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 84);
            label3.TabIndex = 62;
            label3.Text = "Người bán";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1835, 51);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 62);
            label7.TabIndex = 66;
            label7.Text = "Ngày bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExportView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ExportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockOut";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView Viewdata;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label2;
        private DataGridViewTextBoxColumn id_export;
        private DataGridViewTextBoxColumn exportId;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox2;
        private ComboBox cbCustomer;
        private ComboBox cbEmployee;
        private Label label4;
        private ComboBox cbProductId;
        private TextBox txtTotal;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private DateTimePicker dateExportDate;
        private Label label8;
        private TextBox txtExportId;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label3;
        private Label label7;
    }
}