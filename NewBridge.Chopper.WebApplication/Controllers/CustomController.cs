using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewBridge.Chopper.WebApplication.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            ViewBag.Controller = "Custom";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Custom";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}