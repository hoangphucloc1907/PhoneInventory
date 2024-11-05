namespace PhoneInventory.Views
{
    partial class ExportView
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
            dataGridViewExportShow = new DataGridView();
            dataGridViewExport = new DataGridView();
            productCode = new DataGridViewComboBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtEmployeeName = new TextBox();
            label1 = new Label();
            cbCustomer = new ComboBox();
            dateExportDate = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExportShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExport).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewExportShow
            // 
            dataGridViewExportShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExportShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExportShow.Dock = DockStyle.Right;
            dataGridViewExportShow.Location = new Point(1015, 239);
            dataGridViewExportShow.Name = "dataGridViewExportShow";
            dataGridViewExportShow.RowHeadersWidth = 82;
            dataGridViewExportShow.Size = new Size(1519, 1072);
            dataGridViewExportShow.TabIndex = 56;
            dataGridViewExportShow.CellClick += dataGridViewExportShow_CellClick;
            // 
            // dataGridViewExport
            // 
            dataGridViewExport.AllowUserToOrderColumns = true;
            dataGridViewExport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExport.Columns.AddRange(new DataGridViewColumn[] { productCode, productName, Stock, Quantity, unitPrice, total });
            dataGridViewExport.Dock = DockStyle.Left;
            dataGridViewExport.Location = new Point(0, 239);
            dataGridViewExport.Margin = new Padding(5);
            dataGridViewExport.Name = "dataGridViewExport";
            dataGridViewExport.RowHeadersVisible = false;
            dataGridViewExport.RowHeadersWidth = 51;
            dataGridViewExport.Size = new Size(1007, 1072);
            dataGridViewExport.TabIndex = 53;
            dataGridViewExport.CellValueChanged += dataGridViewExport_CellValueChanged;
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
            productName.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Tồn kho";
            Stock.MinimumWidth = 10;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
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
            unitPrice.ReadOnly = true;
            // 
            // total
            // 
            total.DataPropertyName = "Total";
            total.HeaderText = "Tổng giá";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmployeeName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbCustomer);
            groupBox2.Controls.Add(dateExportDate);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2534, 239);
            groupBox2.TabIndex = 55;
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
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Segoe UI", 13F);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(1252, 81);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(359, 55);
            cbCustomer.TabIndex = 49;
            // 
            // dateExportDate
            // 
            dateExportDate.Font = new Font("Segoe UI", 15F);
            dateExportDate.Format = DateTimePickerFormat.Short;
            dateExportDate.Location = new Point(2027, 75);
            dateExportDate.Margin = new Padding(5);
            dateExportDate.Name = "dateExportDate";
            dateExportDate.Size = new Size(274, 61);
            dateExportDate.TabIndex = 46;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(898, 78);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 64);
            label2.TabIndex = 39;
            label2.Text = "Khách hàng";
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
            label7.Text = "Ngày xuất";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox1.TabIndex = 54;
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
            btnClear.Location = new Point(1054, 81);
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
            btnDelete.Location = new Point(735, 81);
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
            btnEdit.Location = new Point(401, 81);
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
            btnSave.Location = new Point(64, 81);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 104);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 20F);
            btnExport.Location = new Point(1372, 81);
            btnExport.Margin = new Padding(5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(293, 104);
            btnExport.TabIndex = 26;
            btnExport.Text = "Export File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // ExportView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridViewExportShow);
            Controls.Add(dataGridViewExport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ExportView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExportShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExport).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewExportShow;
        private DataGridView dataGridViewExport;
        private GroupBox groupBox2;
        private TextBox txtEmployeeName;
        private Label label1;
        private ComboBox cbCustomer;
        private DateTimePicker dateExportDate;
        private Label label2;
        private Label label7;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private DataGridViewComboBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn total;
        private Button btnExport;
    }
}