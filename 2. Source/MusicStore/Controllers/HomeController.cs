using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;
using System.Net;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        MUSIC_STOREEntities Db = new MUSIC_STOREEntities();
        public ActionResult Index()
        {
            List<Album> listAlbum = Db.Albums.ToList();
            List<Genre> listGenre = Db.Genres.ToList();

            ViewBag.listGenre = listGenre;
            return View(listAlbum);
        }

        public ActionResult Album(int? ID)
        {
            if(ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album item = Db.Albums.SingleOrDefault(t => t.ID == ID);

            if(item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
    }
}