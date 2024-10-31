using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BCrypt.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmNhanVien : Form
    {
        //public bool themmoi = false;
        //private DataTable dtNhanVien = new DataTable();
        QuanLyKhachSanDB context = new QuanLyKhachSanDB();
        public frmNhanVien()
        {
            InitializeComponent();

            // Khởi tạo DataGridView
            //dgvNhanVien.ColumnCount = 5;
            //dgvNhanVien.Columns[0].Name = "Mã NV";
            //dgvNhanVien.Columns[1].Name = "Họ tên";
            //dgvNhanVien.Columns[2].Name = "Ngày sinh";
            //dgvNhanVien.Columns[3].Name = "Địa chỉ";
            //dgvNhanVien.Columns[4].Name = "SĐT";

            //// Khởi tạo cột cho DataTable
            //dtNhanVien.Columns.Add("MaNV", typeof(string));
            //dtNhanVien.Columns.Add("HoTen", typeof(string));
            //dtNhanVien.Columns.Add("NgaySinh", typeof(DateTime));
            //dtNhanVien.Columns.Add("DiaChi", typeof(string));
            //dtNhanVien.Columns.Add("SĐT", typeof(string));
        }
        private int GetSelectedRow(string MaKhachHang)
        {
            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                if (dgvNhanVien.Rows[i].Cells[0].Value != null)
                {
                    if (dgvNhanVien.Rows[i].Cells[0].Value.ToString() == MaKhachHang)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public void clearData()
        {
            txtMaNhanVien.Texts = String.Empty;
            txtHoten.Texts = String.Empty;
            txtCMND.Texts = String.Empty;
            txtDiaChi.Texts = String.Empty;
            txtEmail.Texts = String.Empty;
            txtMatKhau.Texts = String.Empty;
            txtSDT.Texts = String.Empty;
            rbMale.Checked = true;
        }
        private bool ValidateInput()
        {
            // Kiểm tra txtMaKhachHang
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Texts))
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtMaNhanVien.Texts, @"^\d+$")) // Chỉ chứa số
            {
                MessageBox.Show("Mã khách hàng chỉ được chứa số và không được chứa ký tự đặc biệt.");
                return false;
            }

            // Kiểm tra txtHoTen
            if (string.IsNullOrWhiteSpace(txtHoten.Texts))
            {
                MessageBox.Show("Họ tên không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtHoten.Texts, @"^[a-zA-Z\s]+$")) // Chỉ chứa chữ cái và dấu cách
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt.");
                return false;
            }

            // Kiểm tra txtDiaChi
            if (string.IsNullOrWhiteSpace(txtDiaChi.Texts))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống.");
                return false;
            }
            if (!Regex.IsMatch(txtDiaChi.Texts, @"^[a-zA-Z0-9\s/]+$")) // Cho phép chữ cái, số, dấu cách, và dấu "/"
            {
                MessageBox.Show("Địa chỉ không được chứa ký tự đặc biệt (ngoại trừ '/').");
                return false;
            }

            // Kiểm tra txtSDT (Số điện thoại Việt Nam bắt đầu bằng 0)
            if (!Regex.IsMatch(txtSDT.Texts, @"^0\d{9,10}$")) // Số bắt đầu bằng 0 và có độ dài từ 10-11 chữ số
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại Việt Nam phải bắt đầu bằng 0 và có từ 10 đến 11 chữ số.");
                return false;
            }
            DoAnN6_QLKS_DAL.Entity.NhanVien NV = context.NhanViens.FirstOrDefault(p => p.SoDienThoai == txtSDT.Texts);
            if(NV != null)
            {
                MessageBox.Show("Số điện thoại không được trùng. Vui lòng chọn số điện thoại khác");
                return false;
            }
            // Kiểm tra txtEmail (Email phải đúng định dạng)
            if (!Regex.IsMatch(txtEmail.Texts, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Định dạng email cơ bản
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.");
                return false;
            }
            DoAnN6_QLKS_DAL.Entity.NhanVien NV1 = context.NhanViens.FirstOrDefault(p => p.Email == txtEmail.Texts);
            if(NV1 != null)
            {
                MessageBox.Show("Email không được trùng, vui lòng chọn Email khác ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCMND.Texts))
            {
                MessageBox.Show("CMND không được để trống, vui lòng nhập");
                return false;
            }
            DoAnN6_QLKS_DAL.Entity.NhanVien NV2 = context.NhanViens.FirstOrDefault(p => p.CMND == txtCMND.Texts);
            if(NV2 != null)
            {
                MessageBox.Show("CMND không được trùng, vui lòng nhập CMND khác");
                return false;
            }
            // Nếu tất cả đều hợp lệ
            return true;
        }
        public static string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString().Substring(0, 50); // Truncate to 50 characters
            }
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaNhanVien.Text);
            if (selectedRow == -1)
            {
                if(ValidateInput())
                {
                    int a;
                    if (cmbQuyen.Text == "Quản lý")
                    {
                        a = 0;
                    }
                    else
                    {
                        a = 1;
                    }
                    string z = HashPasswordSHA256(txtMatKhau.Texts.ToString());
                    DoAnN6_QLKS_DAL.Entity.NhanVien NV = new DoAnN6_QLKS_DAL.Entity.NhanVien()
                    {
                        MaNhanVien = int.Parse(txtMaNhanVien.Texts),
                        HoTen = txtHoten.Texts,
                        GioiTinh = rbFemale.Checked ? "Nữ" : "Nam",
                        DiaChi = txtDiaChi.Texts,
                        SoDienThoai = txtSDT.Texts,
                        Email = txtEmail.Texts,
                        CMND = txtCMND.Texts,
                        Password = z,
                        perm = a,
                        Active = true
                    };
                    context.NhanViens.Add(NV);
                    context.SaveChanges();

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                    List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien = context.NhanViens.ToList();
                    BindGrid(listNhanVien);
                    clearData();
                }
            }
        }
        private void BindGrid(List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                if (item.Active)
                {
                    int index = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[index].Cells[0].Value = item.MaNhanVien;
                    dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                    dgvNhanVien.Rows[index].Cells[2].Value = item.GioiTinh;
                    dgvNhanVien.Rows[index].Cells[3].Value = item.DiaChi;
                    dgvNhanVien.Rows[index].Cells[4].Value = item.SoDienThoai;
                    dgvNhanVien.Rows[index].Cells[5].Value = item.Email;
                    dgvNhanVien.Rows[index].Cells[6].Value = item.CMND;
                    if (item.perm == 0)
                    {
                        dgvNhanVien.Rows[index].Cells[7].Value = "Quản lý";
                    }
                    else
                    {
                        dgvNhanVien.Rows[index].Cells[7].Value = "Nhân viên";
                    }
                }
            }
        }


        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {
            List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien = context.NhanViens.ToList();
            BindGrid(listNhanVien);
            rbMale.Checked = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaNhanVien.Texts);
            if (selectedRow != -1)
            {
                int a = int.Parse(txtMaNhanVien.Texts);
                DoAnN6_QLKS_DAL.Entity.NhanVien NV = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == a);
                NV.HoTen = txtHoten.Texts;
                if (rbFemale.Checked)
                {
                    NV.GioiTinh = "Nữ";
                }
                else
                {
                    NV.GioiTinh = "Nam";
                }
                NV.DiaChi = txtDiaChi.Text;
                NV.Email = txtEmail.Text;
                NV.SoDienThoai = txtSDT.Text;
                NV.CMND = txtCMND.Text;
                NV.Password = txtMatKhau.Texts;
                if (cmbQuyen.Text == "Quản lý")
                {
                    NV.perm = 0;
                }
                else
                {
                    NV.perm = 1;
                }
                NV.Active = default;
                context.SaveChanges();
                MessageBox.Show("Thay đổi dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGrid(listNhanVien);
                clearData();
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtMaNhanVien.Texts);
            DoAnN6_QLKS_DAL.Entity.NhanVien NV = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == a);
            if (NV != null)
            {
                NV.Active = false;
                context.SaveChanges();
                List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGrid(listNhanVien);
                clearData();
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                txtMaNhanVien.Texts = row.Cells[0].Value.ToString();
                txtHoten.Texts = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = false;
                }
                txtDiaChi.Texts = row.Cells[3].Value.ToString();
                txtSDT.Texts = row.Cells[4].Value.ToString();
                txtEmail.Texts = row.Cells[5].Value.ToString();
                txtCMND.Texts = row.Cells[6].Value.ToString();
                if(row.Cells[7].Value.ToString() == "Quản lý")
                {
                    cmbQuyen.ValueMember = "Quản lý";

                }
                else
                {
                    cmbQuyen.ValueMember = "Nhân viên";
                }
            }
            
        }
    }

}

