using Fashion_Shop.Areas.Admin.Models;
using FashionShopConection;
using MobiShopBus.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Areas.Admin
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index()
        {
            return View(SPBUS.LoadDSSP());
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham n)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var sp = new SanPham();
                    sp.idSP = sp.idSP;
                    sp.MoTa = n.MoTa;
                    sp.TenSP = n.TenSP;
                    sp.MaLoai = n.MaLoai;
                    sp.MaNSX = n.MaNSX;
                    sp.HinhAnh = n.HinhAnh;
                    sp.GiaSP = n.GiaSP;
                    SPBUS.ThemSP(sp);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }


            }
            else
            {
                return View();
            }
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(SanPham n)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var sp = new SanPham();
                    sp.idSP = sp.idSP;
                    sp.MoTa = n.MoTa;
                    sp.TenSP = n.TenSP;
                    sp.MaLoai = n.MaLoai;
                    sp.MaNSX = n.MaNSX;
                    sp.HinhAnh = n.HinhAnh;
                    sp.GiaSP = n.GiaSP;
                    SPBUS.SuaSP(sp);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }


            }
            else
            {
                return View();
            }

        }

        // GET: Admin/SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            SPBUS.XoaSP(id);
            return RedirectToAction("Index");
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
