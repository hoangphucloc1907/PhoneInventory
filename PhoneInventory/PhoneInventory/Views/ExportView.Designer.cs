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
            txtTotal = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            label9 = new Label();
            dateExportDate = new DateTimePicker();
            label8 = new Label();
            txtExportId = new TextBox();
            label1 = new Label();
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
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            cbProductId = new ComboBox();
            groupBox1 = new GroupBox();
            btnX = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClose = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label2 = new Label();
            label4 = new Label();
            cbEmployee = new ComboBox();
            cbCustomer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 15F);
            txtTotal.Location = new Point(1543, 82);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(246, 41);
            txtTotal.TabIndex = 55;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.ButtonHighlight;
            txtUnitPrice.Font = new Font("Segoe UI", 15F);
            txtUnitPrice.Location = new Point(1112, 79);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(277, 41);
            txtUnitPrice.TabIndex = 54;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(662, 80);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(277, 41);
            txtQuantity.TabIndex = 51;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(11, 82);
            label9.Name = "label9";
            label9.Size = new Size(180, 38);
            label9.TabIndex = 49;
            label9.Text = "Tên sản phẩm";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateExportDate
            // 
            dateExportDate.Font = new Font("Segoe UI", 15F);
            dateExportDate.Format = DateTimePickerFormat.Short;
            dateExportDate.Location = new Point(1543, 21);
            dateExportDate.Name = "dateExportDate";
            dateExportDate.Size = new Size(170, 41);
            dateExportDate.TabIndex = 48;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1424, 75);
            label8.Name = "label8";
            label8.Size = new Size(113, 42);
            label8.TabIndex = 47;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtExportId
            // 
            txtExportId.BackColor = SystemColors.ButtonHighlight;
            txtExportId.Font = new Font("Segoe UI", 15F);
            txtExportId.Location = new Point(177, 21);
            txtExportId.Name = "txtExportId";
            txtExportId.ReadOnly = true;
            txtExportId.Size = new Size(339, 41);
            txtExportId.TabIndex = 41;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(68, 13);
            label1.Name = "label1";
            label1.Size = new Size(114, 57);
            label1.TabIndex = 38;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_export, exportId, Employee, Customer, Date, nameProduct, Quantity, UnitPrice, Total });
            Viewdata.Location = new Point(-4, 145);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1910, 751);
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
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(522, 13);
            label3.Name = "label3";
            label3.Size = new Size(148, 57);
            label3.TabIndex = 40;
            label3.Text = "Người bán";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(998, 76);
            label6.Name = "label6";
            label6.Size = new Size(108, 44);
            label6.TabIndex = 45;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(541, 79);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 43;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1415, 20);
            label7.Name = "label7";
            label7.Size = new Size(132, 43);
            label7.TabIndex = 46;
            label7.Text = "Ngày bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProductId
            // 
            cbProductId.Font = new Font("Segoe UI", 15F);
            cbProductId.FormattingEnabled = true;
            cbProductId.Location = new Point(177, 78);
            cbProductId.Name = "cbProductId";
            cbProductId.Size = new Size(339, 43);
            cbProductId.TabIndex = 56;
            cbProductId.SelectedIndexChanged += cbProductId_SelectedIndexChanged;
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
            groupBox1.Location = new Point(-4, 872);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 166);
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
            btnX.Location = new Point(1674, 75);
            btnX.Name = "btnX";
            btnX.Size = new Size(34, 43);
            btnX.TabIndex = 25;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(1723, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 46);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(1226, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(491, 52);
            txtSearch.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(622, 59);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 65);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(426, 59);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 65);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(220, 59);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 65);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(13, 59);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 65);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1056, 67);
            label2.Name = "label2";
            label2.Size = new Size(164, 57);
            label2.TabIndex = 22;
            label2.Text = "Tìm kiếm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(967, 13);
            label4.Name = "label4";
            label4.Size = new Size(148, 57);
            label4.TabIndex = 58;
            label4.Text = "Khách hàng";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbEmployee
            // 
            cbEmployee.Font = new Font("Segoe UI", 15F);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(662, 19);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(277, 43);
            cbEmployee.TabIndex = 59;
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Segoe UI", 15F);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(1112, 19);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(277, 43);
            cbCustomer.TabIndex = 60;
            // 
            // Export
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(cbCustomer);
            Controls.Add(cbEmployee);
            Controls.Add(label4);
            Controls.Add(cbProductId);
            Controls.Add(txtTotal);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dateExportDate);
            Controls.Add(label8);
            Controls.Add(txtExportId);
            Controls.Add(label1);
            Controls.Add(Viewdata);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label7);
            Name = "Export";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockOut";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTotal;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Label label9;
        private DateTimePicker dateExportDate;
        private Label label8;
        private TextBox txtExportId;
        private Label label1;
        private DataGridView Viewdata;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private ComboBox cbProductId;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label2;
        private Label label4;
        private ComboBox cbEmployee;
        private ComboBox cbCustomer;
        private DataGridViewTextBoxColumn id_export;
        private DataGridViewTextBoxColumn exportId;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
    }
}