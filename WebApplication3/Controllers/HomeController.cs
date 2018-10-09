using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Output += "<h1 id='test'>TEST :)</h1>";
            return View();
        }
    }
}