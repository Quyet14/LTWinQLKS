namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanHoiKhachHang")]
    public partial class PhanHoiKhachHang
    {
        [Key]
        public int MaPhanHoi { get; set; }

        public int? MaKhachHang { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayPhanHoi { get; set; }

        public int? Rating { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
