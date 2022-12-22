using MVC.Models;
using MVC.Models.TableViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserTableViewModels> lst = null;
            using (mvcEntities db = new mvcEntities())
            {
                lst = (from d in db.usuario
                       where d.id_cat == 1
                       orderby d.user_usu
                       select new UserTableViewModels
                       {
                           Usuario = d.user_usu,
                           Email = d.email,
                           Edad = (int)d.edad
                       }).ToList();
            }
            return View(lst);
        }
    }
}