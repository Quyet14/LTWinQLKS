using System;
using System.Data.Entity;
using System.Linq;
using DoAnN6_QLKS_DAL.Entity;

namespace BUS
{
    public class chamCongServices
    {
        public void RecordLogin(int maNhanVien)
        {
            try
            {
                using (QuanLyKhachSanDB context = new QuanLyKhachSanDB())
                {
                    // Check if a record for today's date already exists for this employee
                    DateTime today = DateTime.Today;
                    bool alreadyCheckedIn = context.ChamCongs
                        .Any(cc => cc.MaNhanVien == maNhanVien && 
                                   DbFunctions.TruncateTime(cc.Ngay) == today);

                    if (alreadyCheckedIn)
                    {
                        // Employee has already checked in today, so we don't add a new record
                        Console.WriteLine("Employee has already checked in today.");
                        return;
                    }

                    // Otherwise, record the new check-in
                    ChamCong chamCong = new ChamCong
                    {
                        MaNhanVien = maNhanVien,
                        Ngay = DateTime.Now
                    };

                    context.ChamCongs.Add(chamCong);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log error or handle as needed
                Console.WriteLine($"Error recording login time: {ex.Message}");
            }
        }
    }
}