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

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmQLDanhGia : Form
    {
        public frmQLDanhGia()
        {
            InitializeComponent();
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            List<PhanHoiKhachHang> listResponds = context.PhanHoiKhachHangs.ToList();
            BindGrid(listResponds);
        }
        private void BindGrid(List<PhanHoiKhachHang> listResponds)
        {
            dgvRespond.Rows.Clear();
            foreach (var item in listResponds)
            {
                int index = dgvRespond.Rows.Add();
                dgvRespond.Rows[index].Cells[0].Value = item.MaPhanHoi;
                dgvRespond.Rows[index].Cells[1].Value = item.KhachHang.HoTen;
                dgvRespond.Rows[index].Cells[2].Value = item.Rating;
                dgvRespond.Rows[index].Cells[3].Value = item.NoiDung;
                dgvRespond.Rows[index].Cells[4].Value = item.NgayPhanHoi;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected rating from the NumericUpDown
                int selectedRating = (int)ratingBox.Value;

                // Query the database to get feedbacks with the selected rating
                QuanLyKhachSanDB context = new QuanLyKhachSanDB();
                List<PhanHoiKhachHang> filteredResponds = context.PhanHoiKhachHangs
                    .Where(r => r.Rating == selectedRating)
                    .ToList();

                // Bind the filtered data to the DataGridView
                BindGrid(filteredResponds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
