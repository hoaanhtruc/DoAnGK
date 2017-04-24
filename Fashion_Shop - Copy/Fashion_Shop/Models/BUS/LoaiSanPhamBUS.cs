using FashionShopConection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBUS.Models.BUS
{
    public class LoaiSanPhamBUS
    {
        public static List<LoaiSanPham> DanhSach()
        {
            var db = new FashionShopConectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham ORDER BY TenLoai").ToList();
        }
        public static LoaiSanPham LoadLSP(int ma)
        {
            var db = new FashionShopConectionDB();
            return db.SingleOrDefault<LoaiSanPham>("SELECT * FROM LoaiSanPham Where idLoai=@0", ma);
        }
        public static void SaveLSP(LoaiSanPham a)
        {
            var db = new FashionShopConectionDB();
            db.Insert("LoaiSanPham", "idLoai", a);
        }

        public static void EditLSP(LoaiSanPham a)
        {

            var db = new FashionShopConectionDB();
            db.Update("LoaiSanPham", "idLoai", a);

        }
        public static void DeleteLSP(int a)
        {
            var db = new FashionShopConectionDB();
            db.Delete("LoaiSanPham", "idLoai", null, a);
        }
    }
}
