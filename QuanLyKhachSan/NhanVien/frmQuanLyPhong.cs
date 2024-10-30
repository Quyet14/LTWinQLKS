using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyKhachSan.NhanVien
{
    public partial class frmQuanLyPhong : Form
    {
        Model1 context = new Model1;
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }

        private void LoadLoaiPhong()
        {

            string connectionString = "Data Source=THANH_TUNG;Initial Catalog=QLKS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaLoaiPhong, TenLoaiPhong FROM LoaiPhong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            cbLoaiPhong.Items.Add(new
                            {
                                Text = reader["TenLoaiPhong"].ToString(),
                                Value = reader["MaLoaiPhong"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }

            // Set cbLoaiPhong to display the 'Text' property
            cbLoaiPhong.DisplayMember = "Text";
            cbLoaiPhong.ValueMember = "Value";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtTimKhachHang.Text;

            // Chuỗi kết nối đến cơ sở dữ liệu của bạn
            string connectionString = "Data Source =THANH_TUNG;Initial Catalog=QLKS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HoTen, SoDienThoai FROM KhachHang WHERE MaKhachHang = @MaKhachHang";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào truy vấn
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Nếu tìm thấy khách hàng, cập nhật thông tin
                                txtTenKhachHang.Text = reader["HoTen"].ToString();
                                txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                            }
                            else
                            {
                                // Nếu không tìm thấy khách hàng
                                MessageBox.Show("Không tìm thấy khách hàng với mã này.");
                                txtTenKhachHang.Clear();
                                txtSoDienThoai.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedItem != null)
            {
                var selectedItem = (dynamic)cbLoaiPhong.SelectedItem;
                string maLoaiPhong = selectedItem.Value.ToString();

                LoadPhong(maLoaiPhong);
            }
        }

        private void LoadPhong(string maLoaiPhong)
        {
            cbPhong.Items.Clear(); // Clear previous items

            string connectionString = "Data Source=THANH_TUNG;Initial Catalog=QLKS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaPhong FROM Phong WHERE MaLoaiPhong = @MaLoaiPhong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbPhong.Items.Add(new
                                {
                                    //  Text = reader["TenPhong"].ToString(),
                                    //Value = reader["MaPhong"].ToString()
                                    Text = reader["MaPhong"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }

            // Set cbPhong to display the 'Text' property
            cbPhong.DisplayMember = "Text";
            cbPhong.ValueMember = "Value";
        }

        private void txtTimKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải số
            }
        }

        private void dtpNgayNhan_ValueChanged(object sender, EventArgs e)
        {

            if (dtpNgayNhan.Value >= dtpNgayTra.Value)
            {
                MessageBox.Show("Ngày nhận phòng phải nhỏ hơn ngày trả phòng.");
                dtpNgayNhan.Value = dtpNgayTra.Value.AddDays(-1); // Đặt lại giá trị ngày nhận phòng

            }
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayTra.Value <= dtpNgayNhan.Value)
            {
                MessageBox.Show("Ngày trả phòng phải lớn hơn ngày nhận phòng.");
                dtpNgayTra.Value = dtpNgayNhan.Value.AddDays(1); // Đặt lại giá trị ngày trả phòng
            }
        }
    } 
}
