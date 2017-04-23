using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebOnlineBUS.Entity;

namespace WebOnline.Models
{
    public class SanPhamModels
    {
        private OnlineShopDbContext context = null;
        public SanPhamModels()
        {
            context = new OnlineShopDbContext();
        }
        public List<SanPham> ListAll()
        {
            var list = context.Database.SqlQuery<SanPham>("Sp_SanPham_ListAll").ToList();
            return list;
        }
    }
}