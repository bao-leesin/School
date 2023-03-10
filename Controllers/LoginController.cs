using Model.EF;
using Model.DAO;
using School.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;

namespace School.Areas.User.Controllers
{
    public class LoginController : Controller
    {
        // GET: User/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login() { return View(); }

        [HttpPost]
        public ActionResult Login(LoginModel data) {
            var dao = new StudentDao();
            var result = dao.Login(data.Username,data.Password);
            if (result)
            {
                var student = dao.getDetail(data.Username);
                var studentSession = new StudentLogin(student.id,student.name);
                Session.Add(CommonContants.STUDENT_SESSION,student);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("", "Failed");
            }
            return View();


        }
    }
}