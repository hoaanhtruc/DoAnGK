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
            var LstDS = SanPhamBUS.DanhSach();
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        }
        //Load Sản phẩm theo loại
        public ActionResult SPLoai(int id,int? page)
        {
            var LstDS = SanPhamBUS.DanhSachLoai(id);
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Detail(int id)
        {
            
            return View(ChiTietSanPhamBUS.LoadSP(id));
        }
    }
}