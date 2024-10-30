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
using BUS;

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmQLLoaiPhong : Form
    {
        private readonly roomTypeServices roomTypeServices = new roomTypeServices();
        public frmQLLoaiPhong()
        {
            InitializeComponent();
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            List<LoaiPhong> listRoomType = context.LoaiPhongs.ToList();
            BindGrid(listRoomType);

        }
        private void BindGrid(List<LoaiPhong> listRoomType)
        {
            dgvRoomType.Rows.Clear();
            foreach (var item in listRoomType)
            {
                int index = dgvRoomType.Rows.Add();
                dgvRoomType.Rows[index].Cells[0].Value = item.MaLoaiPhong;
                dgvRoomType.Rows[index].Cells[1].Value = item.TenLoaiPhong;
            }
        }

        private void dgvRoomType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoomType.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của DataGridView để hiển thị lên groupBox
                txtMLP.Texts = row.Cells[0].Value.ToString();
                txtTLP.Texts = row.Cells[1].Value.ToString();
            }
        }
        private bool ValidateInput()
        {
            // Clear all previous error messages
            err.Clear();

            // Validate room type ID (MaLoaiPhong) - must not be empty and should have exactly 3 characters
            if (string.IsNullOrEmpty(txtMLP.Texts) || txtMLP.Texts.Length != 4 || !txtMLP.Texts.StartsWith("LP") || !txtMLP.Texts.Substring(2).All(char.IsDigit))
            {
                MessageBox.Show("Mã loại phòng không hợp lệ. Vui lòng nhập mã gồm 4 ký tự: 'LP' theo sau là 2 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate room type name (TenLoaiPhong) - must be between 3 and 100 characters and contain only letters
            if (string.IsNullOrEmpty(txtTLP.Texts) || txtTLP.Texts.Length < 3 || txtTLP.Texts.Length > 100 || !txtTLP.Texts.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên loại phòng không hợp lệ. Vui lòng nhập tên từ 3 đến 100 ký tự và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Return true if all validations pass
        }
        
        private void ClearData()
        {
            txtMLP.Texts = "";
            txtTLP.Texts = "";
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    // Stop if input is not valid
                    return;
                }

                // Find the room type by ID, or create a new one if it doesn't exist
                var roomType = roomTypeServices.FindLocalById(txtMLP.Texts) ?? new LoaiPhong();

                // Set room type properties
                roomType.MaLoaiPhong = txtMLP.Texts;
                roomType.TenLoaiPhong = txtTLP.Texts;

                // Insert or update room type in the database
                roomTypeServices.InsertOrUpdate(roomType);

                // Refresh the grid with the updated list
                BindGrid(roomTypeServices.GetAll());

                // Clear form data after success
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding or updating room type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the room type by ID
                var roomType = roomTypeServices.FindLocalById(txtMLP.Texts);
                if (roomType == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Delete the room type
                    roomTypeServices.Delete(roomType);
                    MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    BindGrid(roomTypeServices.GetAll());
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa loại phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
