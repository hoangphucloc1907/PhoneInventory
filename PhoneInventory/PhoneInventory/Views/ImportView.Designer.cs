namespace PhoneWarehouse.Views
{
    partial class ImportView
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
            dataGridViewImport = new DataGridView();
            productCode = new DataGridViewComboBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            txtEmployeeName = new TextBox();
            label1 = new Label();
            cbSupplier = new ComboBox();
            dateImportDate = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            dataGridViewImportShow = new DataGridView();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImport).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportShow).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewImport
            // 
            dataGridViewImport.AllowUserToOrderColumns = true;
            dataGridViewImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewImport.Columns.AddRange(new DataGridViewColumn[] { productCode, productName, Quantity, unitPrice, total });
            dataGridViewImport.Dock = DockStyle.Left;
            dataGridViewImport.Location = new Point(0, 239);
            dataGridViewImport.Margin = new Padding(5);
            dataGridViewImport.Name = "dataGridViewImport";
            dataGridViewImport.RowHeadersVisible = false;
            dataGridViewImport.RowHeadersWidth = 51;
            dataGridViewImport.Size = new Size(1007, 1072);
            dataGridViewImport.TabIndex = 20;
            dataGridViewImport.CellValidating += dataGridViewImport_CellValidating;
            dataGridViewImport.CellValueChanged += dataGridViewImport_CellValueChanged;
            // 
            // productCode
            // 
            productCode.DataPropertyName = "ProductCode";
            productCode.HeaderText = "Mã sản phẩm";
            productCode.MinimumWidth = 6;
            productCode.Name = "productCode";
            productCode.Resizable = DataGridViewTriState.True;
            productCode.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // productName
            // 
            productName.DataPropertyName = "ProductName";
            productName.HeaderText = "Tên sản phẩm";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // unitPrice
            // 
            unitPrice.DataPropertyName = "UnitPrice";
            unitPrice.HeaderText = "Đơn giá";
            unitPrice.MinimumWidth = 6;
            unitPrice.Name = "unitPrice";
            // 
            // total
            // 
            total.DataPropertyName = "Total";
            total.HeaderText = "Tổng giá";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1311);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 218);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(2331, 109);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(153, 46);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(2089, 113);
            textBox4.Margin = new Padding(5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 39);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1879, 81);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 91);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(1069, 81);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 104);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(750, 81);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 104);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 20F);
            btnEdit.Location = new Point(416, 81);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(250, 104);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(79, 81);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 104);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmployeeName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbSupplier);
            groupBox2.Controls.Add(dateImportDate);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 239);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI", 13F);
            txtEmployeeName.Location = new Point(320, 93);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(338, 54);
            txtEmployeeName.TabIndex = 51;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(60, 81);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 64);
            label1.TabIndex = 50;
            label1.Text = "Nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbSupplier
            // 
            cbSupplier.Font = new Font("Segoe UI", 13F);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(1252, 81);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(359, 55);
            cbSupplier.TabIndex = 49;
            // 
            // dateImportDate
            // 
            dateImportDate.Font = new Font("Segoe UI", 15F);
            dateImportDate.Format = DateTimePickerFormat.Short;
            dateImportDate.Location = new Point(2027, 75);
            dateImportDate.Margin = new Padding(5);
            dateImportDate.Name = "dateImportDate";
            dateImportDate.Size = new Size(274, 61);
            dateImportDate.TabIndex = 46;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(898, 78);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 64);
            label2.TabIndex = 39;
            label2.Text = "Nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1709, 73);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(226, 69);
            label7.TabIndex = 44;
            label7.Text = "Ngày nhập";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImportShow
            // 
            dataGridViewImportShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewImportShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewImportShow.Dock = DockStyle.Right;
            dataGridViewImportShow.Location = new Point(1014, 239);
            dataGridViewImportShow.Name = "dataGridViewImportShow";
            dataGridViewImportShow.RowHeadersWidth = 82;
            dataGridViewImportShow.Size = new Size(1520, 1072);
            dataGridViewImportShow.TabIndex = 52;
            dataGridViewImportShow.CellClick += dataGridViewImportShow_CellClick;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 20F);
            btnExport.Location = new Point(1379, 81);
            btnExport.Margin = new Padding(5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(293, 104);
            btnExport.TabIndex = 27;
            btnExport.Text = "Export File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // ImportView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridViewImportShow);
            Controls.Add(dataGridViewImport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "ImportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockIn";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewImport).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImportShow).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewImport;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private GroupBox groupBox2;
        private DateTimePicker dateImportDate;
        private Label label2;
        private Label label7;
        private ComboBox cbSupplier;
        private DataGridViewComboBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn total;
        private TextBox txtEmployeeName;
        private Label label1;
        private DataGridView dataGridViewImportShow;
        private Button btnExport;
    }
}