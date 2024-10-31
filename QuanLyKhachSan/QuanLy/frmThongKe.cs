using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DoAnN6_QLKS_DAL.Entity;

namespace QuanLyKhachSan.QuanLy
{
    public partial class frmThongKe : Form
    {
        private QuanLyKhachSanDB db;

        public frmThongKe()
        {
            InitializeComponent();
            db = new QuanLyKhachSanDB();
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            // Load dữ liệu ban đầu cho ComboBox
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Items.Add(i.ToString());
            }

            var currentYear = DateTime.Now.Year;
            for (int year = currentYear - 2; year <= currentYear; year++)
            {
                cbbNam.Items.Add(year.ToString());
            }

            // Set default selected values
            cbbThang.SelectedIndex = DateTime.Now.Month - 1;
            cbbNam.SelectedIndex = 2; // Năm hiện tại

            // Load initial data
            LoadData(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void LoadData(int month, int year)
        {
            try
            {
                var doanhThuPhong = TinhDoanhThuPhong(month, year);
                var doanhThuDichVu = TinhDoanhThuDichVu(month, year);
                var soLuongPhongDat = DemSoPhongDat(month, year);

                label2.Text = $"{doanhThuPhong:#,##0} VND";
                label4.Text = $"{doanhThuDichVu:#,##0} VND";
                label6.Text = $"{soLuongPhongDat} Phòng";

                UpdatePieChart(doanhThuPhong, doanhThuDichVu);
                UpdateLineChart(year); // Đảm bảo rằng năm được truyền vào đúng

                // Cập nhật lại form
                this.Refresh();
            }
            catch (Exception ex)
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex.Message}\n");
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private decimal TinhDoanhThuPhong(int month, int year)
        {
            return db.PhieuDatPhongs
                .Where(p => p.NgayTraPhong.HasValue &&
                            p.NgayTraPhong.Value.Month == month &&
                            p.NgayTraPhong.Value.Year == year)
                .Sum(p => (decimal?)(p.TongTien ?? 0)) ?? 0;
        }

        private decimal TinhDoanhThuDichVu(int month, int year)
        {
            return db.HoaDonDichVus
                .Where(h => h.NgayLap.Month == month &&
                            h.NgayLap.Year == year)
                .Sum(h => (decimal?)(h.TongTien ?? 0)) ?? 0;
        }

        private int DemSoPhongDat(int month, int year)
        {
            return db.PhieuDatPhongs
                .Where(p => p.NgayTraPhong.HasValue &&
                            p.NgayTraPhong.Value.Month == month &&
                            p.NgayTraPhong.Value.Year == year &&
                            p.MaPhong != null)
                .Select(p => p.MaPhong)
                .Distinct()
                .Count();
        }


        private void UpdatePieChart(decimal doanhThuPhong, decimal doanhThuDichVu)
        {
            try
            {
                panel1.Controls.Clear();
                var pieChart = new Chart();
                pieChart.Dock = DockStyle.Fill;

                // Thêm ChartArea
                var chartArea = new ChartArea();
                chartArea.BackColor = Color.White;
                pieChart.ChartAreas.Add(chartArea);

                // Tạo series cho biểu đồ tròn
                var series = new Series
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    LabelFormat = "P1"  // Changed this line to show percentage
                };

                var total = doanhThuPhong + doanhThuDichVu;
                if (total > 0)
                {
                    // Calculate percentages
                    double phanTramPhong = (double)(doanhThuPhong / total);
                    double phanTramDichVu = (double)(doanhThuDichVu / total);

                    // Add data points directly - PUT THE NEW CODE HERE
                    series.Points.AddXY("Doanh thu phòng", phanTramPhong);
                    series.Points[series.Points.Count - 1].LegendText = "Doanh thu phòng";
                    series.Points[series.Points.Count - 1].Color = Color.FromArgb(24, 157, 228);
                    series.Points[series.Points.Count - 1].LabelForeColor = Color.White;

                    series.Points.AddXY("Doanh thu dịch vụ", phanTramDichVu);
                    series.Points[series.Points.Count - 1].LegendText = "Doanh thu dịch vụ";
                    series.Points[series.Points.Count - 1].Color = Color.FromArgb(82, 183, 233);
                    series.Points[series.Points.Count - 1].LabelForeColor = Color.White;
                }
                else
                {
                    series.Points.AddXY("Không có dữ liệu", 1);
                    series.Points[series.Points.Count - 1].Color = Color.LightGray;
                    series.Points[series.Points.Count - 1].LabelForeColor = Color.White;
                }

                // Rest of your existing code remains the same
                pieChart.Series.Add(series);

                var legend = new Legend
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center
                };
                pieChart.Legends.Add(legend);

                var title = new Title("Tỷ lệ doanh thu")
                {
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Docking = Docking.Top
                };
                pieChart.Titles.Add(title);

                pieChart.AntiAliasing = AntiAliasingStyles.All;
                pieChart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

                series.ChartArea = chartArea.Name;
                chartArea.InnerPlotPosition.Auto = false;
                chartArea.InnerPlotPosition.Width = 85f;
                chartArea.InnerPlotPosition.Height = 85f;
                chartArea.InnerPlotPosition.X = 7.5f;
                chartArea.InnerPlotPosition.Y = 5f;

                panel1.Controls.Add(pieChart);
                pieChart.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật biểu đồ tròn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateLineChart(int year)
        {
            try
            {
                // Xóa tất cả series hiện có
                chart1.Series.Clear();

                // Tạo các series mới với màu sắc tương ứng với các panel
                var series1 = new Series("Doanh thu phòng")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.FromArgb(24, 157, 228), // Màu đỏ nhạt như roundedPanel1
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8
                };

                var series2 = new Series("Doanh thu DV")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.FromArgb(82, 183, 233), // Màu xanh lá như roundedPanel2
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8
                };

                var series3 = new Series("Tổng doanh thu")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.FromArgb(20, 108, 164), // Màu xanh dương như roundedPanel3
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8
                };

