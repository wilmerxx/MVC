using System;
using System.Linq;
using System.Web.Mvc;
using MVC.Models;


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
                using (MVCEntities4 db = new MVCEntities4())
                {
                   var lst = from d in db.login
                           where d.usuario == user && d.contrasenia == pass && d.idState == 1 
                           select d;
                    if (lst.Count() > 0)
                    {                           
                        login oUser = lst.First();
                        Session["User"]=oUser;
                        return Content("1");
                    }
                    return Content("0");
                }
                   
            }
            catch(Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);
            }
          
        }

    }
}