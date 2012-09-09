using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSPA.Controllers
{
    public class HomeController : Controller
    {
        protected IDummyDependency DummyRepo;
        public HomeController(IDummyDependency dummyRepo)
        {
            DummyRepo = dummyRepo;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Message = DummyRepo.DummyMethod();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
