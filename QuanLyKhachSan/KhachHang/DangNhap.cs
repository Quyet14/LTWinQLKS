using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập cả tên đăng nhập và mật khẩu.");
                return;
            }

            // Placeholder for user authentication (replace with real authentication logic)
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Login successful, open main form
                TrangChinh mainForm = new TrangChinh();
                mainForm.Show();

                DichVu dichVuForm = new DichVu();
                dichVuForm.MdiParent = mainForm;
                dichVuForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ. Vui lòng thử lại.");
            }
        }

        // Placeholder for user authentication logic
        private bool AuthenticateUser(string username, string password)
        {
            using (var dbContext = new Model1())
            {
                var user = dbContext.Users.Where(u => u.username == username && u.password == password).FirstOrDefault();

                return user != null;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Paint(object sender, PaintEventArgs e)
        {
            this.Paint += new PaintEventHandler(set_background);
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 79, 148), Color.FromArgb(57, 128, 227), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        

    }
}
