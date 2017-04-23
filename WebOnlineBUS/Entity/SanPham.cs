namespace WebOnlineBUS.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            Tags = new HashSet<Tag>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Tên SP")]
        [StringLength(256)]
        [DisplayName("Tên SP")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Mã Loại SP")]
        [DisplayName("Mã Loại SP")]
        public int LoaiSanPhamID { get; set; }

        [DisplayName(" Hình Ảnh")]
        [StringLength(256)]
        public string HinhAnh { get; set; }

        [DisplayName("Hình Ảnh Khác")]
        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }

        [DisplayName("Giá")]
        public decimal Gia { get; set; }

        [DisplayName("Khuyến Mãi")]
        public decimal? KhuyenMai { get; set; }


        //public int? SoThangBaoHanh { get; set; }

        [StringLength(500)]
        [DisplayName("Mô tả SP")]
        public string MoTa { get; set; }

        //public string Content { get; set; }

        //public bool? HomeFlag { get; set; }
        [DisplayName(" SP Hot")]
        public bool? LaSanPhamHot { get; set; }

        [DisplayName("Lượt Xem")]
        public int? SoLuotXem { get; set; }

        [DisplayName("Ngày Tạo")]
        public DateTime? NgayTao { get; set; }

        [DisplayName("Người Tạo")]
        public int? NguoiTao { get; set; }

        [DisplayName("Ngày Cập Nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [DisplayName("Người Cập Nhật")]
        public int? NguoiCapNhat { get; set; }

        [DisplayName("Khóa")]
        public bool BiKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual NguoiDung NguoiDung1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
