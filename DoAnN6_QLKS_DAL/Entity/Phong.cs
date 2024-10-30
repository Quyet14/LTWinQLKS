namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            PhieuDatPhongs = new HashSet<PhieuDatPhong>();
        }

        [Key]
        [StringLength(50)]
        public string MaPhong { get; set; }

        public int? MaLoaiPhong { get; set; }

        public int? MaTinhTrangPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaPhong { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }

        public virtual TinhTrangPhong TinhTrangPhong { get; set; }
    }
}
