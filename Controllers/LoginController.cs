using Microsoft.Ajax.Utilities;
using Model.DAO;
using School.Common;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginStudent() { return View(); }

        [HttpPost]
        public ActionResult LoginStudent(LoginModel data)
        {
            var dao = new StudentDao();
            var result = dao.Login(data.Username, data.Password);
            if (result)
            {
                //var student = dao.getDetail(data.Username);
                var studentSession = new StudentLogin(data.Username, data.Password);
                // Thêm mới hoặc thay thế nếu đã có session cho student
                Session[CommonContants.STUDENT_SESSION] = studentSession;
                return RedirectToAction("Index", "Student");
            }
            else
            {
                ModelState.AddModelError("", "Failed");
            }
            return View();
        }
    }
}