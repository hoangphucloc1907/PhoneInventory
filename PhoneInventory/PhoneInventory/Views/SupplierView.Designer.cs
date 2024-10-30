namespace PhoneWarehouse.Views
{
    partial class SupplierView
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
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierCode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Viewdata = new DataGridView();
            id_supplier = new DataGridViewTextBoxColumn();
            supplierCode = new DataGridViewTextBoxColumn();
            supplierName = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnX = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClose = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(989, 21);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(431, 41);
            txtAddress.TabIndex = 35;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(1615, 23);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(163, 41);
            txtPhoneNumber.TabIndex = 30;
            txtPhoneNumber.Validating += txtPhoneNumber_Validating;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 15F);
            txtSupplierName.Location = new Point(618, 18);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(239, 41);
            txtSupplierName.TabIndex = 29;
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Font = new Font("Segoe UI", 15F);
            txtSupplierCode.Location = new Point(223, 18);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(168, 41);
            txtSupplierCode.TabIndex = 28;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1455, 21);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 27;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(397, 16);
            label2.Name = "label2";
            label2.Size = new Size(215, 45);
            label2.TabIndex = 26;
            label2.Text = "Tên nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 25;
            label1.Text = "Mã nhà cung cấp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_supplier, supplierCode, supplierName, address, PhoneNumber });
            Viewdata.Location = new Point(-4, 89);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1910, 801);
            Viewdata.TabIndex = 31;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_supplier
            // 
            id_supplier.DataPropertyName = "id";
            id_supplier.HeaderText = "ID";
            id_supplier.MinimumWidth = 6;
            id_supplier.Name = "id_supplier";
            // 
            // supplierCode
            // 
            supplierCode.DataPropertyName = "supplierCode";
            supplierCode.HeaderText = "Mã nhà cung cấp";
            supplierCode.MinimumWidth = 6;
            supplierCode.Name = "supplierCode";
            // 
            // supplierName
            // 
            supplierName.DataPropertyName = "supplierName";
            supplierName.HeaderText = "Tên nhà cung cấp";
            supplierName.MinimumWidth = 6;
            supplierName.Name = "supplierName";
            // 
            // address
            // 
            address.DataPropertyName = "address";
            address.HeaderText = "Địa chhỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Số điện thoại";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(878, 20);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 34;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(-4, 874);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 166);
            groupBox1.TabIndex = 47;
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
            btnClose.Location = new Point(657, 61);
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
            btnClear.Location = new Point(461, 61);
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
            btnDelete.Location = new Point(255, 61);
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
            btnSave.Location = new Point(48, 61);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 65);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(1056, 67);
            label6.Name = "label6";
            label6.Size = new Size(164, 57);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Viewdata);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Supplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaCungCap";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtSupplierName;
        private TextBox txtSupplierCode;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView Viewdata;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label6;
        private DataGridViewTextBoxColumn id_supplier;
        private DataGridViewTextBoxColumn supplierCode;
        private DataGridViewTextBoxColumn supplierName;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn PhoneNumber;
    }
}