using PhoneWarehouse.Controllers;
using PhoneWarehouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneInventory.Views
{
    public partial class CurrentStockView : Form
    {
        private readonly ProductController _productController;
        public CurrentStockView()
        {
            InitializeComponent();
            _productController = new ProductController();
            ShowData();
        }

        private void InitializeComponent()
        {
            dataGridViewCurrentStock = new DataGridView();
            groupBox1 = new GroupBox();
            btnExport = new Button();
            ((ISupportInitialize)dataGridViewCurrentStock).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCurrentStock
            // 
            dataGridViewCurrentStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCurrentStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurrentStock.Dock = DockStyle.Fill;
            dataGridViewCurrentStock.Location = new Point(0, 0);
            dataGridViewCurrentStock.Name = "dataGridViewCurrentStock";
            dataGridViewCurrentStock.RowHeadersWidth = 82;
            dataGridViewCurrentStock.Size = new Size(2534, 1529);
            dataGridViewCurrentStock.TabIndex = 0;
            dataGridViewCurrentStock.CellContentClick += dataGridViewCurrentStock_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExport);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 1388);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2534, 141);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 20F);
            btnExport.Location = new Point(66, 27);
            btnExport.Margin = new Padding(5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(293, 104);
            btnExport.TabIndex = 26;
            btnExport.Text = "Export File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // CurrentStockView
            // 
            ClientSize = new Size(2534, 1529);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCurrentStock);
            Name = "CurrentStockView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridViewCurrentStock).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private Button btnExport;
        private DataGridView dataGridViewCurrentStock;

        private void dataGridViewCurrentStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowData()
        {
            try
            {
                _productController.LoadCurrentStock();
                var dataTable = CreateDataTable();
                int id = 1;
                foreach (Models.CurrentStock currentStock in _productController.Items)
                {
                    dataTable.Rows.Add(
                        id,
                        currentStock.ProductCode,
                        currentStock.ProductName,
                        currentStock.TotalImported,
                        currentStock.TotalExported,
                        currentStock.StockBalance);
                    id++;
                }
                dataGridViewCurrentStock.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying data: " + ex.Message);
            }
        }

        private DataTable CreateDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Mã sản phẩm", typeof(string));
            dataTable.Columns.Add("Tên sản phẩm", typeof(string));
            dataTable.Columns.Add("Số lượng nhập", typeof(int));
            dataTable.Columns.Add("Số lượng xuất", typeof(int));
            dataTable.Columns.Add("Số lượng tồn kho", typeof(int));
            return dataTable;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCurrentStock.DataSource is not DataTable dataTable || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.");
                    return;
                }

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = "CurrentStock.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Write the header
                        var columnNames = string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                        writer.WriteLine(columnNames);

                        // Write the data
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var fields = string.Join(",", row.ItemArray.Select(field => field.ToString()));
                            writer.WriteLine(fields);
                        }
                    }

                    MessageBox.Show("Data exported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting data: " + ex.Message);
            }
        }
    }
}
