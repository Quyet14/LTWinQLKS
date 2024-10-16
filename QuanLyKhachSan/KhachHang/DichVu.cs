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
        private ListView lsvDichVu;
        private List<DichVu> services;
        public DichVu()
        {
            InitializeComponent();
            

        }
        private void LoadServicesIntoListView()
        {
            lsvDichVu.View = View.Details;

            lsvDichVu.Columns.Add("Tên Dịch Vụ", 200, HorizontalAlignment.Left);
            lsvDichVu.Columns.Add("Giá", 100, HorizontalAlignment.Left);
            foreach (var service in services)
            {
                ListViewItem item = new ListViewItem(service.TenDichVu);

                item.SubItems.Add(service.Gia.ToString("N0"));
                lsvDichVu.Items.Add(item);
            }
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            if (lsvDichVu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maDichVu = lsvDichVu.SelectedItems[0].Text;
            string tenDichVu = lsvDichVu.SelectedItems[0].SubItems[1].Text;
            decimal gia = decimal.Parse(lsvDichVu.SelectedItems[0].SubItems[2].Text);

            // TODO: Implement order placement logic

            MessageBox.Show($"Đã đặt dịch vụ: {tenDichVu}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
            public string TenDichVu { get; set; }
            public decimal Gia { get; set; }
        public TrangChinh MdiParnet { get; internal set; }
    }
}
