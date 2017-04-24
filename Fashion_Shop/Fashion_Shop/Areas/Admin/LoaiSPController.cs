using Fashion_Shop.Areas.Admin.Models;
using FashionShopConection;
using MobiShopBUS.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fashion_Shop.Areas.Admin
{
    public class LoaiSPController : Controller
    {
        // GET: Admin/LoaiSP
        public ActionResult Index()
        {
            return View(LoaiSPBUS.LoadDSLoaiSP());
        }

        // GET: Admin/LoaiSP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LoaiSP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSP/Create
        [HttpPost]
        public ActionResult Create(LoaiSP n)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var lsp = new LoaiSanPham();
                    lsp.idLoai = n.idLoai;
                    lsp.TenLoai = n.TenLoai;

                    LoaiSPBUS.ThemDSLoaiSP(lsp);
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

        // GET: Admin/LoaiSP/Edit/5
        public ActionResult Edit(int id)
        {
            
            var lsp = LoaiSPBUS.LoadLoaiSP(id);
            var n = new LoaiSP();
            n.idLoai = lsp.idLoai;
            n.TenLoai = lsp.TenLoai;
            return View(n);
        }

        // POST: Admin/LoaiSP/Edit/5
        [HttpPost]
        public ActionResult Edit(LoaiSP n)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var lsp = new LoaiSanPham();
                    lsp.idLoai = n.idLoai;
                    lsp.TenLoai = n.TenLoai;

                    LoaiSPBUS.SuaDSLoaiSP(lsp);
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

        // GET: Admin/LoaiSP/Delete/5
        public ActionResult Delete(int id)
        {
            LoaiSPBUS.XoaDSLoaiSP(id);
            return View();
        }

        // POST: Admin/LoaiSP/Delete/5
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
