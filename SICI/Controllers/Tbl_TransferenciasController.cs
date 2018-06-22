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
    public class Tbl_TransferenciasController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Transferencias
        public ActionResult Index()
        {
            var tbl_Transferencias = db.Tbl_Transferencias.Include(t => t.Tbl_Especializacion).Include(t => t.Tbl_Estados).Include(t => t.Tbl_Sedes);
            return View(tbl_Transferencias.ToList());
        }

        // GET: Tbl_Transferencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Transferencias tbl_Transferencias = db.Tbl_Transferencias.Find(id);
            if (tbl_Transferencias == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Transferencias);
        }

        // GET: Tbl_Transferencias/Create
        public ActionResult Create()
        {
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion");
            ViewBag.EstadoTransferencia = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion");
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede");
            return View();
        }

        // POST: Tbl_Transferencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NombreTransferencia,IdTransferencia,Descripcion,CuposIniciales,CuposActuales,FechaInicio,FechaFin,FechaCreacion,EstadoTransferencia,IdEspecializacion,IdSede")] Tbl_Transferencias tbl_Transferencias)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Transferencias.Add(tbl_Transferencias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_Transferencias.IdEspecializacion);
            ViewBag.EstadoTransferencia = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_Transferencias.EstadoTransferencia);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_Transferencias.IdSede);
            return View(tbl_Transferencias);
        }

        // GET: Tbl_Transferencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Transferencias tbl_Transferencias = db.Tbl_Transferencias.Find(id);
            if (tbl_Transferencias == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_Transferencias.IdEspecializacion);
            ViewBag.EstadoTransferencia = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_Transferencias.EstadoTransferencia);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_Transferencias.IdSede);
            return View(tbl_Transferencias);
        }

        // POST: Tbl_Transferencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NombreTransferencia,IdTransferencia,Descripcion,CuposIniciales,CuposActuales,FechaInicio,FechaFin,FechaCreacion,EstadoTransferencia,IdEspecializacion,IdSede")] Tbl_Transferencias tbl_Transferencias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Transferencias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_Transferencias.IdEspecializacion);
            ViewBag.EstadoTransferencia = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_Transferencias.EstadoTransferencia);
            ViewBag.IdSede = new SelectList(db.Tbl_Sedes, "IdSede", "NombreSede", tbl_Transferencias.IdSede);
            return View(tbl_Transferencias);
        }

        // GET: Tbl_Transferencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Transferencias tbl_Transferencias = db.Tbl_Transferencias.Find(id);
            if (tbl_Transferencias == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Transferencias);
        }

        // POST: Tbl_Transferencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Transferencias tbl_Transferencias = db.Tbl_Transferencias.Find(id);
            db.Tbl_Transferencias.Remove(tbl_Transferencias);
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
