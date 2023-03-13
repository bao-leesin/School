using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace School.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() { return View(); }

        [HttpPost]
        public ActionResult Create(Teacher teacher) {
           
            var dao = new TeacherDao();
            string id = dao.Insert(teacher);
            return RedirectToAction("Index");
        }
    }
}