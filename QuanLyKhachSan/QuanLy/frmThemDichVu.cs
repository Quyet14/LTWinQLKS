using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Theemdv_Quan_Ly_Khach_San
{
    public partial class frmThemDichVu : Form
    {
        // Danh sách dịch vụ mẫu
        private List<DichVu> danhSachDichVu = new List<DichVu>
        {
            new DichVu { MaDichVu = "DV001", TenDichVu = "Dịch vụ 1", DonGia = 10000 },
            new DichVu { MaDichVu = "DV002", TenDichVu = "Dịch vụ 2", DonGia = 20000 },
            new DichVu { MaDichVu = "DV003", TenDichVu = "Dịch vụ 3", DonGia = 30000 },
        };

        public frmThemDichVu()
        {
            InitializeComponent();
            LoadDichVu();
            InitializeDataGridView();
        }

        private void LoadDichVu()
        {
            cbxDichVu.DataSource = danhSachDichVu;
            cbxDichVu.DisplayMember = "TenDichVu";
            cbxDichVu.ValueMember = "MaDichVu";
        }

        private void InitializeDataGridView()
        {
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.Columns.Clear();

            // Tạo cột cho DataGridView
            dgvGioHang.Columns.Add("MaDichVu", "Mã dịch vụ");
            dgvGioHang.Columns.Add("TenDichVu", "Tên dịch vụ");
            dgvGioHang.Columns.Add("SoLuong", "Số lượng");
            dgvGioHang.Columns.Add("DonGia", "Đơn giá");
            dgvGioHang.Columns.Add("TongGia", "Tổng giá");

            // Thêm nút xóa vào DataGridView
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.HeaderText = "Xóa"; // Tiêu đề cột
            btnXoa.Name = "Xóa"; // Tên cột
            btnXoa.Text = "Xóa"; // Văn bản hiển thị trên nút
            btnXoa.UseColumnTextForButtonValue = true; // Sử dụng văn bản này cho tất cả các ô
            dgvGioHang.Columns.Add(btnXoa);
        }


        private void CapNhatTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["TongGia"].Value != null)
                {
                    decimal tongGia;
                    if (decimal.TryParse(row.Cells["TongGia"].Value.ToString(), out tongGia))
                    {
                        tongTien += tongGia;
                    }
                }
            }

            lblTongTien.Text = $"Tổng tiền: {tongTien:C}";
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấn vào nút xóa
            if (e.ColumnIndex == dgvGioHang.Columns["Xóa"].Index && e.RowIndex >= 0)
            {
                // Xóa hàng được chọn
                dgvGioHang.Rows.RemoveAt(e.RowIndex);

                // Cập nhật tổng tiền
                CapNhatTongTien();
            }
        }

        
        private void cbxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin đã được lưu!");
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var selectedService = (DichVu)cbxDichVu.SelectedItem;
            int soLuong = (int)numSoLuong.Value;

            if (selectedService == null)
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ!");
                return;
            }

            decimal donGia = selectedService.DonGia;
            decimal tongGia = donGia * soLuong;

            // Thêm dịch vụ vào DataGridView
            dgvGioHang.Rows.Add(selectedService.MaDichVu, selectedService.TenDichVu, soLuong, donGia, tongGia);

            // Cập nhật tổng tiền
            CapNhatTongTien();
        }
    }

    public class DichVu
    {
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }
    }

}
