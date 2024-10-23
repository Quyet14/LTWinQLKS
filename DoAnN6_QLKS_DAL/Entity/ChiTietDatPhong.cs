namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDatPhong")]
    public partial class ChiTietDatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietDatPhong()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int id { get; set; }

        public int? KhachHang_id { get; set; }

        public int? Phong_id { get; set; }

        public int? NhanVien_id { get; set; }

        public DateTime? NgayTra { get; set; }

        public DateTime? NgayNhan { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public virtual Khach_Hang Khach_Hang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
