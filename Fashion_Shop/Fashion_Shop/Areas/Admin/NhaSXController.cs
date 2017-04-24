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
    public class NhaSXController : Controller
    {
        // GET: Admin/NhaSX
        public ActionResult Index()
        {
            return View(NSXBUS.DanhSach());
        }

        // GET: Admin/NhaSX/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NhaSX/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhaSX/Create
        [HttpPost]
        public ActionResult Create(NhaSX n) 
        {
           
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    try {

                    var nsx = new NhaSanXuat();
                    nsx.idNSX = n.idNSX;
                    nsx.MoTa = n.MoTa;
                    nsx.TenNSX = n.TenNSX;
                    nsx.SDT = n.SDT;
                    nsx.DiaChi = n.DiaChi;

                    NSXBUS.SaveNSX(nsx);
                        return RedirectToAction("Index");
                    }
                    catch {
                        return View();
                    }
                    

                }
                else
                {
                    return View();
                }
           
        }

        // GET: Admin/NhaSX/Edit/5
        public ActionResult Edit(int id)
        {
            var n = NSXBUS.LoadNSX(id);
            var nsx = new NhaSX();
            nsx.idNSX = n.idNSX;
            nsx.MoTa = n.MoTa;
            nsx.TenNSX = n.TenNSX;
            nsx.SDT = n.SDT;
            nsx.DiaChi = n.DiaChi;
            return View(nsx);
        }

        // POST: Admin/NhaSX/Edit/5
        [HttpPost]
        public ActionResult Edit(NhaSX n)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var nsx = new NhaSanXuat();
                    nsx.idNSX = n.idNSX;
                    nsx.MoTa = n.MoTa;
                    nsx.TenNSX = n.TenNSX;
                    nsx.SDT = n.SDT;
                    nsx.DiaChi = n.DiaChi;

                    NSXBUS.EditNSX(nsx);
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

        // GET: Admin/NhaSX/Delete/5
        public ActionResult Delete(int id)
        {

            NSXBUS.DeleteNSX(id);
            return RedirectToAction("Index");
        }

        // POST: Admin/NhaSX/Delete/5
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
