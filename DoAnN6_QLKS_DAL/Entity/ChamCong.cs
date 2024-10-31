namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChamCong")]
    public partial class ChamCong
    {
        [Key]
        public int MaChamCong { get; set; }

        public int? MaNhanVien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ngay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
