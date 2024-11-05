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
    public partial class CategoryView : Form
    {
        private readonly CategoryController _categoryController;
        ErrorProvider errorProvider = new ErrorProvider();
        int id;
        public CategoryView()
        {
            InitializeComponent();
            _categoryController = new CategoryController();
            Showdata();

        }
        public void Showdata()
        {
            try
            {
                _categoryController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("CategoryCode", typeof(string));
                dataTable.Columns.Add("CategoryName", typeof(string));
                foreach (Models.Category category in _categoryController.Items)
                {
                    dataTable.Rows.Add(category.Id, category.CategoryCode, category.CategoryName);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hiện thị dữ liệu" + ex.Message);
            }
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                id = int.Parse(row.Cells["id_category"].Value.ToString());
                txtCategoryCode.Text = row.Cells["categorycode"].Value.ToString();
                txtCategoryName.Text = row.Cells["categoryname"].Value.ToString();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtCategoryCode.Text) || string.IsNullOrEmpty(txtCategoryName.Text))
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
        private Models.Category CreateCategoryFromInput()
        {
            return new Models.Category
            {
                Id = id,
                CategoryCode = txtCategoryCode.Text.Trim(),
                CategoryName = txtCategoryName.Text.Trim(),
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateCategoryFromInput();
                if (_categoryController.Upsert(user))
                {
                    MessageBox.Show("Đã tạo danh mục mới thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Tạo danh mục không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateCategoryFromInput();
                if (_categoryController.Delete(id))
                {
                    MessageBox.Show("Xoá danh mục thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Xoá danh mục không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtCategoryCode.Clear();
            txtCategoryName.Clear();
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
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Showdata();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearch())
            {
                string searchKeyword = txtSearch.Text.Trim();
                var results = _categoryController.SearchByCodeOrName(searchKeyword);
                if (results.Count > 0)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("CategoryCode", typeof(string));
                    dataTable.Columns.Add("CategoryName", typeof(string));
                    foreach (Models.Category category in results)
                    {
                        dataTable.Rows.Add(category.Id, category.CategoryCode, category.CategoryName);
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
