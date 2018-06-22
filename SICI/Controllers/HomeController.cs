using SICI.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

        public ActionResult DashBoard()
        {
            siciEntities2 db = new siciEntities2();
            var x = from transferencias in db.Tbl_Transferencias where transferencias.EstadoTransferencia == 1 select transferencias;
            ViewBag.conteoTrasferencias = x.ToList().ToArray().Length;

            var s = from sedes in db.Tbl_Sedes select sedes;
            ViewBag.conteoSedes = s.ToList().ToArray().Length;

            return View(db.Tbl_Anuncios.ToList().OrderBy(t => t.FechaCreacionAnuncio));
        }
    }
}