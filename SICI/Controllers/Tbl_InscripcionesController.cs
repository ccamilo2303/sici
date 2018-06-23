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
    public class Tbl_InscripcionesController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Inscripciones
        public ActionResult Index()
        {
            var tbl_Inscripciones = db.Tbl_Inscripciones.Include(t => t.Tbl_InformacionBasicaUsuario).Include(t => t.Tbl_Transferencias);   
            return View(tbl_Inscripciones.ToList());
        }

        public ActionResult IndexEsp()
        {
            var tbl_Inscripciones = db.Tbl_Inscripciones.Include(t => t.Tbl_InformacionBasicaUsuario).Include(t => t.Tbl_Transferencias);
            return View(tbl_Inscripciones.ToList());
        }

        // GET: Tbl_Inscripciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Inscripciones tbl_Inscripciones = db.Tbl_Inscripciones.Find(id);
            if (tbl_Inscripciones == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Inscripciones);
        }

        // GET: Tbl_Inscripciones/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto");
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia");
            return View();
        }

        // POST: Tbl_Inscripciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdInscripcion,Id,IdTransferencia")] Tbl_Inscripciones tbl_Inscripciones)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Inscripciones.Add(tbl_Inscripciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Inscripciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Inscripciones.IdTransferencia);
            return View(tbl_Inscripciones);
        }


        public ActionResult CreateEspecial(string cedula, int idTransferencia)
        {
            var sql = from m in db.Tbl_InformacionBasicaUsuario where m.Cedula.Equals(cedula) select m;
            var sql2 = from m in db.Tbl_Transferencias where m.IdTransferencia == idTransferencia select m;

            ViewBag.Id = new SelectList(sql, "Id", "NombreCompleto");
            ViewBag.IdTransferencia = new SelectList(sql2, "IdTransferencia", "NombreTransferencia");
            return View();
        }

        public ActionResult mensaje()
        {
            return View();
        }

        // POST: Tbl_Inscripciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEspecial([Bind(Include = "IdInscripcion,Id,IdTransferencia")] Tbl_Inscripciones tbl_Inscripciones)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Inscripciones.Add(tbl_Inscripciones);
                db.SaveChanges();
                return RedirectToAction("mensaje");
            }

            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Inscripciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Inscripciones.IdTransferencia);
            return View(tbl_Inscripciones);
        }

        // GET: Tbl_Inscripciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Inscripciones tbl_Inscripciones = db.Tbl_Inscripciones.Find(id);
            if (tbl_Inscripciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Inscripciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Inscripciones.IdTransferencia);
            return View(tbl_Inscripciones);
        }

        // POST: Tbl_Inscripciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdInscripcion,Id,IdTransferencia")] Tbl_Inscripciones tbl_Inscripciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Inscripciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_Inscripciones.Id);
            ViewBag.IdTransferencia = new SelectList(db.Tbl_Transferencias, "IdTransferencia", "NombreTransferencia", tbl_Inscripciones.IdTransferencia);
            return View(tbl_Inscripciones);
        }

        // GET: Tbl_Inscripciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Inscripciones tbl_Inscripciones = db.Tbl_Inscripciones.Find(id);
            if (tbl_Inscripciones == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Inscripciones);
        }

        // POST: Tbl_Inscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Inscripciones tbl_Inscripciones = db.Tbl_Inscripciones.Find(id);
            db.Tbl_Inscripciones.Remove(tbl_Inscripciones);
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
