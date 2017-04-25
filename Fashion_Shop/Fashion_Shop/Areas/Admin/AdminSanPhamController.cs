using Fashion_Shop.Areas.Admin.Models;
using FashionShopConection;
using MobiShopBus.Models.BUS;
using MobiShopBUS.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace Fashion_Shop.Areas.Admin
{
    public class AdminSanPhamController : Controller
    {
        // GET: Admin/NhaSX
        public ActionResult Index(int? page)
        {
            var LstDS = SPBUS.LoadDSSP();
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(LstDS.ToPagedList(pageNumber, pageSize));
        
        }

        // GET: Admin/NhaSX/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NhaSX/Create
        public ActionResult Create()
        {
            ViewBag.NhaSX = NSXBUS.DanhSach();
            ViewBag.Loai = LoaiSPBUS.LoadDSLoaiSP();
            return View();
        }

        // POST: Admin/NhaSX/Create
        [HttpPost]
        public ActionResult Create(SP n)
        {

            // TODO: Add insert logic here
            ViewBag.NhaSX = NSXBUS.DanhSach();
            ViewBag.Loai = LoaiSPBUS.LoadDSLoaiSP();
            if (ModelState.IsValid)
            {
                try
                {
                    if (HttpContext.Request.Files.Count > 0)
                    {

                        var hpf = HttpContext.Request.Files[0];
                        if (hpf.ContentLength > 0)
                        {
                            string fileName = Guid.NewGuid().ToString();

                            string fullPathWithFileName = "/Assets/Images/products/" + fileName + ".jpg";
                            hpf.SaveAs(Server.MapPath(fullPathWithFileName));
   
                            n.HinhAnh = fullPathWithFileName;
                            var b = new SanPham()
                            {
                                idSP = n.idSP,
                                GiaSP = n.GiaSP,
                                HinhAnh = n.HinhAnh,
                                MaLoai = n.MaLoai,
                                TenSP = n.TenSP,
                                MaNSX = n.MaNSX,
                                MoTa = n.MoTa
                            };
                            SPBUS.ThemSP(b);
                            return RedirectToAction("Index");
                        }
                        else
                            return View();
                    }
                    else
                        return View();

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

        // GET: Admin/NhaSX/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.NhaSX = NSXBUS.DanhSach();
            ViewBag.Loai = LoaiSPBUS.LoadDSLoaiSP();
           //////////
            var b = SPBUS.LoadSanPham(id);
            var a = new SP()
            {
                HinhAnh = b.HinhAnh,
                idSP = b.idSP,
                GiaSP =int.Parse( b.GiaSP.ToString()),
                MaLoai = int.Parse(b.MaLoai.ToString()),
                MaNSX = int.Parse(b.MaNSX.ToString()),
                MoTa = b.MoTa,
                TenSP = b.TenSP
            };
            return View(a);
        }

        // POST: Admin/NhaSX/Edit/5
        [HttpPost]
        public ActionResult Edit(SP a)
        {
            ViewBag.NhaSX = NSXBUS.DanhSach();
            ViewBag.Loai = LoaiSPBUS.LoadDSLoaiSP();
            if (ModelState.IsValid)
            {
                try
                {
                    if (HttpContext.Request.Files.Count > 0)
                    {

                        var hpf = HttpContext.Request.Files[0];
                        if (hpf.ContentLength > 0)
                        {
                            string fileName = Guid.NewGuid().ToString();

                            string fullPathWithFileName = "/Assets/Images/products/" + fileName + ".jpg";
                            hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                            a.HinhAnh = fullPathWithFileName;

                        }

                    }
                    var b = new SanPham()
                    {
                        idSP = a.idSP,
                        GiaSP = a.GiaSP,
                        HinhAnh = a.HinhAnh,
                        MaLoai = a.MaLoai,
                        TenSP = a.TenSP,
                        MaNSX = a.MaNSX,
                        MoTa = a.MoTa
                    };
                    SPBUS.SuaSP(b);
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

            SPBUS.XoaSP(id);
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
