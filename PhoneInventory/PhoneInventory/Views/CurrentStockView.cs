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
            ((ISupportInitialize)dataGridViewCurrentStock).BeginInit();
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
            // CurrentStockView
            // 
            ClientSize = new Size(2534, 1529);
            Controls.Add(dataGridViewCurrentStock);
            Name = "CurrentStockView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridViewCurrentStock).EndInit();
            ResumeLayout(false);
        }

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
    }
}
