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
            dataGridViewExportShow.Location = new Point(249, 149);
            dataGridViewExportShow.Margin = new Padding(2);
            dataGridViewExportShow.Name = "dataGridViewExportShow";
            dataGridViewExportShow.RowHeadersWidth = 82;
            dataGridViewExportShow.Size = new Size(935, 374);
            dataGridViewExportShow.TabIndex = 56;
            dataGridViewExportShow.CellClick += dataGridViewExportShow_CellClick;
            // 
            // dataGridViewExport
            // 
            dataGridViewExport.AllowUserToOrderColumns = true;
            dataGridViewExport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExport.Columns.AddRange(new DataGridViewColumn[] { productCode, productName, Quantity, unitPrice, total });
            dataGridViewExport.Dock = DockStyle.Left;
            dataGridViewExport.Location = new Point(0, 149);
            dataGridViewExport.Name = "dataGridViewExport";
            dataGridViewExport.RowHeadersVisible = false;
            dataGridViewExport.RowHeadersWidth = 51;
            dataGridViewExport.Size = new Size(620, 374);
            dataGridViewExport.TabIndex = 53;
            dataGridViewExport.CellValidating += dataGridViewExport_CellValidating;
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
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1184, 149);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI", 13F);
            txtEmployeeName.Location = new Point(197, 58);
            txtEmployeeName.Margin = new Padding(2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(210, 36);
            txtEmployeeName.TabIndex = 51;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(37, 51);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 50;
            label1.Text = "Nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbCustomer
            // 
            cbCustomer.Font = new Font("Segoe UI", 13F);
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(770, 51);
            cbCustomer.Margin = new Padding(2);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(222, 38);
            cbCustomer.TabIndex = 49;
            // 
            // dateExportDate
            // 
            dateExportDate.Font = new Font("Segoe UI", 15F);
            dateExportDate.Format = DateTimePickerFormat.Short;
            dateExportDate.Location = new Point(1247, 47);
            dateExportDate.Name = "dateExportDate";
            dateExportDate.Size = new Size(170, 41);
            dateExportDate.TabIndex = 46;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(553, 49);
            label2.Name = "label2";
            label2.Size = new Size(174, 40);
            label2.TabIndex = 39;
            label2.Text = "Khách hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1052, 46);
            label7.Name = "label7";
            label7.Size = new Size(139, 43);
            label7.TabIndex = 44;
            label7.Text = "Ngày xuất";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1184, 136);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(1434, 68);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1286, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1156, 51);
            label4.Name = "label4";
            label4.Size = new Size(123, 57);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(820, 42);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 65);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(624, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 65);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 20F);
            btnEdit.Location = new Point(418, 42);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 65);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(211, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 65);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ExportView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(dataGridViewExportShow);
            Controls.Add(dataGridViewExport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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
        private DataGridViewComboBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn total;
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
    }
}