using FashionShopConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiShopBus.Models.BUS
{
    public class NSXBUS
    {
        public static List<NhaSanXuat> DanhSach()
        {
            var db = new FashionShopConectionDB();

            return db.Query<NhaSanXuat>("SELECT * FROM NhaSanXuat ORDER BY TenNSX").ToList();
        }
        public static NhaSanXuat LoadNSX(int ma)
        {
            var db = new FashionShopConectionDB();
            return db.SingleOrDefault<NhaSanXuat>("SELECT * FROM NhaSanXuat Where idNSX=@0", ma);
        }
        public static void SaveNSX(NhaSanXuat a)
        {
            var db = new FashionShopConectionDB();
            db.Insert("NhaSanXuat", "idNSX", a);
        }

        public static void EditNSX(NhaSanXuat a)
        {

            var db = new FashionShopConectionDB();
            db.Update("NhaSanXuat", "idNSX", a);

        }
        public static void DeleteNSX(int a)
        {
            var db = new FashionShopConectionDB();
            db.Delete("NhaSanXuat", "idNSX", null, a);
        }
    }
}
