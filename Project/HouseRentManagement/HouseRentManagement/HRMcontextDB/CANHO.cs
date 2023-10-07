namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CANHO")]
    public partial class CANHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANHO()
        {
            CTNTCB = new HashSet<CTNTCB>();
            DANHSACHNHANKHAU = new HashSet<DANHSACHNHANKHAU>();
            HOPDONGTHUE = new HashSet<HOPDONGTHUE>();
            HOADONTHANHTOAN = new HashSet<HOADONTHANHTOAN>();
            PHIEUCHUYENDO = new HashSet<PHIEUCHUYENDO>();
            PHIEUPHANHOI = new HashSet<PHIEUPHANHOI>();
            PHIEUPHAT = new HashSet<PHIEUPHAT>();
            PHIEUSUACHUA = new HashSet<PHIEUSUACHUA>();
            PHIEUTHICONG = new HashSet<PHIEUTHICONG>();
        }

        [Key]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        [Required]
        [StringLength(20)]
        public string TinhTrang { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTang { get; set; }

        [Required]
        [StringLength(20)]
        public string MaChuSoHuu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLoai { get; set; }

        public virtual CHUSOHUU CHUSOHUU { get; set; }

        public virtual LOAICANHO LOAICANHO { get; set; }

        public virtual TANG TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTNTCB> CTNTCB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHANKHAU> DANHSACHNHANKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONGTHUE> HOPDONGTHUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTHANHTOAN> HOADONTHANHTOAN { get; set; }

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
