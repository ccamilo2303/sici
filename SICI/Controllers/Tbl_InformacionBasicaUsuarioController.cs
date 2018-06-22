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
    public class Tbl_InformacionBasicaUsuarioController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_InformacionBasicaUsuario
        public ActionResult Index()
        {
            var tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Include(t => t.AspNetUsers).Include(t => t.Tbl_Discapacidades).Include(t => t.Tbl_Estados).Include(t => t.Tbl_Perfiles);
            return View(tbl_InformacionBasicaUsuario.ToList());
        }

        // GET: Tbl_InformacionBasicaUsuario/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Find(id);
            if (tbl_InformacionBasicaUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_InformacionBasicaUsuario);
        }

        // GET: Tbl_InformacionBasicaUsuario/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.Discapacidad = new SelectList(db.Tbl_Discapacidades, "IdDiscapacidad", "Descripcion");
            ViewBag.IdEstado = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion");
            ViewBag.IdPerfil = new SelectList(db.Tbl_Perfiles, "IdPerfil", "Descripcion");
            return View();
        }

        // POST: Tbl_InformacionBasicaUsuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cedula,NombreCompleto,Email,Telefono,Discapacidad,IdEstado,IdPerfil")] Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_InformacionBasicaUsuario.Add(tbl_InformacionBasicaUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email", tbl_InformacionBasicaUsuario.Id);
            ViewBag.Discapacidad = new SelectList(db.Tbl_Discapacidades, "IdDiscapacidad", "Descripcion", tbl_InformacionBasicaUsuario.Discapacidad);
            ViewBag.IdEstado = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_InformacionBasicaUsuario.IdEstado);
            ViewBag.IdPerfil = new SelectList(db.Tbl_Perfiles, "IdPerfil", "Descripcion", tbl_InformacionBasicaUsuario.IdPerfil);
            return View(tbl_InformacionBasicaUsuario);
        }

        // GET: Tbl_InformacionBasicaUsuario/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Find(id);
            if (tbl_InformacionBasicaUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email", tbl_InformacionBasicaUsuario.Id);
            ViewBag.Discapacidad = new SelectList(db.Tbl_Discapacidades, "IdDiscapacidad", "Descripcion", tbl_InformacionBasicaUsuario.Discapacidad);
            ViewBag.IdEstado = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_InformacionBasicaUsuario.IdEstado);
            ViewBag.IdPerfil = new SelectList(db.Tbl_Perfiles, "IdPerfil", "Descripcion", tbl_InformacionBasicaUsuario.IdPerfil);
            return View(tbl_InformacionBasicaUsuario);
        }

        public ActionResult EditEspecial()
        {

            string id = Session["id"].ToString();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Find(id);
            if (tbl_InformacionBasicaUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email", tbl_InformacionBasicaUsuario.Id);
            ViewBag.Discapacidad = new SelectList(db.Tbl_Discapacidades, "IdDiscapacidad", "Descripcion", tbl_InformacionBasicaUsuario.Discapacidad);
            ViewBag.IdEstado = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_InformacionBasicaUsuario.IdEstado);
            ViewBag.IdPerfil = new SelectList(db.Tbl_Perfiles, "IdPerfil", "Descripcion", tbl_InformacionBasicaUsuario.IdPerfil);
            return View(tbl_InformacionBasicaUsuario);
        }

        // POST: Tbl_InformacionBasicaUsuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cedula,NombreCompleto,Email,Telefono,Discapacidad,IdEstado,IdPerfil")] Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_InformacionBasicaUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.AspNetUsers, "Id", "Email", tbl_InformacionBasicaUsuario.Id);
            ViewBag.Discapacidad = new SelectList(db.Tbl_Discapacidades, "IdDiscapacidad", "Descripcion", tbl_InformacionBasicaUsuario.Discapacidad);
            ViewBag.IdEstado = new SelectList(db.Tbl_Estados, "IdEstado", "Descripcion", tbl_InformacionBasicaUsuario.IdEstado);
            ViewBag.IdPerfil = new SelectList(db.Tbl_Perfiles, "IdPerfil", "Descripcion", tbl_InformacionBasicaUsuario.IdPerfil);
            return View(tbl_InformacionBasicaUsuario);
        }

        // GET: Tbl_InformacionBasicaUsuario/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Find(id);
            if (tbl_InformacionBasicaUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_InformacionBasicaUsuario);
        }

        // POST: Tbl_InformacionBasicaUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tbl_InformacionBasicaUsuario tbl_InformacionBasicaUsuario = db.Tbl_InformacionBasicaUsuario.Find(id);
            db.Tbl_InformacionBasicaUsuario.Remove(tbl_InformacionBasicaUsuario);
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
