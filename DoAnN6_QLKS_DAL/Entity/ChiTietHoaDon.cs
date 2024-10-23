namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        public int id { get; set; }

        public int? CTDV_id { get; set; }

        public int? Phong_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public int? HoaDon_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        public virtual ChiTietDatPhong ChiTietDatPhong { get; set; }

        public virtual ChiTietDichVu ChiTietDichVu { get; set; }
    }
}
