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

namespace QuanLyKhachSan
{
    public partial class frmPhong : Form
    {
        private readonly roomServices roomServices = new roomServices();
        public frmPhong()
        {
            InitializeComponent();
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
                    Margin = new Padding(10) // Gap between cards
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

                // Add the card to the flow panel
                fpnlRoom.Controls.Add(card);
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