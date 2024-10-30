﻿namespace PhoneWarehouse.Views
{
    partial class HomeView
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
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            LoginToolStripMenuItem = new ToolStripMenuItem();
            LogoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem1 = new ToolStripMenuItem();
            phiếuNhậppdfToolStripMenuItem = new ToolStripMenuItem();
            phiếuXuấtpdfToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem, reportToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoginToolStripMenuItem, LogoutToolStripMenuItem, exitToolStripMenuItem });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(85, 24);
            aToolStripMenuItem.Text = "Hệ thống";
            // 
            // LoginToolStripMenuItem
            // 
            LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            LoginToolStripMenuItem.Size = new Size(224, 26);
            LoginToolStripMenuItem.Text = "Đăng nhập";
            LoginToolStripMenuItem.Click += LoginToolStripMenuItem_Click;
            // 
            // LogoutToolStripMenuItem
            // 
            LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            LogoutToolStripMenuItem.Size = new Size(224, 26);
            LogoutToolStripMenuItem.Text = "Đăng xuất";
            LogoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productToolStripMenuItem, importToolStripMenuItem, exportToolStripMenuItem, supplierToolStripMenuItem, employeeToolStripMenuItem, customerToolStripMenuItem, categoryToolStripMenuItem1 });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(73, 24);
            manageToolStripMenuItem.Text = "Quản lý";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(183, 26);
            productToolStripMenuItem.Text = "Tồn kho";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(183, 26);
            importToolStripMenuItem.Text = "Phiếu nhập";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(183, 26);
            exportToolStripMenuItem.Text = "Phiếu xuất";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(183, 26);
            supplierToolStripMenuItem.Text = "Nhà cung cấp";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(183, 26);
            employeeToolStripMenuItem.Text = "Nhân viên";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(183, 26);
            customerToolStripMenuItem.Text = "Khách hàng";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem1
            // 
            categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            categoryToolStripMenuItem1.Size = new Size(183, 26);
            categoryToolStripMenuItem1.Text = "Danh mục";
            categoryToolStripMenuItem1.Click += categoryToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(78, 24);
            helpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(175, 26);
            aboutToolStripMenuItem.Text = "Về chúng tôi";
            // 
            // reportToolStripMenuItem1
            // 
            reportToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { phiếuNhậppdfToolStripMenuItem, phiếuXuấtpdfToolStripMenuItem });
            reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            reportToolStripMenuItem1.Size = new Size(77, 24);
            reportToolStripMenuItem1.Text = "Báo cáo";
            // 
            // phiếuNhậppdfToolStripMenuItem
            // 
            phiếuNhậppdfToolStripMenuItem.Name = "phiếuNhậppdfToolStripMenuItem";
            phiếuNhậppdfToolStripMenuItem.Size = new Size(201, 26);
            phiếuNhậppdfToolStripMenuItem.Text = "Phiếu nhập(.pdf)";
            // 
            // phiếuXuấtpdfToolStripMenuItem
            // 
            phiếuXuấtpdfToolStripMenuItem.Name = "phiếuXuấtpdfToolStripMenuItem";
            phiếuXuấtpdfToolStripMenuItem.Size = new Size(201, 26);
            phiếuXuấtpdfToolStripMenuItem.Text = "Phiếu xuất(.pdf)";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem LogoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậppdfToolStripMenuItem;
        private ToolStripMenuItem phiếuXuấtpdfToolStripMenuItem;
        public ToolStripMenuItem LoginToolStripMenuItem;
    }
}