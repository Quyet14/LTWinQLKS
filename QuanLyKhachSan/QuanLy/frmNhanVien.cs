using System;
using System.Data;
using System.Windows.Forms;

namespace NguyenKhanhLong_qlks
{
    public partial class frmNhanVien : Form
    {
        public bool themmoi = false;
        private DataTable dtNhanVien = new DataTable();

        public frmNhanVien()
        {
            InitializeComponent();

            // Khởi tạo DataGridView
            dgvNhanVien.ColumnCount = 5;
            dgvNhanVien.Columns[0].Name = "Mã NV";
            dgvNhanVien.Columns[1].Name = "Họ tên";
            dgvNhanVien.Columns[2].Name = "Ngày sinh";
            dgvNhanVien.Columns[3].Name = "Địa chỉ";
            dgvNhanVien.Columns[4].Name = "SĐT";

            // Khởi tạo cột cho DataTable
            dtNhanVien.Columns.Add("MaNV", typeof(string));
            dtNhanVien.Columns.Add("HoTen", typeof(string));
            dtNhanVien.Columns.Add("NgaySinh", typeof(DateTime));
            dtNhanVien.Columns.Add("DiaChi", typeof(string));
            dtNhanVien.Columns.Add("SĐT", typeof(string));
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            hienThiNhanVien(); // Gọi hàm để hiển thị danh sách nhân viên
        }

        private DataTable LayDSChucVu()
        {
            DataTable dtChucVu = new DataTable();
            dtChucVu.Columns.Add("MaChucVu", typeof(string));
            dtChucVu.Columns.Add("TenChucVu", typeof(string));
            dtChucVu.Rows.Add("CV01", "Quản lý");
            dtChucVu.Rows.Add("CV02", "Nhân viên lễ tân");
            dtChucVu.Rows.Add("CV03", "Nhân viên dọn phòng");

            return dtChucVu;
        }

        private void hienThiNhanVien()
        {
            dgvNhanVien.Rows.Clear();
            foreach (DataRow row in dtNhanVien.Rows)
            {
                dgvNhanVien.Rows.Add(row["MaNV"], row["HoTen"], ((DateTime)row["NgaySinh"]).ToString("MM/dd/yyyy"), row["DiaChi"], row["SĐT"]);
            }
        }

        private void setNull()
        {
            txtHoten.Text = "";
            txtDiaChi.Text = "";
        }

        private void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnSua.Enabled = val;
        }

       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đã được nhập đầy đủ
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ||
                string.IsNullOrWhiteSpace(txtHoten.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã nhân viên đã tồn tại hay chưa
            foreach (DataRow existingRow in dtNhanVien.Rows) // Đổi tên biến thành existingRow
            {
                if (existingRow["MaNV"].ToString() == txtMaNhanVien.Text)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Tạo một dòng mới và thêm vào DataTable
            DataRow newRow = dtNhanVien.NewRow();
            newRow["MaNV"] = txtMaNhanVien.Text; // Lấy mã nhân viên từ textbox
            newRow["HoTen"] = txtHoten.Text;
            newRow["DiaChi"] = txtDiaChi.Text;
            newRow["SĐT"] = txtSDT.Text;
            dtNhanVien.Rows.Add(newRow);

            // Cập nhật DataGridView
            hienThiNhanVien();
            setNull(); // Xóa các trường nhập liệu
            setButton(true); // Kích hoạt lại các nút

            MessageBox.Show("Thêm mới nhân viên thành công");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvNhanVien.SelectedRows[0].Index;
                DataRow updatedRow = dtNhanVien.Rows[selectedIndex]; // Đổi tên biến ở đây

                // Cập nhật thông tin của nhân viên
                updatedRow["HoTen"] = txtHoten.Text;
                updatedRow["DiaChi"] = txtDiaChi.Text;
                updatedRow["SĐT"] = txtSDT.Text; // Cập nhật số điện thoại

                // Cập nhật DataGridView
                hienThiNhanVien();
                setNull(); // Xóa các trường nhập liệu
                MessageBox.Show("Cập nhật nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cần cập nhật");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                // Lấy thông tin nhân viên đã chọn và điền vào form
                int selectedIndex = dgvNhanVien.SelectedRows[0].Index;
                DataRow selectedRow = dtNhanVien.Rows[selectedIndex]; // Đổi tên biến ở đây
                txtHoten.Text = selectedRow["HoTen"].ToString();
                
                txtDiaChi.Text = selectedRow["DiaChi"].ToString();
                txtSDT.Text = selectedRow["SĐT"].ToString();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }


        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {

        }
    }

}

