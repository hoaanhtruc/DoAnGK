namespace WebOnlineBUS.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucCon")]
    public partial class DanhMucCon
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        [Required]
        [StringLength(256)]
        public string URL { get; set; }

        [StringLength(10)]
        public string ThuTuHienThi { get; set; }

        public int DanhMucChaID { get; set; }

        public bool BiKhoa { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
