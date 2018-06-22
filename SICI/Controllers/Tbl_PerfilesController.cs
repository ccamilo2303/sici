using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SICI.Modelo;

namespace SICI.Controllers
{
    public class Tbl_PerfilesController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Perfiles
        public ActionResult Index()
        {
            return View(db.Tbl_Perfiles.ToList());
        }

        // GET: Tbl_Perfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Perfiles tbl_Perfiles = db.Tbl_Perfiles.Find(id);
            if (tbl_Perfiles == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Perfiles);
        }

        // GET: Tbl_Perfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Perfiles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPerfil,Descripcion")] Tbl_Perfiles tbl_Perfiles)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Perfiles.Add(tbl_Perfiles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Perfiles);
        }

        // GET: Tbl_Perfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Perfiles tbl_Perfiles = db.Tbl_Perfiles.Find(id);
            if (tbl_Perfiles == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Perfiles);
        }

        // POST: Tbl_Perfiles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPerfil,Descripcion")] Tbl_Perfiles tbl_Perfiles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Perfiles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Perfiles);
        }

        // GET: Tbl_Perfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Perfiles tbl_Perfiles = db.Tbl_Perfiles.Find(id);
            if (tbl_Perfiles == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Perfiles);
        }

        // POST: Tbl_Perfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Perfiles tbl_Perfiles = db.Tbl_Perfiles.Find(id);
            db.Tbl_Perfiles.Remove(tbl_Perfiles);
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
