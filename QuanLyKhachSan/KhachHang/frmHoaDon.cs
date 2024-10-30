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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnDatDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                // Lấy thông tin dịch vụ từ dòng được chọn
                DataGridViewRow selectedRow = dgvDichVu.SelectedRows[0];
                string maDichVu = selectedRow.Cells["MaDichVu"].Value.ToString();
                string tenDichVu = selectedRow.Cells["TenDichVu"].Value.ToString();
                decimal giaDichVu = Convert.ToDecimal(selectedRow.Cells["GiaDichVu"].Value);

                // Hiển thị thông tin dịch vụ lên các textbox
                colMaDichVu.HeaderText = maDichVu;
                colTenDichVu.HeaderText = tenDichVu;
                colGiaDichVu.HeaderText = giaDichVu.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để đặt.");
            }
        }
    }
}
