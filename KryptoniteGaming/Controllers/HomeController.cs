using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KryptoniteGaming.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
            String str =  User.Identity.Name;
            return View();
        }

        [Authorize]
        public ActionResult Game()
        {
            return View();
        }
    }
}