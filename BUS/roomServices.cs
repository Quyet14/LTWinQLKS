using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class roomServices
    {
        public List<Phong> GetAll()
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.Phongs.ToList();
        }

        // Find room by ID
        public Phong FindRoomById(string roomId)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.Phongs.FirstOrDefault(p => p.MaPhong == roomId);
        }

        // Insert or update room details
        public void InsertOrUpdate(Phong room)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            context.Phongs.AddOrUpdate(room);
            context.SaveChanges();
        }

        // Delete a room by its ID
        public void Delete(Phong room)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            var roomToDelete = context.Phongs.FirstOrDefault(x => x.MaPhong == room.MaPhong);
            if (roomToDelete != null)
            {
                context.Phongs.Remove(roomToDelete);
                context.SaveChanges();
            }
        }
    }
}
