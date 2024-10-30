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
    public partial class CustomerView : Form
    {
        private readonly CustomerController _customerController;
        ErrorProvider errorProvider = new ErrorProvider();
        int id;
        public CustomerView()
        {
            InitializeComponent();
            _customerController = new CustomerController();
            Showdata();
        }
        public void Showdata()
        {
            try
            {
                _customerController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("LastName", typeof(string));
                dataTable.Columns.Add("FirstName", typeof(string));
                dataTable.Columns.Add("PhoneNumber", typeof(string));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                foreach (Models.Customer customer in _customerController.Items)
                {
                    dataTable.Rows.Add(customer.Id, customer.LastName, customer.FirstName, customer.PhoneNumber, customer.Gender, customer.Address);
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
            if (!_customerController.IsValidPhone(phone))
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
                id = int.Parse(row.Cells["id_customer"].Value.ToString());
                txtFirstName.Text = row.Cells["LastName"].Value.ToString();
                txtLastName.Text = row.Cells["FirstName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                cbGender.Text = row.Cells["Gender"].Value.ToString();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtAddress.Text))
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
        private Models.Customer CreateCustomerFromInput()
        {
            string gender;
            if (cbGender.SelectedIndex == 0)
            {
                gender = "Nam";
            }
            else if (cbGender.SelectedIndex == 1)
            {
                gender = "Nữ";
            }
            else
            { gender = "Khác"; }
            return new Models.Customer
            {
                Id = id,
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                FirstName = txtLastName.Text.Trim(),
                LastName = txtFirstName.Text.Trim(),
                Gender = gender,
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateCustomerFromInput();
                if (_customerController.Upsert(user))
                {
                    MessageBox.Show("Đã tạo khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Tạo khách hàng không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var customer = CreateCustomerFromInput();
                if (_customerController.Delete(id))
                {
                    MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Xoá khách hàng không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            cbGender.SelectedIndex = -1;
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
                var results = _customerController.SearchFirstName(searchKeyword);

                if (results.Count > 0)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("LastName", typeof(string));
                    dataTable.Columns.Add("FirstName", typeof(string));
                    dataTable.Columns.Add("PhoneNumber", typeof(string));
                    dataTable.Columns.Add("Gender", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));

                    // Thêm kết quả tìm kiếm từ `results` vào `dataTable`
                    foreach (Models.Customer customer in results)
                    {
                        dataTable.Rows.Add(customer.Id, customer.LastName, customer.FirstName, customer.PhoneNumber, customer.Gender, customer.Address);
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
