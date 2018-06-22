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
    public class Tbl_SedesController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Sedes
        public ActionResult Index()
        {
            return View(db.Tbl_Sedes.ToList());
        }

        // GET: Tbl_Sedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Sedes tbl_Sedes = db.Tbl_Sedes.Find(id);
            if (tbl_Sedes == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Sedes);
        }

        // GET: Tbl_Sedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Sedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSede,NombreSede,Direccion")] Tbl_Sedes tbl_Sedes)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Sedes.Add(tbl_Sedes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Sedes);
        }

        // GET: Tbl_Sedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Sedes tbl_Sedes = db.Tbl_Sedes.Find(id);
            if (tbl_Sedes == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Sedes);
        }

        // POST: Tbl_Sedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSede,NombreSede,Direccion")] Tbl_Sedes tbl_Sedes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Sedes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Sedes);
        }

        // GET: Tbl_Sedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Sedes tbl_Sedes = db.Tbl_Sedes.Find(id);
            if (tbl_Sedes == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Sedes);
        }

        // POST: Tbl_Sedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Sedes tbl_Sedes = db.Tbl_Sedes.Find(id);
            db.Tbl_Sedes.Remove(tbl_Sedes);
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
