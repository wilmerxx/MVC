using MVC.Models;
using System;
using System.Linq;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(
            string user, string pass)
        {
            try
            {
                using (mvcEntities db = new mvcEntities())
                {
                    var lst = from d in db.usuario
                              where d.user_usu == user && d.password_usu == pass && d.id_cat == 1
                              select d;
                    if (lst.Count() > 0)
                    {
                        usuario oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    return Content("0");
                }

            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);
            }

        }

    }
}