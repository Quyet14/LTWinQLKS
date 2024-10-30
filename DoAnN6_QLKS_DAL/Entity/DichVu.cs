namespace DoAnN6_QLKS_DAL.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            ChiTietDichVus = new HashSet<ChiTietDichVu>();
        }

        [Key]
        public int MaDichVu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDichVu { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDichVu> ChiTietDichVus { get; set; }
    }
}
