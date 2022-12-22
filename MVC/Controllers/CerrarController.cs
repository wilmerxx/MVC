using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CerrarController : Controller
    {
        // GET: Cerrar
        public ActionResult logoff()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Access");
        }
    }
}