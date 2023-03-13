using School.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace School.Controllers
{
    public class BaseController : Controller
    {
        //Có vẻ là middleware kiểm tra session 
        //override lớp OAE để can thiệp khi Action đang diễn ra
        // lớp AEC với thuộc tính Result điều hướng ActionResult sang View trong RVD

        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var sess = (StudentLogin) Session[CommonContants.STUDENT_SESSION];
        //    if (sess == null )
        //    {
        //        filterContext.Result =
        //            new RedirectToRouteResult(
        //            new RouteValueDictionary(
        //            new {
        //                action = "LoginStudent",
        //                Controller = "Login"
        //            }));
        //    }
        //    base.OnActionExecuting(filterContext);
        //}

    }
}