using SICI.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SICI.Controllers
{
    public class NotificacionController : Controller
    {
        // GET: Notificacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult enviarNotificaciones()
        {
            try
            {

            
            siciEntities2 db = new siciEntities2();

            String sql = "SELECT CAST(TI.Cedula AS VARCHAR)Cedula, Email, NombreTransferencia, CAST(TT.IdTransferencia AS VARCHAR)IdTransferencia " +
                          " FROM Tbl_Transferencias TT " +
                          " LEFT JOIN Tbl_EspecializacionesUsuario Te " +
                          " ON TT.IdEspecializacion = Te.IdEspecializacion " +
                          " LEFT JOIN Tbl_InformacionBasicaUsuario TI " +
                          " ON TI.id = TE.id " +
                          " LEFT JOIN Tbl_HistoricoNotificaciones TH " +
                          " ON TT.IdTransferencia = TH.IdTransferencia " +
                          " WHERE TH.IdTransferencia IS NULL AND TI.Cedula IS NOT NULL ";

            String sqlInsert = "INSERT INTO Tbl_HistoricoNotificaciones " +
                                " SELECT CAST(TT.IdTransferencia AS VARCHAR)IdTransferencia " +
                                "   FROM Tbl_Transferencias TT " +
                                "   LEFT JOIN Tbl_EspecializacionesUsuario Te " +
                                "   ON TT.IdEspecializacion = Te.IdEspecializacion " +
                                "   LEFT JOIN Tbl_InformacionBasicaUsuario TI " +
                                " ON TI.id = TE.id " +
                                "   LEFT JOIN Tbl_HistoricoNotificaciones TH " +
                                "   ON TT.IdTransferencia = TH.IdTransferencia " +
                                "   WHERE TH.IdTransferencia IS NULL AND TI.Cedula IS NOT NULL" +
                                  " GROUP BY TT.IdTransferencia; ";
            

            IEnumerable<Notificacion> data = db.Database.SqlQuery<Notificacion>(sql);
            var secuencia = data.GetEnumerator();

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ccamilo2303@gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ccamilo2303@gmail.com", "1024579400");
            SmtpServer.EnableSsl = true;
                
                for (int a = 0; a < data.Count(); a++)
            {
                Notificacion x = data.ElementAt(a);
                mail.To.Add(x.Email);
                mail.Subject = "Nueva oferta disponible!";
                mail.Body = "Ha recibido esta notificación porque se publicó la siguiente oferta de su interes: "+x.NombreTransferencia+ ", la puede consultar en este enlace: http://localhost:57005/Tbl_Inscripciones/CreateEspecial?cedula=" + x.Cedula+"&idTransferencia=" + x.IdTransferencia;

                SmtpServer.Send(mail);

            }

            db.Database.ExecuteSqlCommand(sqlInsert);
                ViewBag.resultado = "Proceso realizado con éxito";
            }
            catch (Exception e){
                ViewBag.resultado = "Ocurrió un error mientras se realiza en elvío";
            }
            return View();
        }

    }
}