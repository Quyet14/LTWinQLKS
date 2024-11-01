namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDichVu")]
    public partial class HoaDonDichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonDichVu()
        {
            ChiTietDichVus = new HashSet<ChiTietDichVu>();
        }

        [Key]
        public int MaHoaDon { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDichVu> ChiTietDichVus { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
