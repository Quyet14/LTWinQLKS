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
        [Key]
        public int MaPhieu { get; set; }

        public int? MaKhachHang { get; set; }

        [StringLength(50)]
        public string MaPhong { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayDatPhong { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayTraPhong { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
