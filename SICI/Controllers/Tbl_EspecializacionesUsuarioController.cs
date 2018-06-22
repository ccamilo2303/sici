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
    public class Tbl_EspecializacionesUsuarioController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_EspecializacionesUsuario
        public ActionResult Index()
        {
            var tbl_EspecializacionesUsuario = db.Tbl_EspecializacionesUsuario.Include(t => t.Tbl_Especializacion).Include(t => t.Tbl_InformacionBasicaUsuario);
            return View(tbl_EspecializacionesUsuario.ToList());
        }

        // GET: Tbl_EspecializacionesUsuario/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario = db.Tbl_EspecializacionesUsuario.Find(id);
            if (tbl_EspecializacionesUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_EspecializacionesUsuario);
        }

        // GET: Tbl_EspecializacionesUsuario/Create
        public ActionResult Create()
        {
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion");
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto");
            return View();
        }

        // POST: Tbl_EspecializacionesUsuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdEspecializacion,nidreg")] Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_EspecializacionesUsuario.Add(tbl_EspecializacionesUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_EspecializacionesUsuario.IdEspecializacion);
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_EspecializacionesUsuario.Id);
            return View(tbl_EspecializacionesUsuario);
        }

        // GET: Tbl_EspecializacionesUsuario/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario = db.Tbl_EspecializacionesUsuario.Find(id);
            if (tbl_EspecializacionesUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_EspecializacionesUsuario.IdEspecializacion);
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_EspecializacionesUsuario.Id);
            return View(tbl_EspecializacionesUsuario);
        }

        // POST: Tbl_EspecializacionesUsuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdEspecializacion,nidreg")] Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_EspecializacionesUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEspecializacion = new SelectList(db.Tbl_Especializacion, "IdEspecializacion", "DescripcionEspecializacion", tbl_EspecializacionesUsuario.IdEspecializacion);
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "NombreCompleto", tbl_EspecializacionesUsuario.Id);
            return View(tbl_EspecializacionesUsuario);
        }

        // GET: Tbl_EspecializacionesUsuario/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario = db.Tbl_EspecializacionesUsuario.Find(id);
            if (tbl_EspecializacionesUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_EspecializacionesUsuario);
        }

        // POST: Tbl_EspecializacionesUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tbl_EspecializacionesUsuario tbl_EspecializacionesUsuario = db.Tbl_EspecializacionesUsuario.Find(id);
            db.Tbl_EspecializacionesUsuario.Remove(tbl_EspecializacionesUsuario);
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
