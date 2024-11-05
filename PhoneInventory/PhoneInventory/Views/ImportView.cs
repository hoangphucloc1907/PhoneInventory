using PhoneWarehouse.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneWarehouse.Views
{
    public partial class ImportView : Form
    {
        public int CurrentId_account { get; set; }
        private readonly ProductController _productController;
        private readonly ImportController _importController;
        private readonly UserController _userController;
        private readonly SupplierController _supplierController;

        public ImportView(int Id_account)
        {
            InitializeComponent();
            _productController = new ProductController();
            _importController = new ImportController();
            _userController = new UserController();
            _supplierController = new SupplierController();
            CurrentId_account = Id_account;

            InitializeControls();
            ShowData();
        }

        private void InitializeControls()
        {
            productCode.DataSource = _productController.GetProductCode();
            productCode.DisplayMember = "ProductCode";
            productCode.ValueMember = "Id";
            txtEmployeeName.Text = _userController.GetFirstnameById(CurrentId_account);
            txtEmployeeName.Enabled = false;
            cbSupplier.DataSource = _supplierController.GetSuplliers();
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "Id";
        }

        private void dataGridViewImport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewImport.Rows.Count)
                return;

            if (e.ColumnIndex == dataGridViewImport.Columns["Quantity"].Index ||
                e.ColumnIndex == dataGridViewImport.Columns["UnitPrice"].Index)
            {
                CalculateTotalForRow(e.RowIndex);
            }
            else if (e.ColumnIndex == dataGridViewImport.Columns["ProductCode"].Index)
            {
                UpdateProductDetails(e.RowIndex);
            }
        }

        private void UpdateProductDetails(int rowIndex)
        {
            int productId = (int)dataGridViewImport.Rows[rowIndex].Cells["ProductCode"].Value;
            var selectedProduct = _productController.GetProductCode().FirstOrDefault(p => p.Id == productId);

            if (selectedProduct != null)
            {
                dataGridViewImport.Rows[rowIndex].Cells["ProductName"].Value = selectedProduct.ProductName;
            }
        }

        private void CalculateTotalForRow(int rowIndex)
        {
            var row = dataGridViewImport.Rows[rowIndex];
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
                _importController.Load();
                var dataTable = CreateDataTable();

                foreach (Models.ImportDetail importDetail in _importController.Items)
                {
                    dataTable.Rows.Add(
                        importDetail.Id,
                        importDetail.Supplier.SupplierName,
                        importDetail.Employee.FirstName,
                        importDetail.Import.ImportDate,
                        importDetail.Product.ProductName,
                        importDetail.Quantity,
                        importDetail.UnitPrice);
                }
                dataGridViewImportShow.DataSource = dataTable;
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
            dataTable.Columns.Add("Supplier", typeof(string));
            dataTable.Columns.Add("Employee", typeof(string));
            dataTable.Columns.Add("ImportDate", typeof(DateTime));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("UnitPrice", typeof(decimal));
            return dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = (int)cbSupplier.SelectedValue;
                DateTime importDate = DateTime.Now;

                int importId = _importController.SaveImport(supplierId, CurrentId_account, importDate);

                foreach (DataGridViewRow row in dataGridViewImport.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = (int)row.Cells["ProductCode"].Value;
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                    _importController.SaveImportDetail(importId, productId, quantity, unitPrice);
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
            cbSupplier.SelectedIndex = -1;
            dataGridViewImport.Rows.Clear();
        }
    }
}
