using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Areas.Admin.Models
{
    public class NhaSX
    {

        [Display(Name = "Mã NSX")]
        public int idNSX { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Nhập tên nhà sản xuất!")]
        public string TenNSX { get; set; }

        [StringLength(11, MinimumLength = 10, ErrorMessage = "Số điện thoại có 10 hoặc 11 ký tự!")]
        [Display(Name = "Số điện thoại")]
        [Range(0, Int64.MaxValue, ErrorMessage = "Số điện thoại là số")]

        public string SDT { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Mô tả")]
        [AllowHtml]
        public string MoTa { get; set; }
    }
}