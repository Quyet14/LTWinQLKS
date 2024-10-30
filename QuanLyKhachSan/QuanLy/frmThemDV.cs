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
using Theemdv_Quan_Ly_Khach_San;

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
            List<DoAnN6_QLKS_DAL.Entity.DichVu> listDichVu = context.DichVus.ToList();
            BindGrid(listDichVu);
        }
        private void BindGrid(List<DoAnN6_QLKS_DAL.Entity.DichVu> listDichVu)
        {
            dgvDichVu.Rows.Clear();
            foreach (var item in listDichVu)
            {
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = item.MaDichVu;
                dgvDichVu.Rows[index].Cells[1].Value = item.TenDichVu;
                dgvDichVu.Rows[index].Cells[2].Value = item.DonGia;
            }
        }
        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                txtTenDichVu.Text = row.Cells[1].Value.ToString(); // Tên Dịch Vụ
                txtDonGia.Text = row.Cells[2].Value.ToString();    // Đơn Giá
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc phải nhập
            if (
                string.IsNullOrWhiteSpace(txtTenDichVu.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá có phải là số hợp lệ không
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dịch vụ vào cơ sở dữ liệu
            try
            {
                DoAnN6_QLKS_DAL.Entity.DichVu dichVu = new DoAnN6_QLKS_DAL.Entity.DichVu
                {
                    TenDichVu = txtTenDichVu.Text,
                    DonGia = donGia
                };

                context.DichVus.Add(dichVu);
                context.SaveChanges();

                // Cập nhật lại DataGridView
                LoadData();

                // Xuất thông báo
                MessageBox.Show("Thêm mới dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các giá trị đã nhập
                txtTenDichVu.Text = String.Empty;
                txtDonGia.Texts = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc phải nhập
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá có phải là số hợp lệ không
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng đã chọn dịch vụ trong DataGridView hay chưa
            if (dgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy Mã Dịch Vụ từ hàng đã chọn trong DataGridView
                int maDichVu = (int)dgvDichVu.SelectedRows[0].Cells[0].Value;

                // Tìm dịch vụ theo Mã Dịch Vụ
                var dichVu = context.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);

                if (dichVu == null)
                {
                    MessageBox.Show("Không tìm thấy dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin dịch vụ
                dichVu.TenDichVu = txtTenDichVu.Text;
                dichVu.DonGia = donGia;

                // Lưu thay đổi
                context.SaveChanges();

                // Cập nhật lại DataGridView
                LoadData();

                // Xuất thông báo
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các giá trị đã nhập
                txtTenDichVu.Text = String.Empty;
                txtDonGia.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
