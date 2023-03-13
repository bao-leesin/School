using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Areas.Admin.Controllers
{
    public class ClassController : Controller
    {
        // GET: Admin/Class
        public ActionResult Index()
        {
            return View();
        }
    }
}