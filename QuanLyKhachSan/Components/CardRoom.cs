using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Components
{
    public partial class CardRoom : UserControl
    {
        private string roomStatus;
        public event EventHandler<string> CardClicked;
        public string MaPhong { get; set; }
        public string RoomStatus
        {
            get => roomStatus;
            set
            {
                roomStatus = value;
                UpdateBackgroundColor(); // Update the initial color based on room status
            }
        }

        public CardRoom()
        {
            InitializeComponent();
            AttachClickEventToControls(this);
        }
        private void AttachClickEventToControls(Control control)
        {
            // Add click event to each control inside the UserControl
            control.Click += CardRoom_Click;
            foreach (Control child in control.Controls)
            {
                AttachClickEventToControls(child);  // Recursively attach to all child controls
            }
        }

        private void UpdateBackgroundColor()
        {
            // Set default color based on RoomStatus
            switch (RoomStatus)
            {
                case "Phòng trống":
                    this.panelCard.BackColor = Color.FromArgb(0, 174, 255);
                    break;
                case "Đang được sử dụng":
                    this.panelCard.BackColor = Color.DeepPink;
                    break;
                default:
                    this.panelCard.BackColor = Color.Orange;
                    break;
            }
        }

        private void panelCard_MouseEnter(object sender, EventArgs e)
        {
            // Lighter color on hover based on RoomStatus
            switch (RoomStatus)
            {
                case "Phòng trống":
                    this.panelCard.BackColor = Color.FromArgb(42, 201, 255);
                    break;
                case "Đang được sử dụng":
                    this.panelCard.BackColor = Color.HotPink;
                    break;
                default:
                    this.panelCard.BackColor = Color.FromArgb(255, 199, 0);
                    break;
            }
        }

        private void panelCard_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = panelCard.PointToClient(Control.MousePosition);
            if (!panelCard.ClientRectangle.Contains(mousePos))
            {
                UpdateBackgroundColor();
            }
           
        }
        private void CardRoom_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, MaPhong);
        }
    }
}
