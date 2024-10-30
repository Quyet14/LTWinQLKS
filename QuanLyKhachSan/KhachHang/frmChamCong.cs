using DoAnN6_QLKS_DAL.Entities;
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
    public partial class frmChamCong : Form
    {
        private readonly Model1 context = new Model1();

        public frmChamCong()
        {
            InitializeComponent();      
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