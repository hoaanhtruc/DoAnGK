namespace WebOnlineBUS.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanAnh")]
    public partial class PhanAnh
    {
        public int ID { get; set; }

        [Required]
        public string NoiDung { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
