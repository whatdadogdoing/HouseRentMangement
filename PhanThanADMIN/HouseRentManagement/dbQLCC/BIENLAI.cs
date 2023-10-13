namespace HouseRentManagement.dbQLCC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIENLAI")]
    public partial class BIENLAI
    {
        [Key]
        [StringLength(20)]
        public string SoBienLai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public decimal? TongTienThanhToan { get; set; }

        [Required]
        [StringLength(20)]
        public string SoHoaDon { get; set; }

        public virtual HOADONTHANHTOAN HOADONTHANHTOAN { get; set; }
    }
}
