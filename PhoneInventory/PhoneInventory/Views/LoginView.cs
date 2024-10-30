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
        private HomeView parentForm;
        private readonly UserController _userController; 
        public string Id_account { get; private set; }
        public LoginView(HomeView parent)
        {
            InitializeComponent();
            _userController = new UserController();
            parentForm = parent;
            txtPassword.PasswordChar = '*';
        }
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
        private void CloseOpenForms()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form != parentForm)
                {
                    formsToClose.Add(form);
                }
            }

            // Đóng các form trong danh sách
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            string role = _userController.Login(account, password);
            if (!string.IsNullOrEmpty(role))
            {
                parentForm.log = this; 
                int user_Id = _userController.GetUserIdByUsername(account);
                parentForm.Id_account = user_Id; 
                parentForm.UserRole = role;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.LoginToolStripMenuItem.Visible = false;
                parentForm.UpdateLoginStatus(true);
                CloseOpenForms(); 
                this.Hide();
            }
        }
    }
}
