namespace PhoneWarehouse.Views
{
    partial class CustomerView
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
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Viewdata = new DataGridView();
            id_customer = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            txtAddress = new TextBox();
            label4 = new Label();
            cbGender = new ComboBox();
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
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1180, 38);
            label5.Name = "label5";
            label5.Size = new Size(130, 36);
            label5.TabIndex = 19;
            label5.Text = "Giới tính";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(1002, 36);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(163, 41);
            txtPhoneNumber.TabIndex = 17;
            txtPhoneNumber.Validating += txtPhoneNumber_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(585, 34);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 41);
            txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(256, 34);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(135, 41);
            txtLastName.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(842, 34);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 14;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(397, 32);
            label2.Name = "label2";
            label2.Size = new Size(199, 45);
            label2.TabIndex = 13;
            label2.Text = "Tên khách hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 12;
            label1.Text = "Họ khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_customer, LastName, FirstName, PhoneNumber, Gender, address });
            Viewdata.Location = new Point(-4, 102);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1910, 801);
            Viewdata.TabIndex = 18;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_customer
            // 
            id_customer.DataPropertyName = "id";
            id_customer.HeaderText = "ID";
            id_customer.MinimumWidth = 6;
            id_customer.Name = "id_customer";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Họ khách hàng";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Tên khách hàng";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Số điện thoại";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // address
            // 
            address.DataPropertyName = "address";
            address.HeaderText = "Địa chhỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(1490, 36);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 41);
            txtAddress.TabIndex = 23;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1387, 38);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 22;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 15F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(1295, 36);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(74, 43);
            cbGender.TabIndex = 24;
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
            groupBox1.Location = new Point(-4, 880);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 153);
            groupBox1.TabIndex = 45;
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
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(cbGender);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Viewdata);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtPhoneNumber;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView Viewdata;
        private TextBox txtAddress;
        private Label label4;
        private ComboBox cbGender;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label6;
        private DataGridViewTextBoxColumn id_customer;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn address;
    }
}