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
            Viewdata = new DataGridView();
            id_customer = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnX = new Button();
            btnClose = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSave = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            cbGender = new ComboBox();
            txtAddress = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
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
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_customer, LastName, FirstName, PhoneNumber, Gender, address });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 240);
            Viewdata.Margin = new Padding(5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1100);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnX);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1340);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 189);
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
            btnX.Location = new Point(2066, 76);
            btnX.Margin = new Padding(5);
            btnX.Name = "btnX";
            btnX.Size = new Size(55, 69);
            btnX.TabIndex = 25;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1002, 56);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(250, 104);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(2144, 75);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 74);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(668, 52);
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
            btnDelete.Location = new Point(348, 56);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 104);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(1650, 71);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(484, 78);
            txtSearch.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(12, 56);
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
            label6.Location = new Point(1395, 59);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(266, 91);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbGender);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPhoneNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 240);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 15F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(1819, 58);
            cbGender.Margin = new Padding(5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(170, 62);
            cbGender.TabIndex = 34;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(1092, 146);
            txtAddress.Margin = new Padding(5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(420, 61);
            txtAddress.TabIndex = 33;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1598, 58);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 58);
            label5.TabIndex = 31;
            label5.Text = "Giới tính";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 15F);
            txtPhoneNumber.Location = new Point(378, 143);
            txtPhoneNumber.Margin = new Padding(5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(308, 61);
            txtPhoneNumber.TabIndex = 30;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 72);
            label1.TabIndex = 25;
            label1.Text = "Họ khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(378, 58);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(308, 61);
            txtFirstName.TabIndex = 29;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(1092, 55);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(420, 61);
            txtLastName.TabIndex = 28;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(28, 130);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 66);
            label3.TabIndex = 27;
            label3.Text = "Số điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(760, 45);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 72);
            label2.TabIndex = 26;
            label2.Text = "Tên khách hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(760, 143);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 58);
            label4.TabIndex = 32;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
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
        private Label label6;
        private DataGridViewTextBoxColumn id_customer;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn address;
        private GroupBox groupBox2;
        private ComboBox cbGender;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtPhoneNumber;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}