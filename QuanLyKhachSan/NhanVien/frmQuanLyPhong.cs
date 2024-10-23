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
    public partial class frmQuanLyPhong : Form
    {
        public frmQuanLyPhong()
        {
            InitializeComponent();
            InitializeDataTable();
            dgvBookings.DataSource = bookingTable;
        }

        private void InitializeDataTable()
        {
            //thêm cột cho dgv
            bookingTable = new DataTable();
            bookingTable.Columns.Add("Tên khách hàng", typeof(string));
            bookingTable.Columns.Add("Số điện thoại", typeof(string));
            bookingTable.Columns.Add("Loại phòng", typeof(string));
            bookingTable.Columns.Add("Loại giường", typeof(string));
            bookingTable.Columns.Add("Ngày nhận", typeof(DateTime));
            bookingTable.Columns.Add("Ngày trả", typeof(DateTime));
            bookingTable.Columns.Add("Giá tiền", typeof(decimal));
        }

        // Phương thức xóa thông tin sau khi thêm
        private void ClearInputs()
        {
            txtCustomerName.Text = string.Empty; // Use Text property
            txtPhoneNumber.Text = string.Empty; // Use Text property
            cmbRoomType.SelectedIndex = -1;
            cmbBedType.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            txtPrice.Text = string.Empty; // Use Text property
        }

        private void DeleteBooking(string customerName = null, string phoneNumber = null)
        {
            // Xác nhận trước khi xóa
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng không?",
                                                 "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return; // Nếu người dùng chọn không, thoát khỏi hàm
            }

            // Kiểm tra nếu không có tên hoặc số điện thoại
            if (string.IsNullOrEmpty(customerName) && string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng hoặc số điện thoại để xóa.");
                return;
            }

            // Tìm kiếm các dòng cần xóa
            string filterExpression = "";
            if (!string.IsNullOrEmpty(customerName))
            {
                filterExpression += $"[Tên khách hàng] = '{customerName}'";
            }
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " OR "; // Nếu đã có điều kiện trước đó, nối thêm
                }
                filterExpression += $"[Số điện thoại] = '{phoneNumber}'";
            }

            // Lấy các dòng cần xóa
            DataRow[] rowsToDelete = bookingTable.Select(filterExpression);

            if (rowsToDelete.Length == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng để xóa.");
                return;
            }

            // Xóa từng dòng tìm thấy
            foreach (DataRow row in rowsToDelete)
            {
                bookingTable.Rows.Remove(row);
            }

            // Cập nhật lại DataGridView
            dgvBookings.DataSource = null; // Đặt lại DataSource
            dgvBookings.DataSource = bookingTable; // Gán lại DataSource
            MessageBox.Show("Đã xóa thông tin khách hàng.");
        }
       
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ hàng được chọn lên các textbox và combobox
                txtCustomerName.Text = row.Cells[0].Value.ToString();
                txtPhoneNumber.Text = row.Cells[1].Value.ToString();
                cmbRoomType.SelectedItem = row.Cells[2].Value.ToString();
                cmbBedType.SelectedItem = row.Cells[3].Value.ToString();

                // Kiểm tra và chuyển đổi giá trị ngày
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime checkInDate))
                {
                    dtpCheckIn.Value = checkInDate;
                }
                else
                {
                    MessageBox.Show("Ngày nhận phòng không hợp lệ.");
                }

                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime checkOutDate))
                {
                    dtpCheckOut.Value = checkOutDate;
                }
                else
                {
                    MessageBox.Show("Ngày trả phòng không hợp lệ.");
                }

                txtPrice.Text = row.Cells[6].Value.ToString();
            }
        }

       

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                cmbRoomType.SelectedIndex == -1 || cmbBedType.SelectedIndex == -1 ||
                dtpCheckIn.Value == null || dtpCheckOut.Value == null || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra số điện thoại chỉ được nhập số
            if (!long.TryParse(txtPhoneNumber.Text, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số.");
                return;
            }

            // Kiểm tra ngày nhận phòng phải nhỏ hơn ngày trả phòng
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Ngày nhận phòng phải nhỏ hơn ngày trả phòng.");
                return;
            }

            // Kiểm tra giá tiền chỉ được nhập số
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Giá tiền chỉ được nhập số.");
                return;
            }

            // Thêm dữ liệu vào DataTable
            bookingTable.Rows.Add(txtCustomerName.Text, txtPhoneNumber.Text, cmbRoomType.SelectedItem.ToString(),
                                  cmbBedType.SelectedItem.ToString(), dtpCheckIn.Value, dtpCheckOut.Value, decimal.Parse(txtPrice.Text));

            // Xóa dữ liệu sau khi thêm
            ClearInputs();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nhập đầy đủ thông tin
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                cmbRoomType.SelectedIndex == -1 || cmbBedType.SelectedIndex == -1 ||
                dtpCheckIn.Value == null || dtpCheckOut.Value == null || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra số điện thoại chỉ được nhập số
            if (!long.TryParse(txtPhoneNumber.Text, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số.");
                return;
            }

            // Kiểm tra ngày nhận phòng phải nhỏ hơn ngày trả phòng
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Ngày nhận phòng phải nhỏ hơn ngày trả phòng.");
                return;
            }

            // Kiểm tra giá tiền chỉ được nhập số
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Giá tiền chỉ được nhập số.");
                return;
            }

            // Kiểm tra trùng lặp thông tin
            bool isDuplicate = false;
            foreach (DataRow row in bookingTable.Rows)
            {
                // So sánh thông tin khách hàng và các thông tin khác
                string customerName = row["Tên khách hàng"].ToString();
                string phoneNumber = row["Số điện thoại"].ToString();
                string roomType = row["Loại phòng"].ToString();
                string bedType = row["Loại giường"].ToString();
                DateTime checkInDate = Convert.ToDateTime(row["Ngày nhận"]);
                DateTime checkOutDate = Convert.ToDateTime(row["Ngày trả"]);

                // Kiểm tra trùng lặp toàn bộ thông tin
                if (customerName == txtCustomerName.Text &&
                    phoneNumber == txtPhoneNumber.Text &&
                    roomType == cmbRoomType.SelectedItem.ToString() &&
                    bedType == cmbBedType.SelectedItem.ToString() &&
                    checkInDate.Date == dtpCheckIn.Value.Date &&
                    checkOutDate.Date == dtpCheckOut.Value.Date)
                {
                    isDuplicate = true;
                    break; // Dừng kiểm tra nếu tìm thấy thông tin trùng
                }
            }

            // Nếu có thông tin trùng lặp, thông báo và dừng lại
            if (isDuplicate)
            {
                MessageBox.Show("Thông tin đặt phòng đã tồn tại.");
                return;
            }

            // Thêm dữ liệu vào DataTable nếu không có thông tin trùng lặp
            bookingTable.Rows.Add(txtCustomerName.Text, txtPhoneNumber.Text, cmbRoomType.SelectedItem.ToString(),
                                  cmbBedType.SelectedItem.ToString(), dtpCheckIn.Value, dtpCheckOut.Value, decimal.Parse(txtPrice.Text));

            MessageBox.Show("Thêm thông tin thành công!");

            // Xóa dữ liệu sau khi thêm
            ClearInputs();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Lấy tên khách hàng và số điện thoại từ các textbox
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;

            // Gọi hàm xóa với tên khách hàng hoặc số điện thoại
            DeleteBooking(customerName, phoneNumber);
        }

        private void txtCustomerName__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
