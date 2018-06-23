using SICI.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SICI.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        public ActionResult Index()
        {
            return View();
        }

        public void generarReporteUsuariosSistema()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();
            


            grid.DataSource = (from m in db2.Tbl_InformacionBasicaUsuario select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteUsuariosSistema.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }

        public void generarReporteTranferencias()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();



            grid.DataSource = (from m in db2.Tbl_Transferencias select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteTransferencias.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }

        public void generarReporteEspecialidades()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();



            grid.DataSource = (from m in db2.Tbl_Especializacion select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteEspecialidades.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }


        public void generarReporteSedes()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();



            grid.DataSource = (from m in db2.Tbl_Sedes select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteSedes.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }


        public void generarReporteAsistencia()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();



            grid.DataSource = (from m in db2.Tbl_AsistenciaTransferencias select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteAsistencia.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }


        public void generarReporteProcedimientoAlmacenado()
        {
            siciEntities2 db2 = new siciEntities2();
            var grid = new GridView();

            db2.PROC_GENERARREPORTE();

            grid.DataSource = (from m in db2.Tbl_reporteInformacionPorUsuario select m).ToList();
            grid.DataBind();
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment; filename=ReporteAsistencia.xls");
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htmlTextwrite = new HtmlTextWriter(sw);
            grid.RenderControl(htmlTextwrite);
            Response.Write(sw.ToString());
            Response.End();
        }


    }
}