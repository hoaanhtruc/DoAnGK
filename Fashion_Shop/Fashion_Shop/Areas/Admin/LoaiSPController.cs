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
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/LoaiSP/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSP/Delete/5
        public ActionResult Delete(int id)
        {
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
