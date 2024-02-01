using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_customerLayout.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            ViewBag.msg = "Customer Home Page";
            return View();
        }
        public ActionResult NameList() {
            List<string> list = new List<string>() {
                "Sravani",
                "Mani",
                "Jagadeesh",
                "Ramki"
            };
            ViewBag.nameList = list;
            return View();
        }
    }
}