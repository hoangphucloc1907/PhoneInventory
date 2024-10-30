using PhoneWarehouse.Controllers;
using PhoneWarehouse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneWarehouse.Views
{
    public partial class ExportView : Form
    {
        public int CurrentId_account { get; set; }
        private readonly ProductController _productController;
        private readonly ExportController _exportController;
        private readonly CustomerController _customerController;
        private readonly UserController _userController;
        private readonly Export _export;
        ErrorProvider errorProvider = new ErrorProvider();
        private decimal originalAmount;
        int id;

        public ExportView(int Id_account)
        {
            InitializeComponent();
            _productController = new ProductController();
            _userController = new UserController();
            _customerController = new CustomerController();
            _exportController = new ExportController();
            _export = new Export();

            var products = _productController.GetProductNames();
            var customers = _customerController.GetCustomerNames();
            var users = _userController.GetUserNames();

            cbProductId.DisplayMember = "ProductName";
            cbProductId.ValueMember = "Id";
            cbProductId.DataSource = products;

            cbCustomer.DisplayMember = "FirstName";
            cbCustomer.ValueMember = "Id";
            cbCustomer.DataSource = customers;

            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "Id";
            cbEmployee.DataSource = users;

            dateExportDate.Format = DateTimePickerFormat.Custom;
            dateExportDate.CustomFormat = "dd/MM/yyyy";

            cbProductId.SelectedIndexChanged += cbProductId_SelectedIndexChanged;

            CurrentId_account = Id_account;

            Showdata();

        }
        public void Showdata()
        {
            try
            {
                _exportController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("ExportId", typeof(int));
                dataTable.Columns.Add("Employee", typeof(string));
                dataTable.Columns.Add("Customer", typeof(string));
                dataTable.Columns.Add("Date", typeof(string));
                dataTable.Columns.Add("Product", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("UnitPrice", typeof(decimal));
                dataTable.Columns.Add("TotalPrice", typeof(decimal));

                foreach (Models.ExportDetail exportdetail in _exportController.Items)
                {
                    var export = CreaateExportFromInput();
                    int export_id = _exportController.CheckExport(export);

                    int id_employe = _exportController.SelectEmployeeIdByExportId(export_id);
                    string nameEmployee = _userController.GetFirstnameById(id_employe);

                    int id_cus = _exportController.SelectCustomerIdByExportId(export_id);
                    string nameCus = _customerController.GetFirstnameById(id_cus);
                    string nameProduct = _productController.GetProductNameById(exportdetail.ProductId);

                    DateTime date = _exportController.SelectDateByExportId(export_id);
                    string exportDate = date.ToString("dd/MM/yyyy");
                    dataTable.Rows.Add(exportdetail.Id,
                                       exportdetail.ExportId,
                                       nameEmployee,
                                       nameCus,
                                       exportDate,
                                       nameProduct,
                                       exportdetail.Quantity,
                                       exportdetail.UnitPrice,
                                       exportdetail.Quantity * exportdetail.UnitPrice);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hiện thị dữ liệu " + ex.Message);
            }
        }

        private void cbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductId.SelectedItem != null)
            {
                var selectProduct = (Product)cbProductId.SelectedItem;
                txtUnitPrice.Text = selectProduct.ListPrice.ToString();

                if (int.TryParse(txtQuantity.Text.Trim(), out int quantity))
                {
                    CalculateTotal(quantity);
                }
            }
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                id = int.Parse(row.Cells["id_export"].Value.ToString());
                txtExportId.Text = row.Cells["exportId"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                cbCustomer.Text = row.Cells["Customer"].Value.ToString();
                cbEmployee.Text = row.Cells["Employee"].Value.ToString();
                cbProductId.Text = row.Cells["nameProduct"].Value.ToString();

                string dateValue = row.Cells["Date"].Value.ToString();
                DateTime selectedDate = DateTime.ParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dateExportDate.Value = selectedDate;
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                if (int.TryParse(txtQuantity.Text.Trim(), out int quantity))
                {
                    CalculateTotal(quantity);
                }
                else
                {
                    txtTotal.Text = "0";
                }
            }
        }
        private void CalculateTotal(int quantity)
{
    if (decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice))
    {
        decimal total = quantity * unitPrice;
        txtTotal.Text = total.ToString("N2"); // Hiển thị total với 2 chữ số thập phân
    }
    else
    {
        txtTotal.Text = "0";
    }
}
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtTotal.Text) || string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private bool ValidateSearch()
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private Models.Export CreaateExportFromInput()
        {
            int cusid = _customerController.GetCusIdByFirstname(cbCustomer.SelectedValue.ToString());
            var selectedValue = cbCustomer.SelectedValue?.ToString() ?? "Không có giá trị nào được chọn";
            int empid = _userController.GetUserIdByFirstname(cbEmployee.SelectedValue.ToString());
            var selectedValueEmp = cbEmployee.SelectedValue?.ToString() ?? "Không có giá trị nào được chọn";
            return new Models.Export
            {
                Id = id,
                CustomerId = cusid,
                EmployeeId = empid,
                ExportDate = DateTime.Now
            };
        }
        private Models.ExportDetail CreaateExportDetailFromInput(int id_ex)
        {
            int proid = _productController.GetProductIdByName(cbProductId.SelectedValue.ToString());
            var selectedValue = cbProductId.SelectedValue?.ToString() ?? "Không có giá trị nào được chọn";
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                quantity = 0;
            }
            return new Models.ExportDetail
            {
                Id = id,
                ExportId = id_ex,
                ProductId = proid,
                UnitPrice = originalAmount,
                Quantity = quantity
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var exp = CreaateExportFromInput();
            int check = _exportController.CheckExport(exp);

            if (check >= 1)
            {
                var exportDetail = CreaateExportDetailFromInput(check);
                MessageBox.Show($"Giá trị ExportId: {exportDetail.ExportId}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var result = _exportController.Upsert(exportDetail);
                Showdata();
            }
            else
            {
                MessageBox.Show("Không tìm thấy ExportId hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
