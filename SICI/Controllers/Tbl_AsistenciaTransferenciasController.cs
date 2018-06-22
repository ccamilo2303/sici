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
    public class Tbl_AsistenciaTransferenciasController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_AsistenciaTransferencias
        public ActionResult Index()
        {
            var tbl_AsistenciaTransferencias = db.Tbl_AsistenciaTransferencias.Include(t => t.Tbl_InformacionBasicaUsuario).Include(t => t.Tbl_Sedes).Include(t => t.Tbl_Transferencias);
            return View(tbl_AsistenciaTransferencias.ToList());
        }

        // GET: Tbl_AsistenciaTransferencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias = db.Tbl_AsistenciaTransferencias.Find(id);
            if (tbl_AsistenciaTransferencias == null)
            {
                return HttpNotFound();
            }
            return View(tbl_AsistenciaTransferencias);
        }

        // GET: Tbl_AsistenciaTransferencias/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto");
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede");
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia");
            return View();
        }

        // POST: Tbl_AsistenciaTransferencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAsistenciaTransferencia,IdTransferencia,Id,IdSede,FechaRegistro")] Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_AsistenciaTransferencias.Add(tbl_AsistenciaTransferencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_AsistenciaTransferencias.Id);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_AsistenciaTransferencias.IdSede);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_AsistenciaTransferencias.IdTransferencia);
            return View(tbl_AsistenciaTransferencias);
        }

        // GET: Tbl_AsistenciaTransferencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias = db.Tbl_AsistenciaTransferencias.Find(id);
            if (tbl_AsistenciaTransferencias == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_AsistenciaTransferencias.Id);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_AsistenciaTransferencias.IdSede);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_AsistenciaTransferencias.IdTransferencia);
            return View(tbl_AsistenciaTransferencias);
        }

        // POST: Tbl_AsistenciaTransferencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAsistenciaTransferencia,IdTransferencia,Id,IdSede,FechaRegistro")] Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_AsistenciaTransferencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_AsistenciaTransferencias.Id);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_AsistenciaTransferencias.IdSede);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_AsistenciaTransferencias.IdTransferencia);
            return View(tbl_AsistenciaTransferencias);
        }

        // GET: Tbl_AsistenciaTransferencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias = db.Tbl_AsistenciaTransferencias.Find(id);
            if (tbl_AsistenciaTransferencias == null)
            {
                return HttpNotFound();
            }
            return View(tbl_AsistenciaTransferencias);
        }

        // POST: Tbl_AsistenciaTransferencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_AsistenciaTransferencias tbl_AsistenciaTransferencias = db.Tbl_AsistenciaTransferencias.Find(id);
            db.Tbl_AsistenciaTransferencias.Remove(tbl_AsistenciaTransferencias);
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
