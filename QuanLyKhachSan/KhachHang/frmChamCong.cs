using DoAnN6_QLKS_DAL.Entities;
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
    public partial class frmChamCong : Form
    {
        private readonly Model1 context = new Model1();

        public frmChamCong()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvChamCong.AutoGenerateColumns = false;

            dgvChamCong.Columns.Add("MaChamCong", "Mã Chấm Công");
            dgvChamCong.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvChamCong.Columns.Add("GioVao", "Giờ Vào");
            dgvChamCong.Columns.Add("GioRa", "Giờ Ra");

            setGridViewStyle(dgvChamCong);
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAttendanceRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đảm bảo chỉ có một định nghĩa cho LoadAttendanceRecords
        private void LoadAttendanceRecords()
        {
            try
            {
                var records = context.BangChamCongs
                    .Include("NhanVien")
                    .OrderBy(x => x.MaChamCong) // Sắp xếp theo mã chấm công
                    .ToList();

                BindGrid(records);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<BangChamCong> records)
        {
            dgvChamCong.Rows.Clear();
            foreach (var item in records)
            {
                int index = dgvChamCong.Rows.Add();
                dgvChamCong.Rows[index].Cells["MaChamCong"].Value = item.MaChamCong;
                dgvChamCong.Rows[index].Cells["MaNhanVien"].Value = item.MaNhanVien;

                // Kiểm tra và hiển thị giờ vào
                if (item.GioVao != DateTime.MinValue)
                {
                    dgvChamCong.Rows[index].Cells["GioVao"].Value = item.GioVao.ToString("MM/dd/yyyy hh:mm tt");
                }
                else
                {
                    dgvChamCong.Rows[index].Cells["GioVao"].Value = "Chưa vào";
                }

                // Kiểm tra và hiển thị giờ ra
                if (item.GioRa.HasValue)
                {
                    dgvChamCong.Rows[index].Cells["GioRa"].Value = item.GioRa.Value.ToString("MM/dd/yyyy hh:mm tt");
                }
                else
                {
                    dgvChamCong.Rows[index].Cells["GioRa"].Value = "Chưa ra";
                }
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào một ô của dòng hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại được chọn
                DataGridViewRow row = this.dgvChamCong.Rows[e.RowIndex];

                // Kiểm tra xem dòng có dữ liệu hay không
                if (row.Cells["MaChamCong"].Value != null)
                {
                    // Chuyển dữ liệu từ dòng được chọn sang các textbox tương ứng
                    vtbMaCC.Text = row.Cells["MaChamCong"].Value.ToString();
                    vbtGioVao.Value = DateTime.Parse(row.Cells["GioVao"].Value.ToString());

                    // Kiểm tra xem ô "Giờ Ra" có giá trị null hay không
                    if (row.Cells["GioRa"].Value != null && row.Cells["GioRa"].Value.ToString() != "Chưa ra")
                    {
                        vbtGioRa.Value = DateTime.Parse(row.Cells["GioRa"].Value.ToString());
                    }
                    else
                    {
                        // Nếu ô "Giờ Ra" là null, đặt giá trị DateTimePicker là giá trị hiện tại
                        vbtGioRa.Value = DateTime.Now;
                    }
                }
            }
        }
        // Xóa kiểm tra mã chấm công
        private void vbtGioVao_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn nhân viên chưa
                if (dgvChamCong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã nhân viên từ dòng được chọn
                int maNhanVien = Convert.ToInt32(dgvChamCong.SelectedRows[0].Cells["MaNhanVien"].Value);

                // Lấy ngày hiện tại
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                // Kiểm tra xem nhân viên đã chấm công vào hôm nay chưa
                var existingToday = context.BangChamCongs
                    .FirstOrDefault(bc =>
                        bc.MaNhanVien == maNhanVien &&
                        bc.GioVao >= today &&
                        bc.GioVao < tomorrow);

                if (existingToday != null)
                {
                    MessageBox.Show("Nhân viên đã chấm công vào hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo mã chấm công mới (tự động tăng)
                int newMaChamCong = 1; // Giá trị mặc định
                var lastRecord = context.BangChamCongs
                    .OrderByDescending(x => x.MaChamCong)
                    .FirstOrDefault();
                if (lastRecord != null)
                {
                    newMaChamCong = lastRecord.MaChamCong + 1;
                }

                // Tạo bản ghi chấm công mới
                var chamCong = new BangChamCong
                {
                    MaChamCong = newMaChamCong,
                    MaNhanVien = maNhanVien,
                    GioVao = DateTime.Now,
                    GioRa = null
                };

                // Thêm vào database
                context.BangChamCongs.Add(chamCong);
                context.SaveChanges();

                LoadAttendanceRecords();
                MessageBox.Show("Chấm công vào thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void vbtGioRa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn bản ghi chưa
                if (dgvChamCong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn bản ghi chấm công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã chấm công từ dòng được chọn
                DataGridViewRow selectedRow = dgvChamCong.SelectedRows[0];
                int maChamCong = Convert.ToInt32(selectedRow.Cells["MaChamCong"].Value);

                // Kiểm tra giờ ra trong DataGridView
                string gioRaValue = selectedRow.Cells["GioRa"].Value?.ToString();
                if (gioRaValue != "Chưa ra")
                {
                    MessageBox.Show("Nhân viên đã chấm công ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm bản ghi chấm công
                var chamCong = context.BangChamCongs.FirstOrDefault(bc => bc.MaChamCong == maChamCong);

                if (chamCong == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi chấm công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem có giờ vào không
                if (chamCong.GioVao == DateTime.MinValue)
                {
                    MessageBox.Show("Nhân viên chưa chấm công vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật giờ ra
                chamCong.GioRa = DateTime.Now;

                // Lưu thay đổi
                context.SaveChanges();

                LoadAttendanceRecords();
                MessageBox.Show("Chấm công ra thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}