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
    public class Tbl_EspecializacionController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Especializacion
        public ActionResult Index()
        {
            return View(db.Tbl_Especializacion.ToList());
        }

        // GET: Tbl_Especializacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Especializacion tbl_Especializacion = db.Tbl_Especializacion.Find(id);
            if (tbl_Especializacion == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Especializacion);
        }

        // GET: Tbl_Especializacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Especializacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEspecializacion,DescripcionEspecializacion")] Tbl_Especializacion tbl_Especializacion)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Especializacion.Add(tbl_Especializacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Especializacion);
        }

        // GET: Tbl_Especializacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Especializacion tbl_Especializacion = db.Tbl_Especializacion.Find(id);
            if (tbl_Especializacion == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Especializacion);
        }

        // POST: Tbl_Especializacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEspecializacion,DescripcionEspecializacion")] Tbl_Especializacion tbl_Especializacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Especializacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Especializacion);
        }

        // GET: Tbl_Especializacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Especializacion tbl_Especializacion = db.Tbl_Especializacion.Find(id);
            if (tbl_Especializacion == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Especializacion);
        }

        // POST: Tbl_Especializacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Especializacion tbl_Especializacion = db.Tbl_Especializacion.Find(id);
            db.Tbl_Especializacion.Remove(tbl_Especializacion);
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
