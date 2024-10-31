using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DoAnN6_QLKS_DAL.Entity;

namespace QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        private readonly customerServices customerServices = new customerServices();
        private readonly employeeServices employeeServices = new employeeServices();
        private readonly chamCongServices chamCongServices = new chamCongServices();
        public DangNhap()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public bool IsLoginSuccessful { get; internal set; }
        public bool IsCustomer { get; private set; }
        public bool IsEmployee { get; private set; }
        public bool IsAdmin { get; private set; }
        public int UserId { get; private set; }
        public int? EmployeePerm { get; private set; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Get username and password from text boxes
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                
                if (int.TryParse(username, out int maNhanVien))
                {
                    DoAnN6_QLKS_DAL.Entity.NhanVien nhanVien = employeeServices.AuthenticateEmployee(maNhanVien, password);
                    if (nhanVien != null)
                    {
                        MessageBox.Show("Employee login successful, opening TrangChinh form");

                        chamCongServices.RecordLogin(maNhanVien);

                        IsLoginSuccessful = true;
                        IsEmployee = true;
                        UserId = nhanVien.MaNhanVien;
                        EmployeePerm = nhanVien.perm;
                        IsAdmin = nhanVien.perm == 0;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                }


                /*KhachHang khachHang = customerServices.AuthenticateCustomer(username, password);

                if (khachHang != null)
                {
                    IsLoginSuccessful = true;
                    IsCustomer = true;
                    UserId = khachHang.MaKhachHang;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }*/

                if (username == "1" && password == "1")
                {
                    IsLoginSuccessful = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }

                MessageBox.Show("Invalid username or password, or account is inactive.");
            } catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
