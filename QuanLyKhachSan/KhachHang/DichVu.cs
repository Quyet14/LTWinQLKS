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
        public DichVu()
        {
            InitializeComponent();
            

        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            

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
            DoAnN6_QLKS_DAL.Entity.DichVu DV = context.DichVus.FirstOrDefault(p => p.MaDichVu == int.Parse(cmbDichVu.ValueMember));
            //txtGia = DV.DonGia * int.Parse(txtSoLuong.Texts);
        }
    }
}
