using BUS;
using DoAnN6_QLKS_DAL.Entity;
using QuanLyKhachSan.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.NhanVien;

namespace QuanLyKhachSan
{
    public partial class frmPhong : Form
    {
        private readonly roomServices roomServices = new roomServices();
        private frmDatPhong activeBookingDialog = null;
        private int employeeId { get; set; }
        public frmPhong(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadRooms();
        }
        private void LoadRooms(string filter = null)
        {
            // Get all rooms from the database
            List<Phong> rooms = roomServices.GetAll();

            // Apply the filter if one is specified
            if (!string.IsNullOrEmpty(filter))
            {
                rooms = rooms.Where(room => room.LoaiTinhTrangPhong?.TenTinhTrang == filter).ToList();
            }
            rooms = rooms.Where(room => room.LoaiTinhTrangPhong?.TenTinhTrang != "Sửa chữa").ToList();

            // Clear any existing controls
            fpnlRoom.Controls.Clear();

            // Configure flow layout panel spacing
            fpnlRoom.Padding = new Padding(10);
            fpnlRoom.AutoScroll = true;

            foreach (var room in rooms)
            {
                // Create a new CardRoom
                CardRoom card = new CardRoom
                {
                    Size = new System.Drawing.Size(200, 120), // Smaller card size
                    Margin = new Padding(10), // Gap between cards
                    MaPhong = room.MaPhong
                };

                // Set room ID
                card.lblRoom.Text = room.MaPhong;

                // Set status based on TenTinhTrang
                card.RoomStatus = room.LoaiTinhTrangPhong?.TenTinhTrang;

                switch (card.RoomStatus)
                {
                    case "Phòng trống":
                        card.iconTinhTrang.IconChar = FontAwesome.Sharp.IconChar.Check;
                        card.iconTinhTrang.IconColor = System.Drawing.Color.Lime;
                        break;

                    case "Đang được sử dụng":
                        card.iconTinhTrang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
                        card.iconTinhTrang.IconColor = System.Drawing.Color.White;
                        break;

                    default:
                        card.iconTinhTrang.IconChar = FontAwesome.Sharp.IconChar.Broom;
                        card.iconTinhTrang.IconColor = System.Drawing.Color.SaddleBrown;
                        break;
                }
                card.CardClicked += CardRoom_CardClicked;

                fpnlRoom.Controls.Add(card);
            }
        }
        private void CardRoom_CardClicked(object sender, string maPhong)
        {
            CardRoom clickedCard = sender as CardRoom;

            // If the room is being cleaned, don't open any dialog
            if (clickedCard != null && clickedCard.RoomStatus == "Đang vệ sinh")
            {
                MessageBox.Show("Room is cleaning!.");
                return; // Do nothing for rooms being cleaned
            }

            // Check if there's already an active booking dialog
            if (activeBookingDialog != null && !activeBookingDialog.IsDisposed)
            {
                activeBookingDialog.Focus(); // Bring existing dialog to front
                return;
            }

            Phong room = roomServices.FindRoomById(maPhong);

            if (room != null)
            {
                try
                {
                    bool isOccupied = clickedCard.RoomStatus == "Đang được sử dụng";
                    activeBookingDialog = new frmDatPhong(room.MaPhong, room.GiaPhong, employeeId, isOccupied);

                    activeBookingDialog.FormClosed += (s, args) =>
                    {
                        activeBookingDialog = null; // Clear the reference when form is closed
                        LoadRooms(); // Refresh the room list after booking
                    };
                    activeBookingDialog.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening booking dialog: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeBookingDialog = null;
                }
            }
            else
            {
                MessageBox.Show("Room not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rbtnRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRoom.Checked)
            {
                LoadRooms("Phòng trống");  // Only show available rooms
            }
        }

        private void rbtnBooked_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBooked.Checked)
            {
                LoadRooms("Đang được sử dụng");  // Only show booked rooms
            }
        }

        private void rbtnRoomCleaning_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRoomCleaning.Checked)
            {
                LoadRooms("Đang vệ sinh");  // Only show rooms in cleaning status
            }
        }
    }
}