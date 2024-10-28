using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class customerServices
    {
        List<KhachHang> GetAll()
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.ToList();
        }
        public KhachHang GetCustomerById(int maKhachHang)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }
        public List<KhachHang> GetCustomersByName(string name)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.Where(kh => kh.HoTen.Contains(name)).ToList();
        }
    }
}
