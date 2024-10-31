using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnN6_QLKS_DAL.Entity;

namespace QuanLyKhachSan
{
    public partial class frmHoaDon : Form
    {
        private int KhachHangID {  get; set; }
        public frmHoaDon(int UserID)
        {
            InitializeComponent();
            this.KhachHangID = UserID;
        }
        QuanLyKhachSanDB context = new QuanLyKhachSanDB();
        private void btnDatDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                //// Lấy thông tin dịch vụ từ dòng được chọn
                //DataGridViewRow selectedRow = dgvDichVu.SelectedRows[0];
                //string maDichVu = selectedRow.Cells["MaDichVu"].Value.ToString();
                //string tenDichVu = selectedRow.Cells["TenDichVu"].Value.ToString();
                //decimal giaDichVu = Convert.ToDecimal(selectedRow.Cells["GiaDichVu"].Value);

                //// Hiển thị thông tin dịch vụ lên các textbox
                //colMaDichVu.HeaderText = maDichVu;
                //colTenDichVu.HeaderText = tenDichVu;
                //colGiaDichVu.HeaderText = giaDichVu.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để đặt.");
            }
        }

        private void dgvPhong1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void BindGrid(List<PhieuDatPhong> listPhieuDatPhong)
        {
            dgvPhong1.Rows.Clear();
            foreach (var item in listPhieuDatPhong)
            {
                if (item.MaKhachHang == KhachHangID)
                {
                int index = dgvPhong1.Rows.Add();
                dgvPhong1.Rows[index].Cells[0].Value = item.MaPhieu;
                dgvPhong1.Rows[index].Cells[1].Value = item.MaPhong;
                dgvPhong1.Rows[index].Cells[2].Value = item.NgayDatPhong;
                dgvPhong1.Rows[index].Cells[3].Value = item.NgayTraPhong;
                dgvPhong1.Rows[index].Cells[4].Value = item.TongTien;
                }
            }
        }
        private void BindGrid2(List<ChiTietDichVu> listChiTietDichVu)
        {
            dgvDichVu.Rows.Clear();
            foreach (var item in listChiTietDichVu)
            {
                if (item.HoaDonDichVu.MaKhachHang == KhachHangID)
                {
                    int index = dgvDichVu.Rows.Add();
                    dgvDichVu.Rows[index].Cells[0].Value = item.MaChiTietDichVu;
                    dgvDichVu.Rows[index].Cells[1].Value = item.MaHoaDon;
                    dgvDichVu.Rows[index].Cells[2].Value = item.MaDichVu;
                    dgvDichVu.Rows[index].Cells[3].Value = item.SoLuong;
                    dgvDichVu.Rows[index].Cells[4].Value = item.DonGia;
                    dgvDichVu.Rows[index].Cells[5].Value = item.ThanhTien;
                }
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            List<PhieuDatPhong> listPhieuDatPhong = context.PhieuDatPhongs.ToList();
            BindGrid(listPhieuDatPhong);
            List<ChiTietDichVu> listChiTietDichVu = context.ChiTietDichVus.ToList();
            BindGrid2(listChiTietDichVu);
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
