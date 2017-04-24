using FashionShopConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBus.Models.BUS
{
    public class SanPhamBUS
    {
        public static List<SanPham> DanhSach()
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT * FROM SanPham ORDER BY idSP DESC").ToList();
        }

        public static SanPham LoadSP(int ma)
        {
            var db = new FashionShopConectionDB();
            return db.SingleOrDefault<SanPham>("SELECT * FROM SanPham Where idSP=@0", ma);
        }
        public static void SaveSP(SanPham a)
        {
            var db = new FashionShopConectionDB();
            db.Insert("SanPham", "idSP", a);
        }

        public static void EditSP(SanPham a)
        {

            var db = new FashionShopConectionDB();
            db.Update("SanPham", "idSP", a);

        }
        public static void DeleteSP(int a)
        {
            var db = new FashionShopConectionDB();
            db.Delete("SanPham", "idSP", null, a);
        }

        public static List<SanPham> Top6()
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT Top 6 * FROM SanPham ORDER BY idSP DESC").ToList();
        }
        public static List<SanPham> DanhSachLoai(int n)
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT * FROM SanPham Where MaLoai =@0 ORDER BY idSP DESC", n).ToList();
        }
        public static List<SanPham> DanhSachLoaiLienQuan(int id, int ml)
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT * FROM SanPham Where idSP != @0 and MaLoai =@1 ORDER BY idSP DESC", id, ml).ToList();
        }

    }
}
