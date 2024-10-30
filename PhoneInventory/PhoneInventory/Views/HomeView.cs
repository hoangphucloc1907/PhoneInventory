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
    //Stockin, out: số phiếu, nhà cc
    public partial class HomeView : Form
    {
        private bool isLoggedIn = false;
        public LoginView log;
        public string UserRole { get; set; }
        public int Id_account { get; set; }

        public HomeView()
        {
            InitializeComponent();
            LogoutToolStripMenuItem.Visible = false;
        }
        public void UpdateLoginStatus(bool status)
        {
            isLoggedIn = status;
            LogoutToolStripMenuItem.Visible = status;
            LoginToolStripMenuItem.Visible = !status;
        }
        public void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginView log = new LoginView(this);
            log.MdiParent = this;
            log.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            isLoggedIn = false;
            UpdateLoginStatus(isLoggedIn);

            Id_account = 0;
            UserRole = string.Empty;

            LoginView log = new LoginView(this);
            log.MdiParent = this;
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            UserView us = new UserView(UserRole);
            us.MdiParent = this;
            us.Show();
            //}
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            ProductView product = new ProductView();
            product.MdiParent = this;
            product.Show();
            //}
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            ImportView im = new ImportView(Id_account);
            im.MdiParent = this;
            im.Show();
            //}
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            ExportView ex = new ExportView(Id_account);
            ex.MdiParent = this;
            ex.Show();
            //}
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            SupplierView sup = new SupplierView();
            sup.MdiParent = this;
            sup.Show();
            //}
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            CustomerView cus = new CustomerView();
            cus.MdiParent = this;
            cus.Show();
            //}
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (!isLoggedIn)
            //{
            //    MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Login log = new Login(this);
            //    log.MdiParent = this;
            //    log.Show();
            //}
            //else
            //{
            CategoryView category = new CategoryView();
            category.MdiParent = this;
            category.Show();
            //}
        }
    }
}
