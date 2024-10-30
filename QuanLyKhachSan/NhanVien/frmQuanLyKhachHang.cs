using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.NhanVien
{
    public partial class frmQuanLyKhachHang : Form
    {
        Model1 context = new Model1();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            BindGrid(listKhachHang);
            rbMale.Checked = true;
        }
        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in listKhachHang)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MaKhachHang;
                dgvKhachHang.Rows[index].Cells[1].Value = item.HoTen;
                dgvKhachHang.Rows[index].Cells[2].Value = item.GioiTinh;
                dgvKhachHang.Rows[index].Cells[3].Value = item.DiaChi;
                dgvKhachHang.Rows[index].Cells[4].Value = item.SoDienThoai;
                dgvKhachHang.Rows[index].Cells[5].Value = item.Email;
                dgvKhachHang.Rows[index].Cells[6].Value = item.CMND;

            }
        }
        private bool ValidateInput()
        {
            // Kiểm tra txtMaKhachHang
            if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtMaKhachHang.Text, @"^\d+$")) // Chỉ chứa số
            {
                MessageBox.Show("Mã khách hàng chỉ được chứa số và không được chứa ký tự đặc biệt.");
                return false;
            }

            // Kiểm tra txtHoTen
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtHoTen.Text, @"^[a-zA-Z\s]+$")) // Chỉ chứa chữ cái và dấu cách
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt.");
                return false;
            }

            // Kiểm tra txtDiaChi
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtDiaChi.Text, @"^[a-zA-Z0-9\s/]+$")) // Cho phép chữ cái, số, dấu cách, và dấu "/"
            {
                MessageBox.Show("Địa chỉ không được chứa ký tự đặc biệt (ngoại trừ '/').");
                return false;
            }

            // Kiểm tra txtSDT (Số điện thoại Việt Nam bắt đầu bằng 0)
            if (!Regex.IsMatch(txtSDT.Text, @"^0\d{9,10}$")) // Số bắt đầu bằng 0 và có độ dài từ 10-11 chữ số
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại Việt Nam phải bắt đầu bằng 0 và có từ 10 đến 11 chữ số.");
                return false;
            }

            // Kiểm tra txtEmail (Email phải đúng định dạng)
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Định dạng email cơ bản
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.");
                return false;
            }

            // Nếu tất cả đều hợp lệ
            return true;
        }
        private int GetSelectedRow(string MaKhachHang)
        {
            for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
            {
                if (dgvKhachHang.Rows[i].Cells[0].Value != null)
                {
                    if (dgvKhachHang.Rows[i].Cells[0].Value.ToString() == MaKhachHang)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void ClearData()
        {
            txtMaKhachHang.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            rbMale.Checked = true;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCMND.Text = string.Empty;
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtCMND.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int selectedRow = GetSelectedRow(txtMaKhachHang.Text);
                if (selectedRow == -1)
                {
                    KhachHang KH = new KhachHang()
                    {
                        MaKhachHang = int.Parse(txtMaKhachHang.Text),
                        HoTen = txtHoTen.Text,
                        GioiTinh = rbFemale.Checked ? "Nữ" : "Nam",
                        DiaChi = txtDiaChi.Text,
                        SoDienThoai = txtSDT.Text,
                        Email = txtEmail.Text,
                        CMND = txtCMND.Text
                    };
                    context.KhachHangs.Add(KH);
                    context.SaveChanges();

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                    List<KhachHang> listStudent = context.KhachHangs.ToList();
                    BindGrid(listStudent);
                    ClearData();
                }
                else
                {
                    int a = int.Parse(txtMaKhachHang.Text);
                    KhachHang KH = context.KhachHangs.FirstOrDefault(p => p.MaKhachHang == a);
                    KH.HoTen = txtHoTen.Text;
                    if (rbFemale.Checked)
                    {
                        KH.GioiTinh = "Nữ";
                    }
                    else
                    {
                        KH.GioiTinh = "Nam";
                    }
                    KH.DiaChi = txtDiaChi.Text;
                    KH.Email = txtEmail.Text;
                    KH.SoDienThoai = txtSDT.Text;
                    KH.CMND = txtCMND.Text;
                    context.SaveChanges();
                    MessageBox.Show("Thay đổi dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                    List<KhachHang> listStudent = context.KhachHangs.ToList();
                    BindGrid(listStudent);
                    ClearData();
                }
            }
        }
    }
}
