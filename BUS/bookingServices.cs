using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BUS
{
    public class bookingServices
    {
        // Get all bookings
        public List<PhieuDatPhong> GetAll()
        {
            using (var context = new QuanLyKhachSanDB())
            {
                return context.PhieuDatPhongs.ToList();
            }
        }

        // Get current booking for a specific room
        public PhieuDatPhong GetCurrentBookingForRoom(string maPhong)
        {
            using (var context = new QuanLyKhachSanDB())
            {
                return context.PhieuDatPhongs
                    .Where(p => p.MaPhong == maPhong && p.NgayTraPhong > DateTime.Now)
                    .OrderByDescending(p => p.NgayDatPhong)
                    .FirstOrDefault();
            }
        }

        // Create new booking
        public bool CreateBooking(PhieuDatPhong booking, decimal roomPrice, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                if (booking.NgayDatPhong >= booking.NgayTraPhong)
                {
                    errorMessage = "Ngày trả phòng phải sau ngày đặt phòng.";
                    return false;
                }

                using (var context = new QuanLyKhachSanDB())
                {
                    // Existing validation code...

                    // Calculate total amount
                    booking.TongTien = CalculateTotalAmount((DateTime)booking.NgayDatPhong, (DateTime)booking.NgayTraPhong, roomPrice);

                    // Add booking
                    context.PhieuDatPhongs.Add(booking);

                    // Update room status
                    var room = context.Phongs.Find(booking.MaPhong);
                    if (room != null)
                    {
                        room.MaTinhTrang = "TT02";
                    }

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi: {ex.Message}";
                return false;
            }
        }

        private decimal CalculateTotalAmount(DateTime checkIn, DateTime checkOut, decimal roomPrice)
        {
            // Calculate the total days (including partial days)
            TimeSpan duration = checkOut - checkIn;
            double totalDays = Math.Ceiling(duration.TotalDays);

            // Calculate total amount
            return (decimal)totalDays * roomPrice;
        }

        // Get bookings by customer ID
        public List<PhieuDatPhong> GetBookingsByCustomerId(int maKhachHang)
        {
            using (var context = new QuanLyKhachSanDB())
            {
                return context.PhieuDatPhongs
                    .Where(p => p.MaKhachHang == maKhachHang)
                    .ToList();
            }
        }

        // Get bookings by room ID
        public List<PhieuDatPhong> GetBookingsByRoomId(string maPhong)
        {
            using (var context = new QuanLyKhachSanDB())
            {
                return context.PhieuDatPhongs
                    .Where(p => p.MaPhong == maPhong)
                    .ToList();
            }
        }

        // Check if a room is available for a specific period
        public bool IsRoomAvailable(string maPhong, DateTime checkIn, DateTime checkOut)
        {
            using (var context = new QuanLyKhachSanDB())
            {
                var conflictingBookings = context.PhieuDatPhongs
                    .Where(p => p.MaPhong == maPhong &&
                              ((checkIn >= p.NgayDatPhong && checkIn < p.NgayTraPhong) ||
                               (checkOut > p.NgayDatPhong && checkOut <= p.NgayTraPhong)))
                    .Any();

                return !conflictingBookings;
            }
        }

        // Cancel booking
        public bool CancelBooking(int maPhieu)
        {
            try
            {
                using (var context = new QuanLyKhachSanDB())
                {
                    var booking = context.PhieuDatPhongs.Find(maPhieu);
                    if (booking != null)
                    {
                        // Update room status back to "Trống" (TT01)
                        var room = context.Phongs.Find(booking.MaPhong);
                        if (room != null)
                        {
                            room.MaTinhTrang = "TT01";
                        }

                        context.PhieuDatPhongs.Remove(booking);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // Check out
        public bool CheckOut(int maPhieu, decimal roomPrice)
        {
            try
            {
                using (var context = new QuanLyKhachSanDB())
                {
                    var booking = context.PhieuDatPhongs.Find(maPhieu);
                    if (booking != null)
                    {
                        // Set actual check-out time
                        DateTime actualCheckOut = DateTime.Now;
                        booking.NgayTraPhong = actualCheckOut;

                        // Recalculate total amount based on actual stay duration
                        booking.TongTien = CalculateTotalAmount((DateTime)booking.NgayDatPhong, actualCheckOut, roomPrice);

                        // Update room status to "Đang vệ sinh" (TT03)
                        var room = context.Phongs.Find(booking.MaPhong);
                        if (room != null)
                        {
                            room.MaTinhTrang = "TT03";
                        }

                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}