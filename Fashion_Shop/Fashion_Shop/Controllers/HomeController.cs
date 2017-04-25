using MobiShopBus.Models.BUS;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {

            var LstDS = SPBUS.LoadTop10SP();
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
    }
}