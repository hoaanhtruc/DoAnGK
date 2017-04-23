using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnlineConnection;

namespace WebOnline.Controllers
{
    public class QuanLySPController : Controller
    {
        // GET: QuanLySP
        [HttpGet]
        public ActionResult Index()
        {
            var db = new WebOnlineConnectionDB();
            var lstSanPham = db.Query<SanPham>("SELECT * FROM SanPham");
            return View(lstSanPham);
        }

        // GET: QuanLySP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLySP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLySP/Create
        [HttpPost] //khi nhap sp moi xong. bam them. thi koa cai httppost thi nó mới pk là gửi vô controller nào.
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                var db = new WebOnlineConnectionDB();
                db.Insert(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLySP/Edit/5
        public ActionResult Edit(int id)
        {
            var db = new WebOnlineConnectionDB();
            SanPham sp = db.SingleOrDefault<SanPham>("Select * from SanPham where ID = @0", id);
            return View(sp);
        }

        // POST: QuanLySP/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SanPham sp)
        {
            try
            {
                // TODO: Add update logic here
                var db = new WebOnlineConnectionDB();
                db.Update(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLySP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanLySP/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SanPham sp)
        {
            try
            {
                // TODO: Add delete logic here
                var db = new WebOnlineConnectionDB();
                db.Delete<SanPham>("WHERE ID = @0", id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
