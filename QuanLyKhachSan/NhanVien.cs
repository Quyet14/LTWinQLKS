using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenKhanhLong_qlks
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public string SDT { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(int maNhanVien, string HoTen, DateTime ngaySinh, string diaChi, string chucVu)
        {
            MaNhanVien = maNhanVien;
            HoTen = HoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = SDT;
        }

        public void CapNhatNhanVien(string tenNhanVien, string text, DateTime ngaySinh, string diaChi)
        {
            HoTen = tenNhanVien;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SDT = SDT;

        }
        public void ThemNhanVien(string tenNhanVien, string ngaySinh, string diaChi)
        {
            // Logic để thêm nhân viên vào cơ sở dữ liệu hoặc danh sách
            // Ví dụ với SQL:
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien (TenNhanVien, NgaySinh, DiaChi, ChucVu) VALUES (@TenNhanVien, @NgaySinh, @DiaChi)", conn);
                cmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.ExecuteNonQuery();
            }
        }
        public void XoaNhanVien(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien", conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable LayDSChucVu()
        {
            // Logic để lấy danh sách chức vụ từ cơ sở dữ liệu hoặc danh sách
            return new DataTable();

        }
        public DataTable LayDSNhanvien()
        {
            // Logic để lấy danh sách nhân viên từ cơ sở dữ liệu hoặc danh sách
            return new DataTable();
        }
    }

}






