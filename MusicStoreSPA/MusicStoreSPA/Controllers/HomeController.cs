using DataAccess;
using MusicStoreSPA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSPA.Controllers
{
    public class HomeController : Controller
    {
        protected IMusicLibraryService MusicLibrary;
        public HomeController(IMusicLibraryService musicLibrary)
        {
            MusicLibrary = musicLibrary;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var song = MusicLibrary.GetSong(1);
            ViewBag.Message = song.Title;

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
