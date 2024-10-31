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
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string MaLoaiPhong { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaPhong { get; set; }

        [StringLength(10)]
        public string MaTinhTrang { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual LoaiTinhTrangPhong LoaiTinhTrangPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }
    }
}
