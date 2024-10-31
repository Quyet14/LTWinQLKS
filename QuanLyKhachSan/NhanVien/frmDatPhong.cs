using BUS;
using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.NhanVien
{
    public partial class frmDatPhong : Form
    {
        private readonly customerServices customerServices = new customerServices();
        private readonly employeeServices employeeServices = new employeeServices();
        private readonly bookingServices bookingServices = new bookingServices();
        private readonly string roomCode;
        private readonly decimal roomPrice;
        private readonly int loggedEmployeeId;
        private PhieuDatPhong currentBooking;
        public frmDatPhong(string roomCode, decimal roomPrice, int employeeId, bool isOccupied)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.roomCode = roomCode;
            this.roomPrice = roomPrice;
            this.loggedEmployeeId = employeeId;

            lblRoom.Text = roomCode;
            txtPrice.Texts = roomPrice.ToString("N");

            txtTenNV.Texts = employeeServices.GetEmployeeNameById(employeeId);

            if (isOccupied)
            {
                LoadBookingInformation();
                SetupOccupiedRoomView();
            }
            else
            {
                SetupEmptyRoomView();
            }
        }
        private void LoadBookingInformation()
        {
            currentBooking = bookingServices.GetCurrentBookingForRoom(roomCode);
            if (currentBooking != null)
            {
                var customer = customerServices.GetCustomerById(currentBooking.MaKhachHang);
                txtCustomerId.Texts = customer.SoDienThoai;
                txtCustomerName.Texts = customer.HoTen;
                dtpCheckOut.Value = (DateTime)currentBooking.NgayTraPhong;
                // Disable date pickers when room is occupied
                dtpCheckOut.Enabled = false;
            }
        }

        private void SetupOccupiedRoomView()
        {
            // Disable editing for occupied rooms
            txtCustomerId.Enabled = false;
            txtCustomerName.Enabled = false;
            btnSave.Visible = false;
            btnSearch.Visible = false;

            
        }

        private void SetupEmptyRoomView()
        {
            // Enable editing for empty rooms
            txtCustomerId.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Visible = true;
            dtpCheckOut.Enabled = true;
            btnCheckOut.Visible = false;

            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (currentBooking != null)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn check-out phòng này?",
                    "Xác nhận Check-out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bookingServices.CheckOut(currentBooking.MaPhieu, roomPrice))
                    {
                        // Calculate and display the final amount
                        var updatedBooking = bookingServices.GetCurrentBookingForRoom(roomCode);
                        MessageBox.Show(
                            $"Check-out thành công!\nTổng tiền: {updatedBooking.TongTien:N0} VND",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi check-out.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtCustomerId.Texts.Trim();

            // Use customerServices to search by phone number
            KhachHang customer = customerServices.FindCustomerByPhone(phoneNumber);

            if (customer != null)
            {
                // Display the customer’s name in txtCustomerName
                txtCustomerName.Texts = customer.HoTen;
            }
            else
            {
                // Clear the customer name field if not found
                txtCustomerName.Texts = string.Empty;
                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
            }
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerId.Texts))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var customer = customerServices.FindCustomerByPhone(txtCustomerId.Texts.Trim());
                if (customer == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var booking = new PhieuDatPhong
                {
                    MaKhachHang = customer.MaKhachHang,
                    MaPhong = lblRoom.Text,
                    NgayDatPhong = DateTime.Now,
                    NgayTraPhong = dtpCheckOut.Value,
                    MaNhanVien = loggedEmployeeId
                };

                string errorMessage;
                if (bookingServices.CreateBooking(booking, roomPrice, out errorMessage))
                {
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Đặt phòng thất bại! {errorMessage}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày trả phòng phải sau thời điểm hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCheckOut.Value = DateTime.Now.AddDays(1);
            }
        }
    }
}
