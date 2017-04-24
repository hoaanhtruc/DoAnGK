using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fashion_Shop.Areas.Admin.Models
{
    public class LoaiSP
    {
        public  int idLoai { get; set; }

        [Display(Name = "Loại Sản Phẩm")]
        [Required(ErrorMessage = "Nhập tên loại sản phẩm!")]
        public  string TenLoai { get; set; }
    }
}