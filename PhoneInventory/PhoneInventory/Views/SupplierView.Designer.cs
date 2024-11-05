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
            Viewdata = new DataGridView();
            id_supplier = new DataGridViewTextBoxColumn();
            supplierCode = new DataGridViewTextBoxColumn();
            supplierName = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnX = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClose = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierCode = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
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
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_supplier, supplierCode, supplierName, address, PhoneNumber });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 200);
            Viewdata.Margin = new Padding(5, 5, 5, 5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1063);
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
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1263);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 266);
            groupBox1.TabIndex = 48;
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
            btnX.Location = new Point(2089, 134);
            btnX.Margin = new Padding(5);
            btnX.Name = "btnX";
            btnX.Size = new Size(45, 63);
            btnX.TabIndex = 25;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(2204, 129);
            btnSearch.Margin = new Padding(5);
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
            txtSearch.Location = new Point(1625, 121);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(521, 78);
            txtSearch.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1020, 106);
            btnClose.Margin = new Padding(5);
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
            btnClear.Location = new Point(701, 106);
            btnClear.Margin = new Padding(5);
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
            btnDelete.Location = new Point(366, 106);
            btnDelete.Margin = new Padding(5);
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
            btnSave.Location = new Point(30, 106);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 104);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(1349, 116);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(266, 91);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(txtPhoneNumber);
            groupBox2.Controls.Add(txtSupplierName);
            groupBox2.Controls.Add(txtSupplierCode);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 200);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(1424, 74);
            txtAddress.Margin = new Padding(5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(341, 61);
            txtAddress.TabIndex = 43;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(2121, 75);
            txtPhoneNumber.Margin = new Padding(5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(262, 61);
            txtPhoneNumber.TabIndex = 41;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 15F);
            txtSupplierName.Location = new Point(864, 71);
            txtSupplierName.Margin = new Padding(5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(303, 61);
            txtSupplierName.TabIndex = 40;
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Font = new Font("Segoe UI", 15F);
            txtSupplierCode.Location = new Point(289, 71);
            txtSupplierCode.Margin = new Padding(5);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(270, 61);
            txtSupplierCode.TabIndex = 39;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1824, 72);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 66);
            label3.TabIndex = 38;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(627, 63);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 72);
            label2.TabIndex = 37;
            label2.Text = "Tên NCC";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(30, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 72);
            label1.TabIndex = 36;
            label1.Text = "Mã NCC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1243, 72);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 58);
            label4.TabIndex = 42;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SupplierView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "SupplierView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhaCungCap";
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
        private DataGridViewTextBoxColumn id_supplier;
        private DataGridViewTextBoxColumn supplierCode;
        private DataGridViewTextBoxColumn supplierName;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtSupplierName;
        private TextBox txtSupplierCode;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}