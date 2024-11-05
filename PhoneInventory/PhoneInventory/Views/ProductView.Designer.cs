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
            Viewdata = new DataGridView();
            id_product = new DataGridViewTextBoxColumn();
            productcode = new DataGridViewTextBoxColumn();
            productname = new DataGridViewTextBoxColumn();
            category_id = new DataGridViewTextBoxColumn();
            standartcost = new DataGridViewTextBoxColumn();
            listprice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            decription = new DataGridViewTextBoxColumn();
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
            txtDescription = new TextBox();
            label8 = new Label();
            cbCategory = new ComboBox();
            txtStandardCost = new TextBox();
            label7 = new Label();
            txtListPrice = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_product, productcode, productname, category_id, standartcost, listprice, Quantity, decription });
            Viewdata.Dock = DockStyle.Fill;
            Viewdata.Location = new Point(0, 288);
            Viewdata.Margin = new Padding(5);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.Size = new Size(2534, 1057);
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
            groupBox1.Location = new Point(0, 1345);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 184);
            groupBox1.TabIndex = 53;
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
            btnX.Location = new Point(2173, 65);
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
            btnSearch.Location = new Point(2307, 63);
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
            txtSearch.Location = new Point(1694, 59);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(557, 78);
            txtSearch.TabIndex = 23;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1011, 45);
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
            btnClear.Location = new Point(692, 45);
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
            btnDelete.Location = new Point(358, 45);
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
            btnSave.Location = new Point(21, 45);
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
            label6.Location = new Point(1418, 52);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(266, 91);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbCategory);
            groupBox2.Controls.Add(txtStandardCost);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtListPrice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(txtProductCode);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 288);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(1945, 85);
            txtDescription.Margin = new Padding(5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(471, 148);
            txtDescription.TabIndex = 65;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1770, 129);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 91);
            label8.TabIndex = 64;
            label8.Text = "Mô tả";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 15F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(1506, 56);
            cbCategory.Margin = new Padding(5);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(238, 62);
            cbCategory.TabIndex = 63;
            // 
            // txtStandardCost
            // 
            txtStandardCost.Font = new Font("Segoe UI", 15F);
            txtStandardCost.Location = new Point(267, 172);
            txtStandardCost.Margin = new Padding(5);
            txtStandardCost.Name = "txtStandardCost";
            txtStandardCost.Size = new Size(249, 61);
            txtStandardCost.TabIndex = 62;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(64, 157);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(179, 91);
            label7.TabIndex = 61;
            label7.Text = "Giá bán";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtListPrice
            // 
            txtListPrice.Font = new Font("Segoe UI", 15F);
            txtListPrice.Location = new Point(810, 172);
            txtListPrice.Margin = new Padding(5);
            txtListPrice.Name = "txtListPrice";
            txtListPrice.Size = new Size(265, 61);
            txtListPrice.TabIndex = 59;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(592, 157);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(198, 91);
            label5.TabIndex = 58;
            label5.Text = "Giá nhập";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 15F);
            txtQuantity.Location = new Point(1356, 172);
            txtQuantity.Margin = new Padding(5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(209, 61);
            txtQuantity.TabIndex = 57;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 15F);
            txtProductName.Location = new Point(920, 53);
            txtProductName.Margin = new Padding(5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(249, 61);
            txtProductName.TabIndex = 56;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 15F);
            txtProductCode.Location = new Point(329, 53);
            txtProductCode.Margin = new Padding(5);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(251, 61);
            txtProductCode.TabIndex = 55;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(64, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 91);
            label1.TabIndex = 52;
            label1.Text = "Mã sản phầm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(650, 40);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 91);
            label2.TabIndex = 53;
            label2.Text = "Tên sản phẩm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1221, 40);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 91);
            label4.TabIndex = 60;
            label4.Text = "Danh mục";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1128, 157);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 91);
            label3.TabIndex = 54;
            label3.Text = "Số lượng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(Viewdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "ProductView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
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
        private DataGridViewTextBoxColumn id_product;
        private DataGridViewTextBoxColumn productcode;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn category_id;
        private DataGridViewTextBoxColumn standartcost;
        private DataGridViewTextBoxColumn listprice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn decription;
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
        private TextBox txtDescription;
        private Label label8;
        private ComboBox cbCategory;
        private TextBox txtStandardCost;
        private Label label7;
        private TextBox txtListPrice;
        private Label label5;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}