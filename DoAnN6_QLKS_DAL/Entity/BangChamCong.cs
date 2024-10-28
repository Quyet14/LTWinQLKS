namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangChamCong")]
    public partial class BangChamCong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChamCong { get; set; }

        public int? MaNhanVien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime GioVao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioRa { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
