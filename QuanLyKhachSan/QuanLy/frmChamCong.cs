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
    public partial class frmChamCong : Form
    {
        private readonly QuanLyKhachSanDB context = new QuanLyKhachSanDB();

        public frmChamCong()
        {
            InitializeComponent();      
        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            List<ChamCong> ListChamCong = context.ChamCongs.ToList();
            BindGrid(ListChamCong);
        }
        private void BindGrid(List<ChamCong> listChamCong)
        {
            foreach (var item in listChamCong)
            {
                int index = dgvChamCong.Rows.Add();
                dgvChamCong.Rows[index].Cells[0].Value = item.MaChamCong;
                dgvChamCong.Rows[index].Cells[1].Value = item.MaNhanVien;
                dgvChamCong.Rows[index].Cells[2].Value = item.Ngay;
            }
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int maNV;
            if (int.TryParse(txtMaNV.Texts, out maNV))
            {
                int month;
                if (int.TryParse(txtThang.Texts, out month) && month >= 1 && month <= 12)
                {
                    var chamCongs = context.ChamCongs
                        .Where(cc => cc.MaNhanVien == maNV && cc.Ngay.Value.Month == month)
                        .ToList();

                    // Assuming a fixed salary per day worked.
                    decimal salaryPerDay = 100; // Example value
                    decimal totalSalary = chamCongs.Count * salaryPerDay;

                    MessageBox.Show($"Tổng tiền lương cho {maNV} cho tháng {month}: {totalSalary}");
                }
                else
                {
                    MessageBox.Show("Please enter a valid month (1-12).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid employee ID.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int maNV;
            if (int.TryParse(txtMaNV.Texts, out maNV))
            {
                int month;
                if (int.TryParse(txtThang.Texts, out month) && month >= 1 && month <= 12)
                {
                    var records = context.ChamCongs
                        .Where(cc => cc.MaNhanVien == maNV && cc.Ngay.Value.Month == month)
                        .ToList() // Fetch the data first
                        .Select(cc => new
                        {
                            MaChamCong = cc.MaChamCong,
                            MaNhanVien = cc.MaNhanVien,
                            Ngay = cc.Ngay.Value.ToString("dd/MM/yyyy") // Format date after fetching
                        })
                        .ToList();

                    dgvChamCong.DataSource = records;
                }
                else
                {
                    MessageBox.Show("Please enter a valid month (1-12).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid employee ID.");
            }
        }
    }
}