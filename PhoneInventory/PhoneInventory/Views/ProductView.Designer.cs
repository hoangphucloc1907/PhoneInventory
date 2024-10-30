namespace PhoneWarehouse.Views
{
    partial class ProductView
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
            txtStandardCost = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtListPrice = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            Viewdata = new DataGridView();
            id_product = new DataGridViewTextBoxColumn();
            productcode = new DataGridViewTextBoxColumn();
            productname = new DataGridViewTextBoxColumn();
            category_id = new DataGridViewTextBoxColumn();
            standartcost = new DataGridViewTextBoxColumn();
            listprice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            decription = new DataGridViewTextBoxColumn();
            cbCategory = new ComboBox();
            txtDescription = new TextBox();
            label8 = new Label();
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
            // txtStandardCost
            // 
            txtStandardCost.Font = new Font("Segoe UI", 15F);
            txtStandardCost.Location = new Point(174, 81);
            txtStandardCost.Name = "txtStandardCost";
            txtStandardCost.Size = new Size(196, 41);
            txtStandardCost.TabIndex = 47;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(73, 73);
            label7.Name = "label7";
            label7.Size = new Size(110, 57);
            label7.TabIndex = 46;
            label7.Text = "Giá bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(807, 4);
            label4.Name = "label4";
            label4.Size = new Size(133, 57);
            label4.TabIndex = 44;
            label4.Text = "Danh mục";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtListPrice
            // 
            txtListPrice.Font = new Font("Segoe UI", 15F);
            txtListPrice.Location = new Point(538, 81);
            txtListPrice.Name = "txtListPrice";
            txtListPrice.Size = new Size(271, 41);
            txtListPrice.TabIndex = 43;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(422, 73);
            label5.Name = "label5";
            label5.Size = new Size(122, 57);
            label5.TabIndex = 42;
            label5.Text = "Giá nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(946, 81);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(216, 41);
            txtQuantity.TabIndex = 40;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 15F);
            txtProductName.Location = new Point(538, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(271, 41);
            txtProductName.TabIndex = 39;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 15F);
            txtProductCode.Location = new Point(174, 16);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(196, 41);
            txtProductCode.TabIndex = 38;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(821, 73);
            label3.Name = "label3";
            label3.Size = new Size(119, 57);
            label3.TabIndex = 37;
            label3.Text = "Số lượng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(166, 57);
            label1.TabIndex = 35;
            label1.Text = "Mã sản phầm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(372, 8);
            label2.Name = "label2";
            label2.Size = new Size(169, 57);
            label2.TabIndex = 36;
            label2.Text = "Tên sản phẩm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_product, productcode, productname, category_id, standartcost, listprice, Quantity, decription });
            Viewdata.Location = new Point(-4, 162);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(1904, 736);
            Viewdata.TabIndex = 41;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // id_product
            // 
            id_product.DataPropertyName = "id";
            id_product.HeaderText = "ID";
            id_product.MinimumWidth = 6;
            id_product.Name = "id_product";
            // 
            // productcode
            // 
            productcode.DataPropertyName = "productcode";
            productcode.HeaderText = "Mã sản phẩm";
            productcode.MinimumWidth = 6;
            productcode.Name = "productcode";
            // 
            // productname
            // 
            productname.DataPropertyName = "productname";
            productname.HeaderText = "Tên sản phẩm";
            productname.MinimumWidth = 6;
            productname.Name = "productname";
            // 
            // category_id
            // 
            category_id.DataPropertyName = "CategoryId";
            category_id.HeaderText = "Danh mục";
            category_id.MinimumWidth = 6;
            category_id.Name = "category_id";
            // 
            // standartcost
            // 
            standartcost.DataPropertyName = "StandardCost";
            standartcost.HeaderText = "Giá niêm yết";
            standartcost.MinimumWidth = 6;
            standartcost.Name = "standartcost";
            // 
            // listprice
            // 
            listprice.DataPropertyName = "listprice";
            listprice.HeaderText = "Giá nhập";
            listprice.MinimumWidth = 6;
            listprice.Name = "listprice";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // decription
            // 
            decription.DataPropertyName = "Description";
            decription.HeaderText = "Mô tả";
            decription.MinimumWidth = 6;
            decription.Name = "decription";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 15F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(946, 18);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(216, 43);
            cbCategory.TabIndex = 49;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(1285, 18);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(605, 138);
            txtDescription.TabIndex = 51;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1187, 8);
            label8.Name = "label8";
            label8.Size = new Size(92, 57);
            label8.TabIndex = 50;
            label8.Text = "Mô tả";
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox1.Location = new Point(-4, 878);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 166);
            groupBox1.TabIndex = 52;
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
            btnX.Click += btnX_Click_1;
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
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(cbCategory);
            Controls.Add(txtStandardCost);
            Controls.Add(label7);
            Controls.Add(txtListPrice);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCode);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Viewdata);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtStandardCost;
        private Label label7;
        private Label label4;
        private TextBox txtListPrice;
        private Label label5;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridView Viewdata;
        private ComboBox cbCategory;
        private TextBox txtDescription;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnX;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClose;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private Label label6;
        private DataGridViewTextBoxColumn id_product;
        private DataGridViewTextBoxColumn productcode;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn category_id;
        private DataGridViewTextBoxColumn standartcost;
        private DataGridViewTextBoxColumn listprice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn decription;
    }
}