                bool hasData = false;
                decimal maxValue = 0;

                // Thêm dữ liệu cho từng tháng
                for (int month = 1; month <= 12; month++)
                {
                    var doanhThuPhong = TinhDoanhThuPhong(month, year);
                    var doanhThuDV = TinhDoanhThuDichVu(month, year);
                    var tongDoanhThu = doanhThuPhong + doanhThuDV;

                    series1.Points.AddXY(month, doanhThuPhong);
                    series2.Points.AddXY(month, doanhThuDV);
                    series3.Points.AddXY(month, tongDoanhThu);

                    maxValue = Math.Max(maxValue, tongDoanhThu);

                    if (doanhThuPhong > 0 || doanhThuDV > 0)
                    {
                        hasData = true;
                    }
                }

                // Thêm series vào chart
                chart1.Series.Add(series1);
                chart1.Series.Add(series2);
                chart1.Series.Add(series3);

                // Cấu hình ChartArea
                var chartArea = chart1.ChartAreas[0];
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.Minimum = 1;
                chartArea.AxisX.Maximum = 12;
                chartArea.AxisX.Title = "Tháng";
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 9);

                // Định dạng trục Y
                chartArea.AxisY.LabelStyle.Format = "{0:#,##0}";
                chartArea.AxisY.Title = "Doanh thu (VNĐ)";
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 9);

                // Điều chỉnh khoảng giá trị trục Y
                if (maxValue > 0)
                {
                    chartArea.AxisY.Maximum = Math.Ceiling(Convert.ToDouble(maxValue) * 1.1);
                }

                // Cấu hình Legend (chú thích)
                chart1.Legends[0].Docking = Docking.Bottom;
                chart1.Legends[0].Alignment = StringAlignment.Center;
                chart1.Legends[0].Font = new Font("Microsoft Sans Serif", 9);

                // Cấu hình tiêu đề
                chart1.Titles.Clear();
                var title = new Title($"Biểu đồ doanh thu năm {year}")
                {
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    ForeColor = Color.Black
                };
                chart1.Titles.Add(title);

                // Hiển thị thông báo nếu không có dữ liệu
                if (!hasData)
                {
                    var noDataTitle = new Title("Không có dữ liệu")
                    {
                        Font = new Font("Microsoft Sans Serif", 10, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Docking = Docking.Top
                    };
                    chart1.Titles.Add(noDataTitle);
                }

                // Cập nhật hiển thị
                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật biểu đồ: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.SelectedItem != null && cbbNam.SelectedItem != null)
            {
                int month = int.Parse(cbbThang.SelectedItem.ToString());
                int year = int.Parse(cbbNam.SelectedItem.ToString());
                LoadData(month, year);
            }
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.SelectedItem != null && cbbNam.SelectedItem != null)
            {
                int month = int.Parse(cbbThang.SelectedItem.ToString());
                int year = int.Parse(cbbNam.SelectedItem.ToString());
                LoadData(month, year);
            }
        }

        private void frmThongKe_Load_1(object sender, EventArgs e)
        {
            // Form đã được load trong constructor
        }
    }
}