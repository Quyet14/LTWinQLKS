namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatPhong")]
    public partial class PhieuDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDatPhong()
        {
            ChiTietPhieuDatPhongs = new HashSet<ChiTietPhieuDatPhong>();
        }

        [Key]
        public int MaPhieu { get; set; }

        public int? MaKhachHang { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayDat { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayNhanPhong { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayTraPhong { get; set; }

        public int? MaNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuDatPhong> ChiTietPhieuDatPhongs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
