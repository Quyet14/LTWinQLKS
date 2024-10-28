using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmThemDV : Form
    {
        public frmThemDV()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
        private void LoadData()
        {
            // Tải dữ liệu vào DataGridView
            List<DichVu> listDichVu = context.DichVus.ToList();
            BindGrid(listDichVu);
        }
        private void BindGrid(List<DichVu> listDichVu)
        {
            dgvDichVu.Rows.Clear();
            foreach (var item in listDichVu)
            {
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = ;
                dgvDichVu.Rows[index].Cells[1].Value = item.TenDichVu;
                dgvDichVu.Rows[index].Cells[2].Value = item.DonGia;
            }
        }
        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                txtDichVu.Text = row.Cells[1].Value.ToString(); // Tên Dịch Vụ
                txtDonGia.Text = row.Cells[2].Value.ToString();    // Đơn Giá
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
