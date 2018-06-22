using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICI.Controllers
{
    public class ValidarSesion : Controller
    {

        public Boolean validarSesion()
        {
            if(Session == null || Session["cedula"] == null || Session["cedula"].ToString().Equals(""))
            {
                RedirectToAction("Index", "Home");
                return false;
            }
            return true;
        }

    }
}