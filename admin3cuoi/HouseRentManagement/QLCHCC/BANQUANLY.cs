namespace HouseRentManagement.QLCHCC
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
            PHIEUCHUYENDOes = new HashSet<PHIEUCHUYENDO>();
            PHIEUPHANHOIs = new HashSet<PHIEUPHANHOI>();
            PHIEUPHATs = new HashSet<PHIEUPHAT>();
            PHIEUSUACHUAs = new HashSet<PHIEUSUACHUA>();
            PHIEUTHICONGs = new HashSet<PHIEUTHICONG>();
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

        public virtual ADMIN ADMIN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENDO> PHIEUCHUYENDOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHANHOI> PHIEUPHANHOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSUACHUA> PHIEUSUACHUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHICONG> PHIEUTHICONGs { get; set; }
    }
}
