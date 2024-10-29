using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhGiaServices
    {
        public void AddReview(PhanHoiKhachHang review)
        {
            using (QuanLyKhachSanDB context = new QuanLyKhachSanDB())
            {
                context.PhanHoiKhachHangs.Add(review);
                context.SaveChanges();
            }
        }

        public List<PhanHoiKhachHang> GetAllReviewsByCustomerId(int customerId)
        {
            using (QuanLyKhachSanDB context = new QuanLyKhachSanDB())
            {
                return context.PhanHoiKhachHangs.Where(r => r.MaKhachHang == customerId).ToList();
            }
        }
    }
}
