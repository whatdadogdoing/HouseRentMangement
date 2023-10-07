namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [Key]
        [StringLength(20)]
        public string MaTheCuDan { get; set; }

        [Required]
        [StringLength(60)]
        public string MatKhau { get; set; }

        public virtual THECUDAN THECUDAN { get; set; }
    }
}
