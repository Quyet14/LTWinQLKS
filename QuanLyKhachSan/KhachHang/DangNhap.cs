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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public bool IsLoginSuccessful { get; internal set; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Get username and password from text boxes
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if username and password are correct
            // For demonstration purposes, we'll assume the correct credentials are "admin" and "password"
            if (username == "1" && password == "1")
            {
                MessageBox.Show("Login successful, opening TrangChinh form");
                // Login successful, open main form

                IsLoginSuccessful = true;
                this.DialogResult = DialogResult.OK;
                this.Close();

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
