using DoAnN6_QLKS_DAL;
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập cả tên đăng nhập và mật khẩu.");
                return;
            }

            // Authenticate user
            if (AuthenticateUser(username, password))
            {
                // Login successful, open frmHoaDon
                frmHoaDon hoaDonForm = new frmHoaDon();
                hoaDonForm.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ. Vui lòng thử lại.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            using (var dbContext = new Model2())
            {
                // Ensure you are querying the correct DbSet and property names
                var user = dbContext.DangNhaps.FirstOrDefault(u => u.Username == username && u.Password == password);

                return user != null;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

    }
}
