using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnlineConnection;

namespace WebOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new WebOnlineConnectionDB();
            IEnumerable <SanPham> dssp = db.Query<SanPham>("SELECT * FROM SanPham");
            return View(dssp);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}