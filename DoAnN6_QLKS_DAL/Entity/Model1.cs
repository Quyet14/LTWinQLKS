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
        public virtual DbSet<ChiTietDichVu> ChiTietDichVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDonDichVu> HoaDonDichVus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanHoiKhachHang> PhanHoiKhachHangs { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TinhTrangPhong> TinhTrangPhongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithOptional(e => e.DichVu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<HoaDonDichVu>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDonDichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithOptional(e => e.HoaDonDichVu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<PhanHoiKhachHang>()
                .Property(e => e.Rating)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.GiaPhong)
                .HasPrecision(19, 4);
        }
    }
}
