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
        public bool AddReview(PhanHoiKhachHang review)
        {
            using (QuanLyKhachSanDB context = new QuanLyKhachSanDB())
            {
                // Check if customer has an active booking
                var activeBooking = context.PhieuDatPhongs
                    .FirstOrDefault(p => p.MaKhachHang == review.MaKhachHang
                                         && p.NgayDatPhong <= DateTime.Now
                                         && p.NgayTraPhong >= DateTime.Now);

                if (activeBooking == null)
                {
                    return false; // No active booking found
                }

                // Check if customer already submitted feedback for this booking period
                var existingFeedback = context.PhanHoiKhachHangs
                    .FirstOrDefault(f => f.MaKhachHang == review.MaKhachHang
                                         && f.NgayPhanHoi >= activeBooking.NgayDatPhong
                                         && f.NgayPhanHoi <= activeBooking.NgayTraPhong);

                if (existingFeedback != null)
                {
                    return false; // Feedback already exists for this booking period
                }

                // Add the new feedback
                context.PhanHoiKhachHangs.Add(review);
                context.SaveChanges();
                return true;
            }
        }
        public bool CanCustomerReview(int customerId)
        {
            using (QuanLyKhachSanDB context = new QuanLyKhachSanDB())
            {
                // Check for active booking
                var activeBooking = context.PhieuDatPhongs
                    .FirstOrDefault(p => p.MaKhachHang == customerId
                                         && p.NgayDatPhong <= DateTime.Now
                                         && p.NgayTraPhong >= DateTime.Now);

                if (activeBooking == null)
                {
                    return false; // No active booking
                }

                // Check if feedback already exists for this booking period
                var existingFeedback = context.PhanHoiKhachHangs
                    .Any(f => f.MaKhachHang == customerId
                              && f.NgayPhanHoi >= activeBooking.NgayDatPhong
                              && f.NgayPhanHoi <= activeBooking.NgayTraPhong);

                return !existingFeedback; // Can review only if no feedback exists
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
