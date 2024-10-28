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

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmQLPhong : Form
    {
        private roomServices roomService = new roomServices();
        public frmQLPhong()
        {
            InitializeComponent();
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            List<Phong> listRoom = context.Phongs.ToList();
            List<LoaiPhong> listRoomType = context.LoaiPhongs.ToList();
            List<LoaiTinhTrangPhong> listStatus = context.LoaiTinhTrangPhongs.ToList();
            BindGrid(listRoom);
            FillRoomTypeCombobox(listRoomType);
            FillStatusCombobox(listStatus);
        }

        private void BindGrid(List<Phong> listRoom)
        {
            dgvRoom.Rows.Clear();
            foreach (var item in listRoom)
            {
                int index = dgvRoom.Rows.Add();
                dgvRoom.Rows[index].Cells[0].Value = item.MaPhong;
                dgvRoom.Rows[index].Cells[1].Value = item.LoaiPhong.TenLoaiPhong;
                dgvRoom.Rows[index].Cells[2].Value = item.GiaPhong;
                dgvRoom.Rows[index].Cells[3].Value = item.LoaiTinhTrangPhong.TenTinhTrang;
            }
        }
        private void FillRoomTypeCombobox(List<LoaiPhong> listRoomType)
        {
            this.cmbTLP.DataSource = listRoomType;
            this.cmbTLP.DisplayMember = "TenLoaiPhong";
            this.cmbTLP.ValueMember = "MaLoaiPhong";
            this.cmbTLP1.DataSource = listRoomType;
            this.cmbTLP1.DisplayMember = "TenLoaiPhong";
            this.cmbTLP1.ValueMember = "MaLoaiPhong";
        }
        private void FillStatusCombobox(List<LoaiTinhTrangPhong> listStatus)
        {
            this.cmbStatus.DataSource = listStatus;
            this.cmbStatus.DisplayMember = "TenTinhTrang";
            this.cmbStatus.ValueMember = "MaTinhTrang";
        }
        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoom.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của DataGridView để hiển thị lên groupBox
                txtMTP.Texts = row.Cells[0].Value.ToString();
                cmbTLP.Text = row.Cells[1].Value.ToString();
                txtPrice.Texts = row.Cells[2].Value.ToString();
                cmbStatus.Text = row.Cells[3].Value.ToString();
            }
        }
        private bool ValidateInput()
        {

            // Validate room type ID (MaLoaiPhong) - must not be empty and should have exactly 3 characters
            if (string.IsNullOrEmpty(txtMTP.Texts) || txtMTP.Texts.Length != 4 || !txtMTP.Texts.StartsWith("P") || !txtMTP.Texts.Substring(3).All(char.IsDigit))
            {
                MessageBox.Show("Mã phòng không hợp lệ. Vui lòng nhập mã gồm 4 ký tự: 'P' theo sau là 3 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Return true if all validations pass
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var room = roomService.FindRoomById(txtMTP.Texts);
                if (room == null)
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    roomService.Delete(room);

                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid after deleting
                    BindGrid(roomService.GetAll());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Search for rooms based on the selected room type in cmbTLP
                string selectedRoomType = cmbTLP.SelectedValue.ToString();
                List<Phong> filteredRooms = roomService.GetAll().Where(r => r.MaLoaiPhong == selectedRoomType).ToList();

                if (filteredRooms.Any())
                {
                    BindGrid(filteredRooms);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng nào với loại phòng đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid(roomService.GetAll()); // Show all rooms if no match is found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return; // Exit the method if the validation fails
            }
            try
            {
                // Retrieve or create a new room object
                var room = roomService.FindRoomById(txtMTP.Texts) ?? new Phong();

                room.MaPhong = txtMTP.Texts;
                room.MaLoaiPhong = cmbTLP.SelectedValue.ToString();
                room.GiaPhong = decimal.Parse(txtPrice.Texts);
                room.MaTinhTrang = cmbStatus.SelectedValue.ToString();

                // Insert or update the room in the database
                roomService.InsertOrUpdate(room);

                // Refresh the grid after adding/updating
                BindGrid(roomService.GetAll());

                MessageBox.Show("Lưu thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm/cập nhật phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEmpty_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // If the checkbox is checked, show only rooms with status "Phòng trống"
                if (checkEmpty.Checked)
                {
                    // Filter rooms with status "Phòng trống"
                    List<Phong> emptyRooms = roomService.GetAll().Where(r => r.LoaiTinhTrangPhong.TenTinhTrang == "Phòng trống").ToList();

                    if (emptyRooms.Any())
                    {
                        BindGrid(emptyRooms); // Show the filtered list in the grid
                    }
                    else
                    {
                        MessageBox.Show("Không có phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid(roomService.GetAll()); // Optionally, show all rooms if no empty rooms are found
                    }
                }
                else
                {
                    // If unchecked, show all rooms
                    BindGrid(roomService.GetAll());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm phòng trống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
