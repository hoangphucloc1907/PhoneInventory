namespace PhoneWarehouse.Views
{
    partial class CategoryView
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
            id_category = new DataGridViewTextBoxColumn();
            categorycode = new DataGridViewTextBoxColumn();
            categoryname = new DataGridViewTextBoxColumn();
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
            txtCategoryCode = new TextBox();
            label1 = new Label();
            txtCategoryName = new TextBox();
            label2 = new Label();
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
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_category, categorycode, categoryname });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 200);
            Viewdata.Margin = new Padding(5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1135);
            Viewdata.TabIndex = 28;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_category
            // 
            id_category.DataPropertyName = "id";
            id_category.HeaderText = "ID";
            id_category.MinimumWidth = 6;
            id_category.Name = "id_category";
            // 
            // categorycode
            // 
            categorycode.DataPropertyName = "categorycode";
            categorycode.HeaderText = "Mã danh mục";
            categorycode.MinimumWidth = 6;
            categorycode.Name = "categorycode";
            // 
            // categoryname
            // 
            categoryname.DataPropertyName = "categoryname";
            categoryname.HeaderText = "Tên danh mục";
            categoryname.MinimumWidth = 6;
            categoryname.Name = "categoryname";
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
            groupBox1.Location = new Point(0, 1335);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 194);
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
            btnX.Location = new Point(2232, 68);
            btnX.Margin = new Padding(5);
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
            btnSearch.Location = new Point(2338, 63);
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
            txtSearch.Location = new Point(1715, 60);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(601, 78);
            txtSearch.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1103, 48);
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
            btnClear.Location = new Point(784, 48);
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
            btnDelete.Location = new Point(449, 48);
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
            btnSave.Location = new Point(113, 48);
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
            label6.Location = new Point(1439, 55);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(266, 91);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCategoryCode);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtCategoryName);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 200);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.Font = new Font("Segoe UI", 15F);
            txtCategoryCode.Location = new Point(388, 70);
            txtCategoryCode.Margin = new Padding(5);
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(394, 61);
            txtCategoryCode.TabIndex = 29;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(32, 68);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 70);
            label1.TabIndex = 27;
            label1.Text = "Mã danh mục";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 15F);
            txtCategoryName.Location = new Point(1104, 70);
            txtCategoryName.Margin = new Padding(5);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(410, 61);
            txtCategoryName.TabIndex = 30;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(805, 68);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 64);
            label2.TabIndex = 28;
            label2.Text = "Tên danh mục";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "CategoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhMuc";
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
        private DataGridViewTextBoxColumn id_category;
        private DataGridViewTextBoxColumn categorycode;
        private DataGridViewTextBoxColumn categoryname;
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
        private TextBox txtCategoryCode;
        private Label label1;
        private TextBox txtCategoryName;
        private Label label2;
    }
}