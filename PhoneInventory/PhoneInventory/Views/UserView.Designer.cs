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
            radioEmp = new RadioButton();
            radioAdmin = new RadioButton();
            cbGender = new ComboBox();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            txtAddress = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label3 = new Label();
            label10 = new Label();
            label8 = new Label();
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
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_user, UserName, Password, LastName, FirstName, PhoneNumber, address, Gender, role });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 271);
            Viewdata.Margin = new Padding(5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1066);
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
            groupBox1.Location = new Point(0, 1337);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 192);
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
            btnX.Location = new Point(2112, 74);
            btnX.Margin = new Padding(5);
            btnX.Name = "btnX";
            btnX.Size = new Size(55, 49);
            btnX.TabIndex = 25;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(2210, 69);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(188, 54);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(1647, 46);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(553, 78);
            txtSearch.TabIndex = 23;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1068, 54);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(250, 84);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(749, 54);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 84);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(414, 54);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 84);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(78, 54);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 84);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(1371, 61);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(266, 71);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioEmp);
            groupBox2.Controls.Add(radioAdmin);
            groupBox2.Controls.Add(cbGender);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 271);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // radioEmp
            // 
            radioEmp.AutoSize = true;
            radioEmp.Font = new Font("Segoe UI", 15F);
            radioEmp.Location = new Point(2133, 198);
            radioEmp.Margin = new Padding(5);
            radioEmp.Name = "radioEmp";
            radioEmp.Size = new Size(226, 58);
            radioEmp.TabIndex = 60;
            radioEmp.TabStop = true;
            radioEmp.Text = "Employee";
            radioEmp.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.Font = new Font("Segoe UI", 15F);
            radioAdmin.Location = new Point(2133, 140);
            radioAdmin.Margin = new Padding(5);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(171, 58);
            radioAdmin.TabIndex = 59;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 15F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGender.Location = new Point(1538, 175);
            cbGender.Margin = new Padding(5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(212, 62);
            cbGender.TabIndex = 58;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(311, 177);
            txtPhone.Margin = new Padding(5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(267, 61);
            txtPhone.TabIndex = 57;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(2133, 58);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(319, 61);
            txtFirstName.TabIndex = 56;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F);
            txtAddress.Location = new Point(867, 177);
            txtAddress.Margin = new Padding(5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(286, 61);
            txtAddress.TabIndex = 52;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1814, 59);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(291, 58);
            label5.TabIndex = 50;
            label5.Text = "Tên nhân viên";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(1538, 54);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(212, 61);
            txtLastName.TabIndex = 49;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15F);
            txtUserName.Location = new Point(284, 48);
            txtUserName.Margin = new Padding(5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(294, 61);
            txtUserName.TabIndex = 47;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(629, 181);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 58);
            label4.TabIndex = 51;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(867, 54);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 61);
            txtPassword.TabIndex = 48;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(629, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 72);
            label2.TabIndex = 45;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(53, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 72);
            label1.TabIndex = 44;
            label1.Text = "Tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(31, 174);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(270, 72);
            label9.TabIndex = 53;
            label9.Text = "Số điện thoại";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1242, 48);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 66);
            label3.TabIndex = 46;
            label3.Text = "Họ nhân viên";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(1242, 172);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(208, 66);
            label10.TabIndex = 55;
            label10.Text = "Giới tính";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1814, 169);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(260, 72);
            label8.TabIndex = 54;
            label8.Text = "Phân quyền";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
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
        private DataGridViewTextBoxColumn id_user;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn role;
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
        private RadioButton radioEmp;
        private RadioButton radioAdmin;
        private ComboBox cbGender;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label3;
        private Label label10;
        private Label label8;
    }
}