using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CerrarController : Controller
    {
        // GET: Cerrar
        public ActionResult logogg()
        {
            Session["User"] = null;
            return RedirectToAction("Index","Access");
        }
    }
}