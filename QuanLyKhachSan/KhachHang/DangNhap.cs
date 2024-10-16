using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public bool IsLoginSuccessful { get; internal set; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Get username and password from text boxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if username and password are correct
            // For demonstration purposes, we'll assume the correct credentials are "admin" and "password"
            if (username == "admin" && password == "password")
            {
                // Login successful, open main form
                TrangChinh mainForm = new TrangChinh();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
