using FashionShopConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBus.Models.BUS
{
    public class ChiTietSPBUS
    {
        public static List<ChiTietSanPham> DanhSach()
        {
            var db = new FashionShopConectionDB();

            return db.Query<ChiTietSanPham>("SELECT * FROM ChiTietSanPham ORDER BY idSP DESC").ToList();
        }
        
        public static ChiTietSanPham LoadSP(int ma)
        {
            var db = new FashionShopConectionDB();

            return db.SingleOrDefault<ChiTietSanPham>("SELECT * FROM ChiTietSanPham Where idSP=@0", ma);
        }
    }
}
