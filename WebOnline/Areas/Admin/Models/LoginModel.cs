using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebOnline.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool RememberMe { get; set; }
    }
}