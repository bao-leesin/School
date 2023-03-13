using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace School.Areas.Admin.Controllers
{
    public class StudentController : BaseController
    {
        // GET: Student
        private StudentDao dao = new StudentDao();
        public ActionResult Index(string searchString, int page = 1, int pageSize = 3)
        {
            //var dao = new StudentDao();
            var students = dao.listStudentsPaging(searchString,page,pageSize);
            ViewBag.CurrentFilter = searchString;
            return View(students);
        }

        public ActionResult getAll() {
            //var dao = new StudentDao();
            var students = dao.getAll();
            return View(students);
        }

        [HttpGet]
        public JsonResult Details(string id) { 

            var student = new StudentDao().getDetail(id);
            return Json(new
            {
                id=student.id,
                name= student.name,
                age= student.age
            });
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
                //var dao = new StudentDao();
                string id = dao.Insert(student);
               return RedirectToAction("Index");
            
        }
   
        public ActionResult Edit(string id)
        {
            var student = new StudentDao().getDetail(id);
            return View(student);
        }

        //Dùng Put không được
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //var dao = new StudentDao();
            bool id = dao.Update(student);
            return RedirectToAction($"Details/{student.id}");
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            new StudentDao().Delete(id);  
            return View();
        }

        
    }
}