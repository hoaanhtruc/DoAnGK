namespace WebOnlineBUS.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoTroTrucTuyen")]
    public partial class HoTroTrucTuyen
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public bool BiKhoa { get; set; }
    }
}
