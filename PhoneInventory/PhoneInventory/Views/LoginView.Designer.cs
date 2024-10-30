namespace PhoneWarehouse.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ShowPass = new CheckBox();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            buttonSignIn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(854, 270);
            label1.Name = "label1";
            label1.Size = new Size(198, 49);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Font = new Font("Segoe UI", 13F);
            ShowPass.Location = new Point(1083, 447);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(175, 34);
            ShowPass.TabIndex = 3;
            ShowPass.Text = "Hiện mật khẩu";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 15F);
            txtAccount.Location = new Point(835, 357);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(230, 41);
            txtAccount.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(835, 440);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 41);
            txtPassword.TabIndex = 5;
            // 
            // buttonSignIn
            // 
            buttonSignIn.Font = new Font("Segoe UI", 15F);
            buttonSignIn.Location = new Point(835, 494);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(230, 55);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Đăng Nhập";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(697, 357);
            label2.Name = "label2";
            label2.Size = new Size(120, 49);
            label2.TabIndex = 7;
            label2.Text = "Tài khoản";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(697, 436);
            label3.Name = "label3";
            label3.Size = new Size(120, 49);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(ShowPass);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox ShowPass;
        private TextBox txtAccount;
        private TextBox txtPassword;
        private Button buttonSignIn;
        private Label label2;
        private Label label3;
    }
}