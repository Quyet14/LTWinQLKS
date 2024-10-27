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
using DoAnN6_QLKS_DAL.Entity;

namespace QuanLyKhachSan.NhanVien
{
    public partial class frmPhong : Form
    {
        Model1 context = new Model1();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            LoadDataToComboBox();
        }

        private void LoadDataToComboBox()
        {
            // Chuỗi kết nối SQL Server
            string connectionString = @"Server=THANH_TUNG;Database=QLKS;Trusted_Connection=True;";

            // Query cho ComboBox LoaiPhong
            string queryLoaiPhong = "SELECT MaLoaiPhong, TenLoaiPhong FROM LoaiPhong";

            // Query cho ComboBox TinhTrangPhong
            string queryTinhTrangPhong = "SELECT MaTinhTrang, TenTinhTrang FROM LoaiTinhTrangPhong";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Mở kết nối SQL

                    // Đổ dữ liệu vào ComboBox LoaiPhong
                    SqlDataAdapter daLoaiPhong = new SqlDataAdapter(queryLoaiPhong, connection);
                    DataTable dtLoaiPhong = new DataTable();
                    daLoaiPhong.Fill(dtLoaiPhong);
                    cbMaLoaiPhong.DataSource = dtLoaiPhong;
                    cbMaLoaiPhong.DisplayMember = "TenLoaiPhong"; // Hiển thị tên loại phòng
                    cbMaLoaiPhong.ValueMember = "MaLoaiPhong"; // Giá trị là mã loại phòng

                    // Đổ dữ liệu vào ComboBox TinhTrangPhong
                    SqlDataAdapter daTinhTrangPhong = new SqlDataAdapter(queryTinhTrangPhong, connection);
                    DataTable dtTinhTrangPhong = new DataTable();
                    daTinhTrangPhong.Fill(dtTinhTrangPhong);
                    cbMaTinhTrang.DataSource = dtTinhTrangPhong;
                    cbMaTinhTrang.DisplayMember = "TenTinhTrang"; // Hiển thị tên tình trạng phòng
                    cbMaTinhTrang.ValueMember = "MaTinhTrang"; // Giá trị là mã tình trạng phòng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu vào ComboBox: " + ex.Message);
                }
            }
        }

        private void LoadDataFromDatabase()
        {
            // Chuỗi kết nối SQL Server
            string connectionString = @"Server=THANH_TUNG;Database=QLKS;Trusted_Connection=True;";

            // Câu truy vấn với JOIN
            string query = @"
                         SELECT p.*, lp.TenLoaiPhong, tt.TenTinhTrang
                         FROM Phong p
                         JOIN LoaiPhong lp ON p.MaLoaiPhong = lp.MaLoaiPhong
                         JOIN LoaiTinhTrangPhong tt ON p.MaTinhTrang = tt.MaTinhTrang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Mở kết nối SQL

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPhong.DataSource = dt; // Gán dữ liệu vào DataGridView

                    // Tùy chỉnh hiển thị cột (nếu cần)
                    dgvPhong.Columns["MaLoaiPhong"].Visible = false; // Ẩn cột mã loại phòng
                    dgvPhong.Columns["MaTinhTrang"].Visible = false; // Ẩn cột mã tình trạng phòng

                    // Đặt tên cột cho dễ hiểu
                    dgvPhong.Columns["TenLoaiPhong"].HeaderText = "Loại Phòng";
                    dgvPhong.Columns["TenTinhTrang"].HeaderText = "Tình Trạng Phòng";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu vào DataGridView: " + ex.Message);
                }
            }



            //string connectionString = @"Server=THANH_TUNG;Database=QLKS;Trusted_Connection=True;"; // Chuỗi kết nối
            //string query = "SELECT * FROM Phong"; // Câu lệnh SQL để lấy dữ liệu

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open(); // Mở kết nối

            //        // Tạo đối tượng SqlDataAdapter để đổ dữ liệu vào DataTable
            //        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            //        // Tạo đối tượng DataTable để chứa dữ liệu
            //        DataTable dataTable = new DataTable();

            //        // Đổ dữ liệu từ SQL vào DataTable
            //        dataAdapter.Fill(dataTable);

            //        // Gán DataTable vào DataGridView
            //        dgvPhong.DataSource = dataTable;

            //        // Tùy chọn: Tự động điều chỉnh kích thước cột cho vừa nội dung
            //        dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //    }
            //}        }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin và giá
            if (!IsInputValid() || !IsPriceValid())
            {
                return; // Dừng xử lý nếu có lỗi
            }

            DataTable dt = (DataTable)dgvPhong.DataSource;
            DataRow newRow = dt.NewRow();

            // Gán giá trị cho các cột
            newRow["MaPhong"] = txtMaPhong.Text; // Số phòng từ một textbox
            newRow["MaLoaiPhong"] = cbMaLoaiPhong.SelectedValue; // Mã loại phòng từ combobox
            newRow["MaTinhTrang"] = cbMaTinhTrang.SelectedValue; // Mã tình trạng phòng từ combobox
            newRow["GiaPhong"] = decimal.Parse(txtGia.Text); // Giá phòng từ textbox
                                                             // Gán thêm các giá trị khác nếu cần

            dt.Rows.Add(newRow); // Thêm dòng mới vào DataTable
            if (UpdateDatabase(dt))
            {
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvPhong.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {

                // Kiểm tra thông tin và giá
                if (!IsInputValid() || !IsPriceValid())
                {
                    return; // Dừng xử lý nếu có lỗi
                }

                DataTable dt = (DataTable)dgvPhong.DataSource;
                DataRow row = dt.Rows[selectedRowIndex];

                // Cập nhật giá trị
                row["MaPhong"] = txtMaPhong.Text;
                row["MaLoaiPhong"] = cbMaLoaiPhong.SelectedValue;
                row["MaTinhTrang"] = cbMaTinhTrang.SelectedValue;
                row["GiaPhong"] = decimal.Parse(txtGia.Text); // Cập nhật giá phòng
                                                              // Cập nhật thêm các giá trị khác nếu cần

                if (UpdateDatabase(dt))
                {
                    MessageBox.Show("Sửa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

          private bool UpdateDatabase(DataTable dt)
           {
          string connectionString = @"Server=THANH_TUNG;Database=QLKS;Trusted_Connection=True;";

          using (SqlConnection connection = new SqlConnection(connectionString))
          {
              connection.Open();
              SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Phong", connection);
              SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

              try
              {
                  // Cập nhật cơ sở dữ liệu
                  dataAdapter.Update(dt);
                  return true; // Trả về true nếu cập nhật thành công
              }
              catch (Exception)
              {
                  return false; // Trả về false nếu có lỗi
              }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvPhong.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {

                // Kiểm tra thông tin và giá
                if (!IsInputValid() || !IsPriceValid())
                {
                    return; // Dừng xử lý nếu có lỗi
                }

                DataTable dt = (DataTable)dgvPhong.DataSource;
                DataRow row = dt.Rows[selectedRowIndex];

                // Cập nhật giá trị
                row["MaPhong"] = txtMaPhong.Text;
                row["MaLoaiPhong"] = cbMaLoaiPhong.SelectedValue;
                row["MaTinhTrang"] = cbMaTinhTrang.SelectedValue;
                row["GiaPhong"] = decimal.Parse(txtGia.Text); // Cập nhật giá phòng
                                                              // Cập nhật thêm các giá trị khác nếu cần

                if (UpdateDatabase(dt))
                {
                    MessageBox.Show("Sửa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || cbMaLoaiPhong.SelectedValue == null ||
                cbMaTinhTrang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu thông tin không hợp lệ
            }
            return true; // Trả về true nếu thông tin hợp lệ
        }

        private bool IsPriceValid()
        {
            if (!decimal.TryParse(txtGia.Text, out decimal giaPhong))
            {
                MessageBox.Show("Giá phòng phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu giá không hợp lệ
            }
            return true; // Trả về true nếu giá hợp lệ
        }
    }
}
