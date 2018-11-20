using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewData["ActiveMenu"] = "Günlük İşlemler";
            return View();
        }
        public ActionResult Menu()
        {
            ViewData["ActiveMenu"] = "Menü";
            return View();
        }
    }
}