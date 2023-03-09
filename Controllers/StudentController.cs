using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getAll() {
        
            return View();
        }
        public ActionResult Details(string id) { 
            var dao = new StudentDao();
            var student = dao.getDetail(id);
            return View(student);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
                var dao = new StudentDao();
                string id = dao.Insert(student);
               return RedirectToAction($"Details/{id}");
            
        }
    }
}