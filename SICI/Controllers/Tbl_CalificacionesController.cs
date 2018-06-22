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
    public class Tbl_CalificacionesController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Calificaciones
        public ActionResult Index()
        {
            var tbl_Calificaciones = db.Tbl_Calificaciones.Include(t => t.Tbl_InformacionBasicaUsuario).Include(t => t.Tbl_Transferencias);
            return View(tbl_Calificaciones.ToList());
        }

        // GET: Tbl_Calificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Calificaciones tbl_Calificaciones = db.Tbl_Calificaciones.Find(id);
            if (tbl_Calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Calificaciones);
        }

        // GET: Tbl_Calificaciones/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto");
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia");
            return View();
        }

        // POST: Tbl_Calificaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCalificacion,IdTransferencia,Id,Calificacion")] Tbl_Calificaciones tbl_Calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Calificaciones.Add(tbl_Calificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Calificaciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Calificaciones.IdTransferencia);
            return View(tbl_Calificaciones);
        }

        // GET: Tbl_Calificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Calificaciones tbl_Calificaciones = db.Tbl_Calificaciones.Find(id);
            if (tbl_Calificaciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Calificaciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Calificaciones.IdTransferencia);
            return View(tbl_Calificaciones);
        }

        // POST: Tbl_Calificaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCalificacion,IdTransferencia,Id,Calificacion")] Tbl_Calificaciones tbl_Calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Calificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Calificaciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Calificaciones.IdTransferencia);
            return View(tbl_Calificaciones);
        }

        // GET: Tbl_Calificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Calificaciones tbl_Calificaciones = db.Tbl_Calificaciones.Find(id);
            if (tbl_Calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Calificaciones);
        }

        // POST: Tbl_Calificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Calificaciones tbl_Calificaciones = db.Tbl_Calificaciones.Find(id);
            db.Tbl_Calificaciones.Remove(tbl_Calificaciones);
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
