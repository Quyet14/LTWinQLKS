using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.Components
{
    public partial class CardRoom : UserControl
    {
        private string roomStatus;

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
            this.panelCard.MouseEnter += panelCard_MouseEnter;
            this.panelCard.MouseLeave += panelCard_MouseLeave;
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
            // Return to default color on leave
            Point mousePos = panelCard.PointToClient(Control.MousePosition);
            if (!panelCard.ClientRectangle.Contains(mousePos))
            {
                UpdateBackgroundColor();
            }
           
        }
    }
}
