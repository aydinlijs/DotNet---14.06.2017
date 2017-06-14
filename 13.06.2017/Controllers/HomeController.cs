using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13._06._2017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<string, string> services = new Dictionary<string, string>();
            services.Add("Xidmetler", "services");
            services.Add("Xeberler", "news");
            services.Add("Haqqimizda", "about");

            ViewBag.Services = services;
            return View();
        }
    }
}