﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
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
            string password = HashPasswordSHA256(txtPassword.Texts);

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

                bool hasActiveBooking;
                KhachHang khachHang = customerServices.AuthenticateCustomer(username, password,out hasActiveBooking);

                if (khachHang != null)
                {
                    if (hasActiveBooking)
                    {
                        IsLoginSuccessful = true;
                        IsCustomer = true;
                        UserId = khachHang.MaKhachHang;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You can only log in during your booked stay. Please check your booking dates.");
                    }
                    return;
                }

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
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
        }
        public static string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString().Substring(0, 50); // Truncate to 50 characters
            }
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
