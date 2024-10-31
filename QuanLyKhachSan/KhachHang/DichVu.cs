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

namespace QuanLyKhachSan
{
    public partial class DichVu : Form
    {
        QuanLyKhachSanDB context = new QuanLyKhachSanDB();
        int UserId;
        public DichVu(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;

        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            try
            {
                //HoaDonDichVu HDDV = context.HoaDonDichVus.LastOrDefault(p => p.NgayLap < DateTime.Now && p.MaKhachHang == UserId);
                //int a = HDDV.MaHoaDon;
                //ChiTietDichVu CTDV = new ChiTietDichVu();
                //CTDV.MaHoaDon = a;
                //CTDV.MaDichVu = int.Parse(cmbDichVu.ValueMember)+1;
                //CTDV.SoLuong = int.Parse(txtSoLuong.Texts);
                //int maDichVu = (int)CTDV.MaDichVu;
                //DoAnN6_QLKS_DAL.Entity.DichVu DV = context.DichVus.FirstOrDefault(p => p.MaDichVu == maDichVu);
                //if (DV != null)
                //{
                //    CTDV.DonGia = DV.DonGia;
                //}
                //context.ChiTietDichVus.Add(CTDV);
                //context.SaveChanges();
                HoaDonDichVu HDDV = context.HoaDonDichVus
                           .LastOrDefault(p => p.NgayLap < DateTime.Now && p.MaKhachHang == UserId);
                if (HDDV == null)
                {
                    throw new Exception("No matching HoaDonDichVu found.");
                }

                int a = HDDV.MaHoaDon;
                ChiTietDichVu CTDV = new ChiTietDichVu
                {
                    MaHoaDon = a,
                    MaDichVu = int.Parse(cmbDichVu.ValueMember),  // Adjust if necessary, remove +1 if IDs are direct
                    SoLuong = int.Parse(txtSoLuong.Texts)
                };

                int maDichVu = (int)CTDV.MaDichVu;
                DoAnN6_QLKS_DAL.Entity.DichVu DV = context.DichVus.FirstOrDefault(p => p.MaDichVu == maDichVu);
                if (DV != null)
                {
                    CTDV.DonGia = DV.DonGia;
                }
                else
                {
                    throw new Exception("DichVu not found for the given MaDichVu.");
                }

                context.ChiTietDichVus.Add(CTDV);
                context.SaveChanges();

            }
            catch (Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }
            // TODO: Implement order placement logic

            //MessageBox.Show($"Đã đặt dịch vụ: {tenDichVu}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
            public string TenDichVu { get; set; }
            public decimal Gia { get; set; }
        public TrangChinh MdiParnet { get; internal set; }

        private void FillDichVuCombobox(List<DoAnN6_QLKS_DAL.Entity.DichVu> listDichVu)
        {
            this.cmbDichVu.DataSource = listDichVu;
            this.cmbDichVu.DisplayMember = "TenDichVu";
            this.cmbDichVu.ValueMember = "MaDichVu";
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            List<DoAnN6_QLKS_DAL.Entity.DichVu> listDichVu = context.DichVus.ToList();
            FillDichVuCombobox(listDichVu);

        }

        private void txtSoLuong__TextChanged(object sender, EventArgs e)
        {
            //DoAnN6_QLKS_DAL.Entity.DichVu DV = context.DichVus.FirstOrDefault(p => p.MaDichVu == int.Parse(cmbDichVu.ValueMember));
            //txtGia.Text = DV.DonGia * int.Parse(txtSoLuong.Texts);
        }
        private void UpdateHoaDonDV(int a)
        {
            HoaDonDichVu HDDV = context.HoaDonDichVus.FirstOrDefault(p=>p.MaHoaDon == a);
            if(HDDV != null)
            {
                List<ChiTietDichVu> listChiTietDichVu = context.ChiTietDichVus.ToList();
                foreach(var item  in listChiTietDichVu)
                {
                    if(item.MaHoaDon == a)
                    {
                        HDDV.TongTien += item.ThanhTien;
                    }
                }
                context.SaveChanges();
            }
        }
        private void btnDat_Click_1(object sender, EventArgs e)
        {
            //HoaDonDichVu HDDV = context.HoaDonDichVus.LastOrDefault(p => p.NgayLap < DateTime.Now && p.MaKhachHang == UserId);
            HoaDonDichVu HDDV = context.HoaDonDichVus
                           .Where(p => p.NgayLap < DateTime.Now && p.MaKhachHang == UserId)
                           .OrderByDescending(p => p.NgayLap)
                           .FirstOrDefault();
            int a = HDDV.MaHoaDon;
            ChiTietDichVu CTDV = new ChiTietDichVu();
            CTDV.MaHoaDon = a;
            DoAnN6_QLKS_DAL.Entity.DichVu DV = context.DichVus.FirstOrDefault(p => p.TenDichVu == cmbDichVu.Text);
            CTDV.MaDichVu = DV.MaDichVu;
            CTDV.SoLuong = int.Parse(txtSoLuong.Texts);
            int maDichVu = (int)CTDV.MaDichVu;
            DoAnN6_QLKS_DAL.Entity.DichVu DV2 = context.DichVus.FirstOrDefault(p => p.MaDichVu == maDichVu);
            if (DV2 != null)
            {
                CTDV.DonGia = DV2.DonGia;
            }
            context.ChiTietDichVus.Add(CTDV);
            context.SaveChanges();
            UpdateHoaDonDV(a);
        }
    }
}
