using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnline.Models;
using WebOnlineConnection;

namespace WebOnline.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new WebOnlineConnectionDB();
            IEnumerable<SanPham> aothunmoi = db.Query<SanPham>("SELECT * FROM SanPham WHERE ID == 1 || ID == 4 && Moi == 1 && BiKhoa==False");
            ViewBag.AoThunMoi = aothunmoi;
            IEnumerable<SanPham> dammoi = db.Query<SanPham>("SELECT * FROM SanPham WHERE ID ==5 && Moi == 1 && BiKhoa==False");
            ViewBag.DamMoi = dammoi;
            IEnumerable<SanPham> quanmoi = db.Query<SanPham>("SELECT * FROM SanPham WHERE ID == 6 || ID == 7 && Moi == 1 && BiKhoa==False");
            ViewBag.QuanMoi = quanmoi;
            return View();
        }
    }
}