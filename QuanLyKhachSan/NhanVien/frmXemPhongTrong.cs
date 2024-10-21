using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.NhanVien
{
    public partial class frmXemPhongTrong : Form
    {
        public frmXemPhongTrong()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvRoomAvailability.AutoGenerateColumns = false;

            dgvRoomAvailability.Columns.Add("MaPhong", "Mã Phòng");
            dgvRoomAvailability.Columns["MaPhong"].DataPropertyName = "MaPhong";

            dgvRoomAvailability.Columns.Add("LoaiPhong", "Loại Phòng");
            dgvRoomAvailability.Columns["LoaiPhong"].DataPropertyName = "LoaiPhong";

            dgvRoomAvailability.Columns.Add("LoaiGiuong", "Loại Giường");
            dgvRoomAvailability.Columns["LoaiGiuong"].DataPropertyName = "LoaiGiuong";

            dgvRoomAvailability.Columns.Add("TinhTrang", "Tình Trạng");
            dgvRoomAvailability.Columns["TinhTrang"].DataPropertyName = "TinhTrang";

            dgvRoomAvailability.Columns.Add("GiaPhong", "Giá Phòng");
            dgvRoomAvailability.Columns["GiaPhong"].DataPropertyName = "GiaPhong";
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Giả định kết nối với cơ sở dữ liệu
                string connectionString = "your_connection_string_here"; // THAY KET NOI BANG CHUOI KE NOI SQL
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT MaPhong, LoaiPhong, LoaiGiuong, TinhTrang, GiaPhong
                FROM Phong
                WHERE TinhTrang = 'Trống';"; // Điều kiện để tìm phòng trống

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán dữ liệu vào DataGridView
                    dgvRoomAvailability.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm phòng trống: " + ex.Message);
            }
        }

       
    }
}
