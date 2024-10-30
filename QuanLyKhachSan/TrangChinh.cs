﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenKhanhLong_qlks;
using QuanLyKhachSan.Khachhang;
using QuanLyKhachSan.QuanLy;

namespace QuanLyKhachSan
{
    public partial class TrangChinh : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public int UserId { get; private set; }
        public string UserType { get; private set; }

        public TrangChinh()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 99);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(126, 245, 249);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 120, 215);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(20, 0, 0, 0);
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 153, 255);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ShowLoginForm()
        {
            DangNhap loginForm = new DangNhap();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK && loginForm.IsLoginSuccessful)
            {
                this.Show();

                if (loginForm.IsEmployee)
                {
                    UserId = loginForm.UserId;
                    UserType = loginForm.EmployeePerm == 0 ? "Admin" : "Employee";
                }
                else if (loginForm.IsCustomer)
                {
                    UserId = loginForm.UserId;
                    UserType = "Customer";
                }

                ConfigureButtonsForUserType();
            }
            else
            {
                Application.Exit();
            }
        }
        private void ConfigureButtonsForUserType()
        {
            // Reset visibility for all buttons
            btn1.Visible = btn2.Visible = btn3.Visible = btn4.Visible = btn5.Visible = false;

            switch (UserType)
            {
                case "Customer":
                    // Only show buttons 1-3 for customers
                    btn1.Visible = btn2.Visible = btn3.Visible = true;

                    //btn1.Click += (s, e) =>
                    //{
                    //    ActivateButton(btn1, RGBColors.color);
                    //    OpenChildForm(new frmDichVu());
                    //};
                    btn2.Click += (s, e) =>
                    {
                        ActivateButton(btn2, RGBColors.color); 
                        OpenChildForm(new frmHoaDon());
                    };
                    btn3.Click += (s, e) =>
                    {
                        ActivateButton(btn3, RGBColors.color); 
                        OpenChildForm(new frmDanhGia());
                    };
                    break;

                case "Employee":
                    // Only show buttons 1-2 for normal employees
                    btn1.Visible = btn2.Visible = true;

                    //btn1.Click += (s, e) =>
                    //{
                    //    ActivateButton(btn1, RGBColors.color); 
                    //    OpenChildForm(new frmKhachHang());
                    //};
                    btn2.Click += (s, e) =>
                    {
                        ActivateButton(btn2, RGBColors.color);
                        OpenChildForm(new frmPhong());
                    };
                    break;

                case "Admin":
                    // Show all buttons for admin
                    btn1.Visible = btn2.Visible = btn3.Visible = btn4.Visible = btn5.Visible = true;

                    btn1.Click += (s, e) =>
                    {
                        ActivateButton(btn1, RGBColors.color);
                        OpenChildForm(new frmQLPhong());
                    };
                    btn2.Click += (s, e) =>
                    {
                        ActivateButton(btn2, RGBColors.color); 
                        OpenChildForm(new frmQLLoaiPhong());
                    };
                    //btn3.Click += (s, e) =>
                    //{
                    //    ActivateButton(btn3, RGBColors.color);
                    //    OpenChildForm(new frmQLDichVu());
                    //};
                    btn4.Click += (s, e) =>
                    {
                        ActivateButton(btn4, RGBColors.color);
                        OpenChildForm(new frmNhanVien());
                    };
                    btn5.Click += (s, e) =>
                    {
                        ActivateButton(btn5, RGBColors.color); 
                        OpenChildForm(new frmQLDanhGia());
                    };
                    break;
            }
        }

        private void TrangChinh_Load_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main form initially
            ShowLoginForm();
        }

        private void TrangChinh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}