using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnline.Areas.Admin.Code;
using WebOnlineBUS;

namespace WebOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.LoginModel model)
        {
            var result = new AccountModel().Login(model.TenDangNhap, model.MatKhau);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { TenDangNhap = model.TenDangNhap });
                return RedirectToAction("Index","Home");
            }
        else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu sai!");
            }
            return View(model);
        }
    }
}