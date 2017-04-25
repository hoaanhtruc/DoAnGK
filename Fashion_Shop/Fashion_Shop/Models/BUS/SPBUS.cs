using FashionShopConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBus.Models.BUS
{
    public class SPBUS
    {
        public static List<SanPham> LoadDSSP()
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT * FROM SanPham ORDER BY idSP DESC").ToList();
        }

        public static SanPham LoadSanPham(int sp)
        {
            var db = new FashionShopConectionDB();
            return db.SingleOrDefault<SanPham>("SELECT * FROM SanPham Where idSP=@0", sp);
        }
        public static void ThemSP(SanPham sp)
        {
            var db = new FashionShopConectionDB();
            db.Insert("SanPham", "idSP", sp);
        }

        public static void SuaSP(SanPham sp)
        {

            var db = new FashionShopConectionDB();
            db.Update("SanPham", "idSP", sp);

        }
        public static void XoaSP(int sp)
        {
            var db = new FashionShopConectionDB();
            db.Delete("SanPham", "idSP", null, sp);
        }

        public static List<SanPham> LoadTop10SP()
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT Top 12 * FROM SanPham ORDER BY idSP DESC").ToList();
        }
        public static List<SanPham> LoadDSLoaiSP(int lsp)
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT * FROM SanPham Where MaLoai =@0 ORDER BY idSP DESC", lsp).ToList();
        }

        public static List<SanPham> LoadTop3SP()
        {
            var db = new FashionShopConectionDB();

            return db.Query<SanPham>("SELECT Top 3 * FROM SanPham ORDER BY idSP ASC").ToList();
        }
    }
}
