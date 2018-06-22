using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICI.Controllers
{
    public class Notificacion
    {
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string NombreTransferencia { get; set; }
        public string IdTransferencia { get; set; }
    }
}