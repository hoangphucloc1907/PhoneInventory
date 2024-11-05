using PhoneWarehouse.Models;
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
using System.Xml.Linq;

namespace PhoneWarehouse.Views
{
    public partial class UserView : Form
    {
        private readonly UserController _userController;
        ErrorProvider errorProvider = new ErrorProvider();
        int id;
        string rolecheck;
        public UserView(string UserRole)
        {
            rolecheck = UserRole;
            InitializeComponent();
            _userController = new UserController();
            Showdata();
        }
        public void Showdata()
        {
            try
            {
                _userController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("UserName", typeof(string));
                dataTable.Columns.Add("Password", typeof(string));
                dataTable.Columns.Add("LastName", typeof(string));
                dataTable.Columns.Add("FirstName", typeof(string));
                dataTable.Columns.Add("PhoneNumber", typeof(string));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));
                foreach (Models.User user in _userController.Items)
                {
                    dataTable.Rows.Add(user.Id, user.UserName, user.Password, user.LastName, user.FirstName, user.PhoneNumber, user.Gender, user.Address, user.Role);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hiện thị dữ liệu" + ex.Message);
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhone.Text;
            if (!_userController.IsValidPhone(phone))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải có từ 10 đến 11 chữ số không bao gồm chữ cái!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
            }
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                id = int.Parse(row.Cells["id_user"].Value.ToString());
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                cbGender.Text = row.Cells["Gender"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();
                var checkRole = (role == "Admin") ? radioAdmin.Checked = true : radioEmp.Checked = (role == "Employee");
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
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
        private Models.User CreateUserFromInput()
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
            return new Models.User
            {
                Id = id,
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Gender = gender,
                Role = radioAdmin.Checked ? "Admin" : "Employee"
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateUserFromInput();
                if (_userController.Upsert(user))
                {
                    MessageBox.Show("Đã tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateUserFromInput();
                if (_userController.Delete(id))
                {
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtUserName.Clear();
            txtPassword.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cbGender.SelectedIndex = -1;
            radioAdmin.Checked = false;
            radioEmp.Checked = false;
            Showdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                string searchKeyword = txtSearch.Text.Trim();
                var results = _userController.SearchByAccountOrFirstName(searchKeyword);

                if (results.Count > 0)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("UserName", typeof(string));
                    dataTable.Columns.Add("Password", typeof(string));
                    dataTable.Columns.Add("LastName", typeof(string));
                    dataTable.Columns.Add("FirstName", typeof(string));
                    dataTable.Columns.Add("PhoneNumber", typeof(string));
                    dataTable.Columns.Add("Gender", typeof(string));
                    dataTable.Columns.Add("Address", typeof(string));
                    dataTable.Columns.Add("Role", typeof(string));

                    foreach (Models.User user in results)
                    {
                        dataTable.Rows.Add(user.Id, user.UserName, user.Password, user.LastName, user.FirstName, user.PhoneNumber, user.Gender, user.Address, user.Role);
                    }
                    Viewdata.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với thông tin đã nhập.");
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Showdata();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
