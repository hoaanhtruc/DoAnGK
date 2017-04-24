using FashionShopConection;
using MobiShopBUS.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Controllers
{
    public class DanhSachController : Controller
    {
        // GET: DanhSach tên Loại Sản phẩm
        public ActionResult Index()
        {

            return View(LoaiSPBUS.LoadDSLoaiSP());
        }
   
    }
}