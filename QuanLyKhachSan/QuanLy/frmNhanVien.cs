using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            rbMale.Checked = true;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaNhanVien.Text);
            if (selectedRow == -1)
            {
                int a;
                if(cmbQuyen.Text == "Quản lý")
                {
                    a = 0;
                }
                else
                {
                    a = 1;
                }
                DoAnN6_QLKS_DAL.Entity.NhanVien NV = new DoAnN6_QLKS_DAL.Entity.NhanVien()
                {
                    MaNhanVien = int.Parse(txtMaNhanVien.Texts),
                    HoTen = txtHoten.Texts,
                    GioiTinh = rbFemale.Checked ? "Nữ" : "Nam",
                    DiaChi = txtDiaChi.Texts,
                    SoDienThoai = txtSDT.Texts,
                    Email = txtEmail.Texts,
                    CMND = txtCMND.Texts,
                    perm = a,
                    Active = default
                };
                context.NhanViens.Add(NV);
                context.SaveChanges();

                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien = context.NhanViens.ToList();
                BindGrid(listNhanVien);
                clearData();
            }
        }
        private void BindGrid(List<DoAnN6_QLKS_DAL.Entity.NhanVien> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanVien)
            {
                if(item.Active) { 
                    int index = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[index].Cells[0].Value = item.MaNhanVien;
                    dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                    dgvNhanVien.Rows[index].Cells[2].Value = item.GioiTinh;
                    dgvNhanVien.Rows[index].Cells[3].Value = item.DiaChi;
                    dgvNhanVien.Rows[index].Cells[4].Value = item.SoDienThoai;
                    dgvNhanVien.Rows[index].Cells[5].Value = item.Email;
                    dgvNhanVien.Rows[index].Cells[6].Value = item.CMND;
                    if(item.perm == 0)
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
                if(cmbQuyen.Text == "Quản lý")
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
            NV.Active = false;
        }
    }

}

