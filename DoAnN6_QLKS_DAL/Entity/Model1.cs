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

        public virtual DbSet<BangChamCong> BangChamCongs { get; set; }
        public virtual DbSet<ChiTietHoaDonDichVu> ChiTietHoaDonDichVus { get; set; }
        public virtual DbSet<ChiTietPhieuDatPhong> ChiTietPhieuDatPhongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDonDichVu> HoaDonDichVus { get; set; }
        public virtual DbSet<HoaDonThanhToan> HoaDonThanhToans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiTinhTrangPhong> LoaiTinhTrangPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanHoiKhachHang> PhanHoiKhachHangs { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDonDichVu>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuDatPhong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuDatPhong>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuDatPhong>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuDatPhong>()
                .HasMany(e => e.HoaDonThanhToans)
                .WithOptional(e => e.ChiTietPhieuDatPhong)
                .HasForeignKey(e => e.MaChiTietPhieu);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonDichVu>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonDichVu>()
                .HasMany(e => e.ChiTietPhieuDatPhongs)
                .WithOptional(e => e.HoaDonDichVu)
                .HasForeignKey(e => e.MaHoaDonDV);

            modelBuilder.Entity<HoaDonThanhToan>()
                .Property(e => e.TongTienPhong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonThanhToan>()
                .Property(e => e.TongTienDichVu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonThanhToan>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Perm)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.GiaPhong)
                .HasPrecision(19, 4);
        }
    }
}
