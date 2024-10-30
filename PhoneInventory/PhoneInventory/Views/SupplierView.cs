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

namespace PhoneWarehouse.Views
{
    public partial class SupplierView : Form
    {
        private readonly SupplierController _supplierController;
        ErrorProvider errorProvider = new ErrorProvider();
        int id;
        public SupplierView()
        {
            InitializeComponent();
            _supplierController = new SupplierController();
            Showdata();
        }
        public void Showdata()
        {
            try
            {
                _supplierController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("SupplierCode", typeof(string));
                dataTable.Columns.Add("SupplierName", typeof(string));
                dataTable.Columns.Add("PhoneNumber", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                foreach (Models.Supplier supplier in _supplierController.Items)
                {
                    dataTable.Rows.Add(supplier.Id, supplier.SupplierCode, supplier.SupplierName, supplier.PhoneNumber, supplier.Address);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hiện thị dữ liệu" + ex.Message);
            }
        }
        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhoneNumber.Text;
            if (!_supplierController.IsValidPhone(phone))
            {
                errorProvider.SetError(txtPhoneNumber, "Số điện thoại phải có từ 10 đến 11 chữ số không bao gồm chữ cái!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhoneNumber, "");
            }
        }

        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                id = int.Parse(row.Cells["id_supplier"].Value.ToString());
                txtSupplierCode.Text = row.Cells["supplierCode"].Value.ToString();
                txtSupplierName.Text = row.Cells["supplierName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtSupplierCode.Text) || string.IsNullOrEmpty(txtSupplierName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtAddress.Text))
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
        private Models.Supplier CreateSupplierFromInput()
        {
            return new Models.Supplier
            {
                Id = id,
                SupplierCode = txtSupplierCode.Text.Trim(),
                SupplierName = txtSupplierName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var supplier = CreateSupplierFromInput();
                if (_supplierController.Upsert(supplier))
                {
                    MessageBox.Show("Thêm nhà cung cấp mới thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var supplier = CreateSupplierFromInput();
                if (_supplierController.Delete(id))
                {
                    MessageBox.Show("Xoá nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Xoá nhà cung cấp không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Showdata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                string searchKeyword = txtSearch.Text;
                var results = _supplierController.SearchByCodeOrName(searchKeyword);

                if (results.Count > 0)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("SupplierCode", typeof(string));
                    dataTable.Columns.Add("SupplierName", typeof(string));
                    dataTable.Columns.Add("PhoneNumber", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    foreach (Models.Supplier supplier in results)
                    {
                        dataTable.Rows.Add(supplier.Id, supplier.SupplierCode, supplier.SupplierName, supplier.PhoneNumber, supplier.Address);
                    }
                    Viewdata.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với thông tin đã nhập.");
                }
            }
        }
    }
}
