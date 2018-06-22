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
    public class Tbl_EstadosController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Estados
        public ActionResult Index()
        {
            return View(db.Tbl_Estados.ToList());
        }

        // GET: Tbl_Estados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Estados tbl_Estados = db.Tbl_Estados.Find(id);
            if (tbl_Estados == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estados);
        }

        // GET: Tbl_Estados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Estados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEstado,Descripcion")] Tbl_Estados tbl_Estados)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Estados.Add(tbl_Estados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Estados);
        }

        // GET: Tbl_Estados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Estados tbl_Estados = db.Tbl_Estados.Find(id);
            if (tbl_Estados == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estados);
        }

        // POST: Tbl_Estados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEstado,Descripcion")] Tbl_Estados tbl_Estados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Estados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Estados);
        }

        // GET: Tbl_Estados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Estados tbl_Estados = db.Tbl_Estados.Find(id);
            if (tbl_Estados == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estados);
        }

        // POST: Tbl_Estados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Estados tbl_Estados = db.Tbl_Estados.Find(id);
            db.Tbl_Estados.Remove(tbl_Estados);
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
