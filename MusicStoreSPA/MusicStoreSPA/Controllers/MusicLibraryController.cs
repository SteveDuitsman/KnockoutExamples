using MusicStoreSPA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSPA.Controllers
{
    public class MusicLibraryController : Controller
    {
        private IMusicLibraryService Service;

        public MusicLibraryController(IMusicLibraryService service)
        {
            Service = service;
        }

        //
        // GET: /MusicLibrary/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetArtists()
        {
            var artists = Service.GetArtists();
            return new JsonResult { Data = artists, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
