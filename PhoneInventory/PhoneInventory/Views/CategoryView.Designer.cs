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
            txtCategoryCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCategoryName = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.Font = new Font("Segoe UI", 15F);
            txtCategoryCode.Location = new Point(579, 10);
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(244, 41);
            txtCategoryCode.TabIndex = 25;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(909, 9);
            label2.Name = "label2";
            label2.Size = new Size(190, 40);
            label2.TabIndex = 23;
            label2.Text = "Tên danh mục";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(401, 7);
            label1.Name = "label1";
            label1.Size = new Size(172, 44);
            label1.TabIndex = 22;
            label1.Text = "Mã danh mục";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 15F);
            txtCategoryName.Location = new Point(1093, 10);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(254, 41);
            txtCategoryName.TabIndex = 26;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_category, categorycode, categoryname });
            Viewdata.Location = new Point(-4, 63);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1910, 833);
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
            groupBox1.Location = new Point(-4, 879);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 166);
            groupBox1.TabIndex = 46;
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
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtCategoryCode);
            Controls.Add(label1);
            Controls.Add(txtCategoryName);
            Controls.Add(Viewdata);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhMuc";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCategoryCode;
        private Label label2;
        private Label label1;
        private TextBox txtCategoryName;
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
        private DataGridViewTextBoxColumn id_category;
        private DataGridViewTextBoxColumn categorycode;
        private DataGridViewTextBoxColumn categoryname;
    }
}