using PhoneWarehouse.Controllers;
using PhoneWarehouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneInventory.Views
{
    public partial class ExportView : Form
    {
        public int CurrentId_account { get; set; }
        private readonly ProductController _productController;
        private readonly ExportController _exportController;
        private readonly UserController _userController;
        private readonly CustomerController _customerController;
        int selectedId;

        public ExportView(int id)
        {
            InitializeComponent();
            _productController = new ProductController();
            _exportController = new ExportController();
            _userController = new UserController();
            _customerController = new CustomerController();
            CurrentId_account = id;


            ShowData();
            InitializeControls();

        }

        private void InitializeControls()
        {
            productCode.DataSource = _productController.GetProductCode();
            productCode.DisplayMember = "ProductCode";
            productCode.ValueMember = "ProductId";
            txtEmployeeName.Text = _userController.GetFirstnameById(CurrentId_account);
            txtEmployeeName.Enabled = false;
            cbCustomer.DataSource = _customerController.GetCustomerNames();
            cbCustomer.DisplayMember = "FirstName";
            cbCustomer.ValueMember = "Id";
        }

        private void dataGridViewExport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewExport.Rows.Count)
                return;

            if (e.ColumnIndex == dataGridViewExport.Columns["Quantity"].Index ||
                e.ColumnIndex == dataGridViewExport.Columns["UnitPrice"].Index)
            {
                CalculateTotalForRow(e.RowIndex);
            }
            else if (e.ColumnIndex == dataGridViewExport.Columns["ProductCode"].Index)
            {
                UpdateProductDetails(e.RowIndex);
            }
        }

        private void UpdateProductDetails(int rowIndex)
        {
            int productId = (int)dataGridViewExport.Rows[rowIndex].Cells["ProductCode"].Value;
            var selectedProduct = _productController.GetProductCode().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                dataGridViewExport.Rows[rowIndex].Cells["ProductName"].Value = selectedProduct.ProductName;
                dataGridViewExport.Rows[rowIndex].Cells["Stock"].Value = selectedProduct.StockBalance;
                dataGridViewExport.Rows[rowIndex].Cells["UnitPrice"].Value = selectedProduct.Product.ListPrice;
            }
        }

        private void CalculateTotalForRow(int rowIndex)
        {
            var row = dataGridViewExport.Rows[rowIndex];
            if (decimal.TryParse(row.Cells["Quantity"].Value?.ToString(), out decimal quantity) &&
                decimal.TryParse(row.Cells["UnitPrice"].Value?.ToString(), out decimal unitPrice))
            {
                row.Cells["Total"].Value = quantity * unitPrice;
            }
            else
            {
                row.Cells["Total"].Value = 0;
            }
        }

        private void ShowData()
        {
            try
            {
                _exportController.Load();
                var dataTable = CreateDataTable();

                foreach (ExportDetail exportDetail in _exportController.Items)
                {
                    dataTable.Rows.Add(
                        exportDetail.Id,
                        exportDetail.ExportId,
                        exportDetail.Customer.FirstName,
                        exportDetail.Employee.FirstName,
                        exportDetail.Export.ExportDate,
                        exportDetail.Product.ProductName,
                        exportDetail.Quantity,
                        exportDetail.UnitPrice,
                        exportDetail.UnitPrice * exportDetail.Quantity);
                }
                dataGridViewExportShow.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying data: " + ex.Message);
            }
        }

        private DataTable CreateDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Số phiếu", typeof(int));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Employee", typeof(string));
            dataTable.Columns.Add("ImportDate", typeof(DateTime));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("UnitPrice", typeof(decimal));
            dataTable.Columns.Add("Total", typeof(decimal));
            return dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = (int)cbCustomer.SelectedValue;
                DateTime exportDate = DateTime.Now;

                int exportId = _exportController.SaveExport(customerId, CurrentId_account, exportDate);

                foreach (DataGridViewRow row in dataGridViewExport.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = (int)row.Cells["ProductCode"].Value;
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                    _exportController.SaveExportDetail(exportId, productId, quantity, unitPrice);
                    ShowData();
                }

                MessageBox.Show("Import saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the import: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbCustomer.SelectedIndex = -1;

            dataGridViewExport.Rows.Clear();
        }

        private void dataGridViewExportShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewExportShow.Rows.Count)
                return;

            DataGridViewRow selectedRow = dataGridViewExportShow.Rows[e.RowIndex];

            dataGridViewExport.Rows.Clear();

            int rowIndex = dataGridViewExport.Rows.Add();
            DataGridViewRow newRow = dataGridViewExport.Rows[rowIndex];

            selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            newRow.Cells["ProductName"].Value = selectedRow.Cells["ProductName"].Value;
            newRow.Cells["Quantity"].Value = selectedRow.Cells["Quantity"].Value;
            newRow.Cells["UnitPrice"].Value = selectedRow.Cells["UnitPrice"].Value;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId <= 0)
                {
                    MessageBox.Show("Hãy chọn 1 phiếu để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantity = Convert.ToInt32(dataGridViewExport.CurrentRow.Cells["Quantity"].Value);

                bool result = _exportController.UpdateExportDetail(selectedId, quantity);

                if (result)
                {
                    MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi chỉnh sửa vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewExportShow.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", FileName = "ExportData.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            // Write the header
                            var headers = dataGridViewExportShow.Columns.Cast<DataGridViewColumn>();
                            sw.WriteLine(string.Join(",", headers.Select(column => column.HeaderText)));

                            // Write the data
                            foreach (DataGridViewRow row in dataGridViewExportShow.Rows)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sw.WriteLine(string.Join(",", cells.Select(cell => cell.Value?.ToString())));
                            }
                        }
                        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
