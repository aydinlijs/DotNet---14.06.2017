using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13._06._2017.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            serviceDrop();
            return View();
        }

        public ActionResult Single(string name,int? page)
        {
            serviceDrop();

            ViewBag.pageTitle = name;
            ViewBag.pageId = page;

            return View();
        }
        public ActionResult Services()
        {
            serviceDrop();
            return View();
        }
        public ActionResult About()
        {
            serviceDrop();
            return View();
        }
        public ActionResult News()
        {
            serviceDrop();
            return View();
        }
        public ActionResult ContactUs()
        {
            serviceDrop();
            return View();
        }
        public void serviceDrop()
        {
            Dictionary<string, string> services = new Dictionary<string, string>();
            services.Add("Xidmetler", "services");
            services.Add("Xeberler", "news");
            services.Add("Haqqimizda", "about");

            ViewBag.Services = services;
        }
    }
}