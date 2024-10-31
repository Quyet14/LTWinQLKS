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
        public List<KhachHang> GetAll()
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.ToList();
        }
        public KhachHang GetCustomerById(int? maKhachHang)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }
        public List<KhachHang> GetCustomersByName(string name)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.Where(kh => kh.HoTen.Contains(name)).ToList();
        }
        public KhachHang AuthenticateCustomer(string username, string password, out bool hasActiveBooking)
        {
            hasActiveBooking = false;
            using (var context = new QuanLyKhachSanDB())
            {
                var customer = context.KhachHangs.FirstOrDefault(c => c.SoDienThoai == username && c.SoDienThoai == password);
                if (customer != null)
                {
                    // Check if the customer has an active booking
                    var activeBooking = context.PhieuDatPhongs
                        .Any(p => p.MaKhachHang == customer.MaKhachHang &&
                                  p.NgayDatPhong <= DateTime.Now &&
                                  p.NgayTraPhong >= DateTime.Now);

                    hasActiveBooking = activeBooking;
                }
                return customer;
            }
        }

        public KhachHang FindCustomerByPhone(string soDienThoai)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == soDienThoai);
        }
    }
}
