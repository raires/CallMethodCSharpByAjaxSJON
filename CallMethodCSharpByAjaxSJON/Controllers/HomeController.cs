using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        [WebMethod]
        [AllowAnonymous]
        public ActionResult AjaxMethod(string contentParam)
        {
            //do anything
            return Json("You sent: " + contentParam, JsonRequestBehavior.AllowGet);
        }

    }
}
