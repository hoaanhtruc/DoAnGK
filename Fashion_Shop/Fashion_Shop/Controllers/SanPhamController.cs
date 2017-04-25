using MobiShopBus.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;


namespace Fashion_Shop.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index(int? page)
        {
            var LstDS = SPBUS.LoadDSSP();
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        }
        //Load Sản phẩm theo loại
        public ActionResult SPLoai(int id,int? page)
        {
            var LstDS = SPBUS.LoadDSLoaiSP(id);
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Detail(int id)
        {
            
            return View(ChiTietSPBUS.LoadSP(id));
        }
        public ActionResult Item(int id)
        {
            return View(SPBUS.LoadTop3SP());
        }
    }
}