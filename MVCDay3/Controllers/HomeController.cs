using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id, string pass, string token)
        {
            return "Hello!!" + DateTime.Now.ToString() + " Id =" + id;
        }

        public string Index2(string id)
        {
            return "This is Index 2 Hello!!" + DateTime.Now.ToString();
        }

        public ActionResult Index1()
        {
            ViewBag.FirstName = "Diksha";
            return View();
        }

        public ActionResult Index3(string id)
        {
            TempData["FirstName"] = 23;
            return View();
        }
    }
}