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
        private bool _isLoggedIn = false;
        public LoginView log { get; set; }
        public string UserRole { get; set; } = string.Empty;
        public int Id_account { get; set; }

        public HomeView()
        {
            InitializeComponent();
            SetInitialControlStates();
        }

        private void SetInitialControlStates()
        {
            LogoutToolStripMenuItem.Visible = false;
            manageToolStripMenuItem.Enabled = false;
            reportToolStripMenuItem1.Enabled = false;
        }

        public void UpdateLoginStatus(bool status)
        {
            _isLoggedIn = status;
            LogoutToolStripMenuItem.Visible = status;
            LoginToolStripMenuItem.Visible = !status;
            manageToolStripMenuItem.Enabled = status;
            reportToolStripMenuItem1.Enabled = status;
            employeeToolStripMenuItem.Visible = status && UserRole != "Employee";
        }

        public void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginView();
        }

        private void ShowLoginView()
        {
            var log = new LoginView(this)
            {
                MdiParent = this
            };
            log.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloseAllMdiChildren();
            ResetLoginStatus();
            ShowLoginView();
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void ResetLoginStatus()
        {
            _isLoggedIn = false;
            UpdateLoginStatus(_isLoggedIn);
            Id_account = 0;
            UserRole = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmExit())
            {
                Close();
            }
        }

        private bool ConfirmExit()
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new UserView(UserRole));
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new ProductView());
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new ImportView(Id_account));
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new ExportView(Id_account));
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new SupplierView());
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowView(new CustomerView());
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowView(new CategoryView());
        }

        private void ShowView(Form view)
        {
            view.MdiParent = this;
            view.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement manage functionality here
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Implement report functionality here
        }
    }
}
