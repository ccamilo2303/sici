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
    public class Tbl_DiscapacidadesController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_Discapacidades
        public ActionResult Index()
        {
            return View(db.Tbl_Discapacidades.ToList());
        }

        // GET: Tbl_Discapacidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Discapacidades tbl_Discapacidades = db.Tbl_Discapacidades.Find(id);
            if (tbl_Discapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Discapacidades);
        }

        // GET: Tbl_Discapacidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Discapacidades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDiscapacidad,Descripcion")] Tbl_Discapacidades tbl_Discapacidades)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Discapacidades.Add(tbl_Discapacidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Discapacidades);
        }

        // GET: Tbl_Discapacidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Discapacidades tbl_Discapacidades = db.Tbl_Discapacidades.Find(id);
            if (tbl_Discapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Discapacidades);
        }

        // POST: Tbl_Discapacidades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDiscapacidad,Descripcion")] Tbl_Discapacidades tbl_Discapacidades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Discapacidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Discapacidades);
        }

        // GET: Tbl_Discapacidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Discapacidades tbl_Discapacidades = db.Tbl_Discapacidades.Find(id);
            if (tbl_Discapacidades == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Discapacidades);
        }

        // POST: Tbl_Discapacidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Discapacidades tbl_Discapacidades = db.Tbl_Discapacidades.Find(id);
            db.Tbl_Discapacidades.Remove(tbl_Discapacidades);
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
