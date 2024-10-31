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

namespace QuanLyKhachSan.NhanVien
{
    public partial class XuatHoaDon : Form
    {
        public XuatHoaDon()
        {
            InitializeComponent();
        }
        QuanLyKhachSanDB context = new QuanLyKhachSanDB();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int w = int.Parse(txtMaKhachHang.Texts);
            PhieuDatPhong PDP = context.PhieuDatPhongs
                           .Where(p => p.MaKhachHang == w)
                           .OrderByDescending(p => p.NgayDatPhong)
                           .FirstOrDefault();
            HoaDonDichVu HDDV = context.HoaDonDichVus
                           .Where(q => (q.MaKhachHang == w) && (q.NgayLap < PDP.NgayTraPhong))
                           .OrderByDescending(p => p.MaHoaDon)
                           .FirstOrDefault();
            int a = (int)HDDV.TongTien + (int)PDP.TongTien;

            MessageBox.Show("Hóa đơn tiền phòng :" + PDP.TongTien.ToString() + "\nHóa đơn dịch vụ :" +HDDV.TongTien.ToString()+"\nTổng tiền :"+a.ToString());


        }
    }
}
