namespace PhoneWarehouse.Views
{
    partial class UserView
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
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            Viewdata = new DataGridView();
            id_user = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            cbGender = new ComboBox();
            radioAdmin = new RadioButton();
            radioEmp = new RadioButton();
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
            txtAddress.Location = new Point(617, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 41);
            txtAddress.TabIndex = 35;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(1191, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 41);
            txtLastName.TabIndex = 30;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.Location = new Point(277, 37);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 41);
            txtUserName.TabIndex = 28;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(493, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 45);
            label2.TabIndex = 26;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_user, UserName, Password, LastName, FirstName, PhoneNumber, address, Gender, role });
            Viewdata.Location = new Point(-4, 181);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1910, 709);
            Viewdata.TabIndex = 31;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_user
            // 
            id_user.DataPropertyName = "id";
            id_user.HeaderText = "ID";
            id_user.MinimumWidth = 6;
            id_user.Name = "id_user";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Tài khoản";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Họ nhân viên";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Tên nhân viên";
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
            // address
            // 
            address.DataPropertyName = "address";
            address.HeaderText = "Địa chhỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // role
            // 
            role.DataPropertyName = "Role";
            role.HeaderText = "Phân quyền";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(147, 37);
            label1.Name = "label1";
            label1.Size = new Size(136, 45);
            label1.TabIndex = 25;
            label1.Text = "Tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(506, 109);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 34;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(617, 39);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 41);
            txtPassword.TabIndex = 29;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1033, 41);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 27;
            label3.Text = "Họ nhân viên";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1348, 105);
            label8.Name = "label8";
            label8.Size = new Size(160, 45);
            label8.TabIndex = 37;
            label8.Text = "Phân quyền";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(117, 109);
            label9.Name = "label9";
            label9.Size = new Size(166, 45);
            label9.TabIndex = 36;
            label9.Text = "Số điện thoại";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1070, 104);
            label10.Name = "label10";
            label10.Size = new Size(128, 41);
            label10.TabIndex = 38;
            label10.Text = "Giới tính";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1329, 42);
            label5.Name = "label5";
            label5.Size = new Size(179, 36);
            label5.TabIndex = 32;
            label5.Text = "Tên nhân viên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(1514, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 41);
            txtFirstName.TabIndex = 39;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(277, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 41);
            txtPhone.TabIndex = 40;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 15F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(1191, 105);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(132, 43);
            cbGender.TabIndex = 41;
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.Font = new Font("Segoe UI", 15F);
            radioAdmin.Location = new Point(1514, 84);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(109, 39);
            radioAdmin.TabIndex = 42;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioEmp
            // 
            radioEmp.AutoSize = true;
            radioEmp.Font = new Font("Segoe UI", 15F);
            radioEmp.Location = new Point(1514, 129);
            radioEmp.Name = "radioEmp";
            radioEmp.Size = new Size(145, 39);
            radioEmp.TabIndex = 43;
            radioEmp.TabStop = true;
            radioEmp.Text = "Employee";
            radioEmp.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(-4, 866);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 177);
            groupBox1.TabIndex = 44;
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
            btnDelete.Click += btnDelete_Click_1;
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
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(Viewdata);
            Controls.Add(radioEmp);
            Controls.Add(radioAdmin);
            Controls.Add(cbGender);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private Label label2;
        private DataGridView Viewdata;
        private Label label1;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private ComboBox cbGender;
        private RadioButton radioAdmin;
        private RadioButton radioEmp;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label6;
        private DataGridViewTextBoxColumn id_user;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn role;
        private Button btnX;
    }
}