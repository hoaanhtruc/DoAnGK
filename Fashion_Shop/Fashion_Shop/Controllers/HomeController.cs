using MobiShopBus.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View(SPBUS.LoadTop10SP());
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