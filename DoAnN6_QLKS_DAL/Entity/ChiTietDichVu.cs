namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDichVu")]
    public partial class ChiTietDichVu
    {
        [Key]
        public int MaChiTietDichVu { get; set; }

        public int? MaHoaDon { get; set; }

        public int? MaDichVu { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDonDichVu HoaDonDichVu { get; set; }
    }
}
