namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANQUANLY")]
    public partial class BANQUANLY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANQUANLY()
        {
            PHIEUCHUYENDO = new HashSet<PHIEUCHUYENDO>();
            PHIEUPHANHOI = new HashSet<PHIEUPHANHOI>();
            PHIEUPHAT = new HashSet<PHIEUPHAT>();
            PHIEUSUACHUA = new HashSet<PHIEUSUACHUA>();
            PHIEUTHICONG = new HashSet<PHIEUTHICONG>();
        }

        [Key]
        [StringLength(20)]
        public string MaQL { get; set; }

        [Required]
        [StringLength(50)]
        public string TenQuanLy { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCV { get; set; }

        [Required]
        [StringLength(12)]
        public string CCCD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ADMINS ADMINS { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENDO> PHIEUCHUYENDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHANHOI> PHIEUPHANHOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSUACHUA> PHIEUSUACHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHICONG> PHIEUTHICONG { get; set; }
    }
}
