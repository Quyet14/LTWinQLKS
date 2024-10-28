namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonThanhToan")]
    public partial class HoaDonThanhToan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public int? MaChiTietPhieu { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienDichVu { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        public virtual ChiTietPhieuDatPhong ChiTietPhieuDatPhong { get; set; }
    }
}
