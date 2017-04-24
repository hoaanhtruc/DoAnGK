using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Areas.Admin.Models
{
    public class SP
    {
        [Display(Name = "Mã SP")]
        public int idSP { get; set; }

        [Display(Name = "Tên SP")]
        [Required(ErrorMessage = "Nhập tên sản phẩm!")]
        public string TenSP { get; set; }

        
        [Display(Name = "Giá SP")]
        [Required(ErrorMessage = "Nhập tên sản phẩm!")]
        public int GiaSP { get; set; }

        [Display(Name ="Mã Loại")]
        public int MaLoai { get; set; }

        [Display(Name = "Mã NSX")]
        public int MaNSX { get; set; }

        [Display(Name ="Hình Ảnh")]
        [AllowHtml]
        public string HinhAnh { get; set; }

        [Display(Name = "Mô tả")]
        [AllowHtml]
        public string MoTa { get; set; }
    }
}