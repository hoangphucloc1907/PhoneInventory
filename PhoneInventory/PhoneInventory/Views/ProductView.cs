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
    public partial class ProductView : Form
    {
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        ErrorProvider errorProvider = new ErrorProvider();
        int id;
        private decimal originalAmount;

        public ProductView()
        {
            InitializeComponent();
            _categoryController = new CategoryController();
            var categories = _categoryController.GetCategoryNames();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = categories;

            _productController = new ProductController();
            Showdata();
        }
        public void Showdata()
        {
            try
            {
                _productController.Load();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("CategoryId", typeof(int));
                dataTable.Columns.Add("ProductCode", typeof(string));
                dataTable.Columns.Add("ProductName", typeof(string));
                dataTable.Columns.Add("StandardCost", typeof(decimal));
                dataTable.Columns.Add("ListPrice", typeof(decimal));
                dataTable.Columns.Add("Description", typeof(string));

                foreach (Models.Product product in _productController.Items)
                {
                    dataTable.Rows.Add(product.Id, product.CategoryId, product.ProductCode, product.ProductName, product.StandardCost, product.ListPrice, product.Description
                    );
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
                id = int.Parse(row.Cells["id_product"].Value.ToString());
                txtProductCode.Text = row.Cells["productcode"].Value.ToString();
                txtProductName.Text = row.Cells["productname"].Value.ToString();
                txtStandardCost.Text = row.Cells["standartcost"].Value.ToString();
                txtListPrice.Text = row.Cells["listprice"].Value.ToString();
                txtDescription.Text = row.Cells["decription"].Value.ToString();
                cbCategory.Text = row.Cells["category_id"].Value.ToString();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtProductCode.Text) || string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtDescription.Text))
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
        private Models.Product CreateProductFromInput()
        {
            if (cbCategory.SelectedValue == null)
            {
                MessageBox.Show("Không có giá trị nào được chọn", "Thông báo", MessageBoxButtons.OK);
                return null;
            }

            int categoryId = (int)cbCategory.SelectedValue;

            return new Models.Product
            {
                Id = id,
                ProductCode = txtProductCode.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                StandardCost = originalAmount,
                CategoryId = categoryId
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var product = CreateProductFromInput();
                if (_productController.Upsert(product))
                {
                    MessageBox.Show("Đã sản phâm vào kho thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var user = CreateProductFromInput();
                if (_productController.Delete(id))
                {
                    MessageBox.Show("Xoá sản phẩm khỏi kho thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
                else
                {
                    MessageBox.Show("Xoá sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK);
                    Showdata();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtProductCode.Clear();
            txtProductName.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtStandardCost.Clear();
            txtListPrice.Clear();
            cbCategory.SelectedIndex = -1;
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
                string searchKeyword = txtSearch.Text.Trim();
                var results = _productController.SearchByCodeOrName(searchKeyword);

                if (results.Count > 0)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("CategoryId", typeof(int));
                    dataTable.Columns.Add("ProductCode", typeof(string));
                    dataTable.Columns.Add("ProductName", typeof(string));
                    dataTable.Columns.Add("StandardCost", typeof(decimal));
                    dataTable.Columns.Add("ListPrice", typeof(decimal));
                    dataTable.Columns.Add("Description", typeof(string));

                    foreach (Models.Product product in results)
                    {
                        dataTable.Rows.Add(product.Id, product.CategoryId, product.ProductCode, product.ProductName, product.StandardCost, product.ListPrice, product.Description);
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
