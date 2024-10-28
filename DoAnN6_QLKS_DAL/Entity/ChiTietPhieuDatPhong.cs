namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuDatPhong")]
    public partial class ChiTietPhieuDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietPhieuDatPhong()
        {
            HoaDonThanhToans = new HashSet<HoaDonThanhToan>();
        }

        [Key]
        public int MaChiTiet { get; set; }

        public int? MaPhieu { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        public int? MaHoaDonDV { get; set; }

        public int? SoNgayO { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public virtual HoaDonDichVu HoaDonDichVu { get; set; }

        public virtual PhieuDatPhong PhieuDatPhong { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonThanhToan> HoaDonThanhToans { get; set; }
    }
}
