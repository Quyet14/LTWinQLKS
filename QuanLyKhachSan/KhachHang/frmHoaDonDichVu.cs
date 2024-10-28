using DoAnN6_QLKS_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.KhachHang
{
    public partial class frmHoaDonDichVu : Form
    {
        private readonly Model1 context = new Model1();

        public frmHoaDonDichVu()
        {
            InitializeComponent();
            SetupDataGridView();

        }

        private void SetupDataGridView()
        {
            dgvHoaDonDV.AutoGenerateColumns = false;

            if (dgvHoaDonDV.Columns["MaHoaDon"] == null)
                dgvHoaDonDV.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
            
            if (dgvHoaDonDV.Columns["MaNhanVien"] == null)
                dgvHoaDonDV.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            if (dgvHoaDonDV.Columns["NgayLap"] == null)
                dgvHoaDonDV.Columns.Add("NgayLap", "Ngày Lập");
            if (dgvHoaDonDV.Columns["TongTien"] == null)
                dgvHoaDonDV.Columns.Add("TongTien", "Tổng Tiền");

            SetGridViewStyle(dgvHoaDonDV);
        }

        private void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void LoadInvoices()
        {
            try
            {
                var invoices = context.HoaDonDichVus
                    .Include(h => h.ChiTietPhieuDatPhongs)
                    .Include(h => h.NhanVien)
                    .ToList();

                Console.WriteLine($"Số lượng hóa đơn: {invoices.Count}"); // Log để kiểm tra

                if (invoices.Any())
                {
                    BindGrid(invoices);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu hóa đơn dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<HoaDonDichVu> invoices)
        {
            dgvHoaDonDV.Rows.Clear();
            foreach (var item in invoices)
            {
                int index = dgvHoaDonDV.Rows.Add();
                dgvHoaDonDV.Rows[index].Cells["MaHoaDon"].Value = item.MaHoaDon;
               
                dgvHoaDonDV.Rows[index].Cells["MaNhanVien"].Value = item.MaNhanVien;
                dgvHoaDonDV.Rows[index].Cells["NgayLap"].Value = item.NgayLap.ToString("MM/dd/yyyy hh:mm tt");
                dgvHoaDonDV.Rows[index].Cells["TongTien"].Value = item.TongTien;

                Console.WriteLine($"Đã thêm hóa đơn: MaHoaDon={item.MaHoaDon},  MaNhanVien={item.MaNhanVien}, NgayLap={item.NgayLap}, TongTien={item.TongTien}");
            }

            dgvHoaDonDV.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"Mã Hóa Đơn: {vbtMaHoaDon.Text}");
                Console.WriteLine($"Mã Nhân Viên: {vbtMaNV.Text}");
                Console.WriteLine($"Tổng Tiền: {vbtTongTien.Text}");
                // Chỉ cần kiểm tra các trường cần thiết
                if (GetSelectedBookingDetailId(out int maHoaDon) &&
                    GetSelectedEmployeeId(out int maNhanVien) &&
                    decimal.TryParse(vbtTongTien.Text, out decimal tongTien))
                {
                    var newInvoice = new HoaDonDichVu
                    {
                        MaHoaDon = maHoaDon,
                        MaNhanVien = maNhanVien,
                        NgayLap = DateTime.Now,
                        TongTien = tongTien
                    };

                    context.HoaDonDichVus.Add(newInvoice);
                    context.SaveChanges();
                    LoadInvoices();
                    MessageBox.Show("Đã thêm hóa đơn dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đảm bảo Tổng Tiền là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDonDV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHoaDon = Convert.ToInt32(dgvHoaDonDV.SelectedRows[0].Cells["MaHoaDon"].Value);

                var invoice = context.HoaDonDichVus.Find(maHoaDon);
                if (invoice != null)
                {
                    context.HoaDonDichVus.Remove(invoice);
                    context.SaveChanges();
                    LoadInvoices();
                    MessageBox.Show("Đã xóa hóa đơn dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDonDV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Console.WriteLine($"Mã Hóa Đơn: {vbtMaHoaDon.Text}");
                Console.WriteLine($"Mã Nhân Viên: {vbtMaNV.Text}");
                Console.WriteLine($"Tổng Tiền: {vbtTongTien.Text}");

                int maHoaDon = Convert.ToInt32(dgvHoaDonDV.SelectedRows[0].Cells["MaHoaDon"].Value);

                // Kiểm tra các trường nhập liệu
                if (!int.TryParse(vbtMaNV.Text, out int maNhanVien) ||
                    !decimal.TryParse(vbtTongTien.Text, out decimal tongTien))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var invoice = context.HoaDonDichVus.Find(maHoaDon);
                if (invoice != null)
                {
                    invoice.MaNhanVien = maNhanVien;
                    invoice.TongTien = tongTien;

                    context.SaveChanges();
                    LoadInvoices();
                    MessageBox.Show("Đã cập nhật hóa đơn dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool GetSelectedBookingDetailId(out int maHoaDon)
        {
            return int.TryParse(vbtMaHoaDon.Text, out maHoaDon);
        }

        private bool GetSelectedEmployeeId(out int maNhanVien)
        {
            return int.TryParse(vbtMaNV.Text, out maNhanVien);
        }

        private void frmHoaDonDichVu_Load_1(object sender, EventArgs e)
        {
            try
            {
                LoadInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}