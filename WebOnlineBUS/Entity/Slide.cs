namespace WebOnlineBUS.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slide
    {
        public int ID { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        [StringLength(256)]
        public string MoTa { get; set; }

        [StringLength(256)]
        public string HinhAnh { get; set; }

        [StringLength(256)]
        public string URL { get; set; }

        public bool BiKhoa { get; set; }
    }
}
