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
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var sess = (StudentLogin) Session[CommonContants.STUDENT_SESSION];
            if (sess != null )
            {

            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controler = "Login", action = "Login" 
                        }));
            }
            base.OnActionExecuted(filterContext);

        }

    }
}