using DoAnN6_QLKS_DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class roomTypeServices
    {
        public List<LoaiPhong> GetAll()
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.LoaiPhongs.ToList();
        }
        public LoaiPhong FindLocalById(string roomTypeId)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            return context.LoaiPhongs.FirstOrDefault(p => p.MaLoaiPhong == roomTypeId);
        }
        public void InsertOrUpdate(LoaiPhong roomType)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            context.LoaiPhongs.AddOrUpdate(roomType);
            context.SaveChanges();
        }
        public void Delete(LoaiPhong roomType)
        {
            QuanLyKhachSanDB context = new QuanLyKhachSanDB();
            var roomTypeToDelete = context.LoaiPhongs.FirstOrDefault(x => x.MaLoaiPhong == roomType.MaLoaiPhong);
            if (roomTypeToDelete != null)
            {
                context.LoaiPhongs.Remove(roomTypeToDelete);
                context.SaveChanges();
            }
        }
    }
}
