using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class employeeServices
    {
        public List<NhanVien> GetAllEmployees()
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.NhanViens.ToList();
        }

        public NhanVien GetEmployeeById(int maNhanVien)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
        }

        public NhanVien GetEmployeeByName(string tenNhanVien)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.NhanViens.FirstOrDefault(nv => nv.HoTen == tenNhanVien);
        }
        public string GetEmployeeNameById(int maNhanVien)
        {
            using (var context = new QuanLyKhachSanDB())
            {
                var employee = context.NhanViens
                    .Where(nv => nv.MaNhanVien == maNhanVien)
                    .Select(nv => nv.HoTen)
                    .FirstOrDefault();
                return employee;
            }
        }

        public NhanVien AuthenticateEmployee(int maNhanVien, string password)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien && nv.Password == password && nv.Active);
        }
    }
}
