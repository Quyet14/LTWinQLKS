using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnN6_QLKS_DAL.Entity
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChamCong> ChamCongs { get; set; }
        public virtual DbSet<ChiTietDatPhong> ChiTietDatPhongs { get; set; }
        public virtual DbSet<ChiTietDichVu> ChiTietDichVus { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Khach_Hang> Khach_Hang { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TinhTrangPhong> TinhTrangPhongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDatPhong>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietDatPhong>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithOptional(e => e.ChiTietDatPhong)
                .HasForeignKey(e => e.Phong_id);

            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.TongChiPhi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietDichVu>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithOptional(e => e.ChiTietDichVu)
                .HasForeignKey(e => e.CTDV_id);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithOptional(e => e.DichVu)
                .HasForeignKey(e => e.DichVu_id);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.GioiTinh)
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .HasMany(e => e.ChiTietDatPhongs)
                .WithOptional(e => e.Khach_Hang)
                .HasForeignKey(e => e.KhachHang_id);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.LoaiPhong)
                .HasForeignKey(e => e.LoaiPhong_id);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChamCongs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.NhanVien_id);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChiTietDatPhongs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.NhanVien_id);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.ChiTietDatPhongs)
                .WithOptional(e => e.Phong)
                .HasForeignKey(e => e.Phong_id);

            modelBuilder.Entity<TinhTrangPhong>()
                .Property(e => e.TinhTrang)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangPhong>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.TinhTrangPhong)
                .HasForeignKey(e => e.TinhTrang_id);
        }
    }
}
