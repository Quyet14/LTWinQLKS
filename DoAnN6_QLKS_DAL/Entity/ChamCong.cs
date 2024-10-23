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
        public int id { get; set; }

        public int? NhanVien_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayVao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayRa { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
