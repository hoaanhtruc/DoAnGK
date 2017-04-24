using FashionShopConection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBUS.Models.BUS
{
    public class LoaiSPBUS
    {
        public static List<LoaiSanPham> LoadDSLoaiSP()
        {
            var db = new FashionShopConectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham ORDER BY TenLoai").ToList();
        }
        public static LoaiSanPham LoadLoaiSP(int id)
        {
            var db = new FashionShopConectionDB();
            return db.SingleOrDefault<LoaiSanPham>("SELECT * FROM LoaiSanPham Where idLoai=@0", id);
        }
        public static void ThemDSLoaiSP(LoaiSanPham lsp)
        {
            var db = new FashionShopConectionDB();
            db.Insert("LoaiSanPham", "idLoai", lsp);
        }

        public static void SuaDSLoaiSP(LoaiSanPham lsp)
        {

            var db = new FashionShopConectionDB();
            db.Update("LoaiSanPham", "idLoai", lsp);

        }
        public static void XoaDSLoaiSP(int lsp)
        {
            var db = new FashionShopConectionDB();
            db.Delete("LoaiSanPham", "idLoai", null, lsp);
        }
    }
}
