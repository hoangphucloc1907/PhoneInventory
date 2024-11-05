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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PhoneWarehouse.Views
{
    public partial class LoginView : Form
    {
        private readonly HomeView _parentForm;
        private readonly UserController _userController;
        public string Id_account { get; private set; } = string.Empty;

        public LoginView(HomeView parent)
        {
            InitializeComponent();
            _userController = new UserController();
            _parentForm = parent;
            txtPassword.PasswordChar = '*';
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ShowPass.Checked ? '\0' : '*';
        }

        private void CloseOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form != _parentForm)
                {
                    form.Close();
                }
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            var loginResult = _userController.Login(account, password);

            if (!string.IsNullOrEmpty(loginResult.role))
            {
                _parentForm.log = this;
                _parentForm.Id_account = loginResult.id;
                _parentForm.UserRole = loginResult.role;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.LoginToolStripMenuItem.Visible = false;
                _parentForm.UpdateLoginStatus(true);
                CloseOpenForms();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
