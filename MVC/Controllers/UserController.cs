using System.Collections.Generic;
using System.Web.Mvc;
using System.Collections;
using System.Linq;
using MVC.Models;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            
                List<UserTableViewModels> lst = null;
                using (MVCEntities4 db = new MVCEntities4())
                {
                   lst = (from d in db.login
                           where d.idState == 1
                           orderby d.usuario 
                           select new UserTableViewModels
                           {
                               Usuario = d.usuario,
                               Id = d.id,
                               Edad = (int)d.edad
                           }).ToList();
                }
                return View(lst);
            
          
           
        }
    }
}