using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;
namespace MusicStore.Controllers
{
    public class AdminController : Controller
    {
        MUSIC_STOREEntities Db = new MUSIC_STOREEntities();
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }


        ///////////
        // Album //
        ///////////
        public ActionResult AddAlbum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAlbum(Album album)
        {
            Album item = new Album();
            item.BuyCounter = 0;
            item.Genre = album.Genre;
            item.IDGenre = album.IDGenre;
            item.IDPublisher = album.IDPublisher;
            item.Information = album.Information;
            item.Language = album.Language;
            item.LinkImage = album.LinkImage;
            item.Name = album.Name;
            item.Price = album.Price;
            item.ReleaseDate = album.ReleaseDate;

            Db.Albums.Add(item);
            Db.SaveChanges();
           return View();
        }

        public ActionResult EditAlbum(int IDAlbum)
        {
            Album album = Db.Albums.SingleOrDefault(x => x.ID == IDAlbum);
            return View(album);
        }

        [HttpPost]
        public ActionResult EditAlbum(Album album)
        {
            Album item = new Album();
            item.BuyCounter = 0;
            item.Genre = album.Genre;
            item.IDGenre = album.IDGenre;
            item.IDPublisher = album.IDPublisher;
            item.Information = album.Information;
            item.Language = album.Language;
            item.LinkImage = album.LinkImage;
            item.Name = album.Name;
            item.Price = album.Price;
            item.ReleaseDate = album.ReleaseDate;

            Db.Albums.Add(item);
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult DeleteAlbum(int Album)
        {
            return View();
        }

        //////////
        // Song //
        //////////


        ////////////
        // Singer //
        ////////////
        

        ///////////
        // Genre //
        ///////////

        //////////////
        // Composer //
        //////////////

        ///////////////
        // Publisher //
        ///////////////


	}
}