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
    public class Tbl_AnunciosController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Anuncios
        public ActionResult Index()
        {
            return View(db.Tbl_Anuncios.ToList());
        }

        // GET: Tbl_Anuncios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Anuncios tbl_Anuncios = db.Tbl_Anuncios.Find(id);
            if (tbl_Anuncios == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Anuncios);
        }

        // GET: Tbl_Anuncios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Anuncios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAnuncio,AutorAnuncio,TituloAnuncio,DescripcionAnuncio,FechaCreacionAnuncio,Imagen")] Tbl_Anuncios tbl_Anuncios)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Anuncios.Add(tbl_Anuncios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Anuncios);
        }

        // GET: Tbl_Anuncios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Anuncios tbl_Anuncios = db.Tbl_Anuncios.Find(id);
            if (tbl_Anuncios == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Anuncios);
        }

        // POST: Tbl_Anuncios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAnuncio,AutorAnuncio,TituloAnuncio,DescripcionAnuncio,FechaCreacionAnuncio,Imagen")] Tbl_Anuncios tbl_Anuncios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Anuncios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Anuncios);
        }

        // GET: Tbl_Anuncios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Anuncios tbl_Anuncios = db.Tbl_Anuncios.Find(id);
            if (tbl_Anuncios == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Anuncios);
        }

        // POST: Tbl_Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Anuncios tbl_Anuncios = db.Tbl_Anuncios.Find(id);
            db.Tbl_Anuncios.Remove(tbl_Anuncios);
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
