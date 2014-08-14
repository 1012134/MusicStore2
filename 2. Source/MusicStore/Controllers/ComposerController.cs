using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class ComposerController : Controller
    {
        private MUSIC_STOREEntities db = new MUSIC_STOREEntities();

        // GET: /Composer/
        public ActionResult Index()
        {
            return View(db.Composers.ToList());
        }

        // GET: /Composer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Composer composer = db.Composers.Find(id);
            if (composer == null)
            {
                return HttpNotFound();
            }
            return View(composer);
        }

        // GET: /Composer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Composer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,FullName,Information,LinkImage")] Composer composer)
        {
            if (ModelState.IsValid)
            {
                db.Composers.Add(composer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(composer);
        }

        // GET: /Composer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Composer composer = db.Composers.Find(id);
            if (composer == null)
            {
                return HttpNotFound();
            }
            return View(composer);
        }

        // POST: /Composer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,FullName,Information,LinkImage")] Composer composer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(composer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(composer);
        }

        // GET: /Composer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Composer composer = db.Composers.Find(id);
            if (composer == null)
            {
                return HttpNotFound();
            }
            return View(composer);
        }

        // POST: /Composer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Composer composer = db.Composers.Find(id);
            db.Composers.Remove(composer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
