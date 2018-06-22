using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SICI.Modelo;
using System.IO;
using System.Data.SqlClient;

namespace SICI.Controllers
{
    public class Tbl_ArchivosUsuarioController : Controller
    {
        private siciEntities2 db = new siciEntities2();

        // GET: Tbl_ArchivosUsuario
        public ActionResult Index()
        {
            var tbl_ArchivosUsuario = db.Tbl_ArchivosUsuario.Include(t => t.Tbl_InformacionBasicaUsuario);
            return View(tbl_ArchivosUsuario.ToList());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }
            
            
            using (SqlConnection con = new SqlConnection("data source=sql5019.site4now.net;initial catalog=DB_A3B5B5_sici;integrated security=False;user id=DB_A3B5B5_sici_admin;password=1qazXSW2"))
            {
                string query = "INSERT INTO Tbl_ArchivosUsuario VALUES (@id, @Name, @ContentType, @Data)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con; 
                    cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
                    cmd.Parameters.AddWithValue("@Name", Path.GetFileName(postedFile.FileName));
                    cmd.Parameters.AddWithValue("@ContentType", postedFile.ContentType);
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            return View(GetFiles());
        }


        [HttpPost]
        public FileResult DownloadFile(int? fileId)
        {
            byte[] bytes;
            string fileName, contentType;

            using (SqlConnection con = new SqlConnection("data source=sql5019.site4now.net;initial catalog=DB_A3B5B5_sici;integrated security=False;user id=DB_A3B5B5_sici_admin;password=1qazXSW2"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT Name, Data, ContentType FROM Tbl_ArchivosUsuario WHERE idRegistro=@idRegistro";
                    cmd.Parameters.AddWithValue("@idRegistro", fileId);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Data"];
                        contentType = sdr["ContentType"].ToString();
                        fileName = sdr["Name"].ToString();
                    }
                    con.Close();
                }
            }

            return File(bytes, contentType, fileName);
        }


        private static List<Tbl_ArchivosUsuario> GetFiles()
        {
            List<Tbl_ArchivosUsuario> files = new List<Tbl_ArchivosUsuario>();
            using (SqlConnection con = new SqlConnection("data source=sql5019.site4now.net;initial catalog=DB_A3B5B5_sici;integrated security=False;user id=DB_A3B5B5_sici_admin;password=1qazXSW2"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT idRegistro, Name FROM Tbl_ArchivosUsuario"))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            files.Add(new Tbl_ArchivosUsuario
                            {
                                idRegistro = Convert.ToInt32(sdr["idRegistro"]),
                                Name = sdr["Name"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return files;
        }


        // GET: Tbl_ArchivosUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_ArchivosUsuario tbl_ArchivosUsuario = db.Tbl_ArchivosUsuario.Find(id);
            if (tbl_ArchivosUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_ArchivosUsuario);
        }

        // GET: Tbl_ArchivosUsuario/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "Cedula");
            return View();
        }

        // POST: Tbl_ArchivosUsuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ContentType,Data,idRegistro")] Tbl_ArchivosUsuario tbl_ArchivosUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_ArchivosUsuario.Add(tbl_ArchivosUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "Cedula", tbl_ArchivosUsuario.Id);
            return View(tbl_ArchivosUsuario);
        }

        // GET: Tbl_ArchivosUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_ArchivosUsuario tbl_ArchivosUsuario = db.Tbl_ArchivosUsuario.Find(id);
            if (tbl_ArchivosUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "Cedula", tbl_ArchivosUsuario.Id);
            return View(tbl_ArchivosUsuario);
        }

        // POST: Tbl_ArchivosUsuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ContentType,Data,idRegistro")] Tbl_ArchivosUsuario tbl_ArchivosUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_ArchivosUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Tbl_InformacionBasicaUsuario, "Id", "Cedula", tbl_ArchivosUsuario.Id);
            return View(tbl_ArchivosUsuario);
        }

        // GET: Tbl_ArchivosUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_ArchivosUsuario tbl_ArchivosUsuario = db.Tbl_ArchivosUsuario.Find(id);
            if (tbl_ArchivosUsuario == null)
            {
                return HttpNotFound();
            }
            return View(tbl_ArchivosUsuario);
        }

        // POST: Tbl_ArchivosUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_ArchivosUsuario tbl_ArchivosUsuario = db.Tbl_ArchivosUsuario.Find(id);
            db.Tbl_ArchivosUsuario.Remove(tbl_ArchivosUsuario);
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
