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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietDichVu()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int id { get; set; }

        public int? DichVu_id { get; set; }

        [Column("_id")]
        public int? C_id { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongChiPhi { get; set; }

        public virtual DichVu DichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
