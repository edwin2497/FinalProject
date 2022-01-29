using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Logout(bool logout)
        {

            if (logout == true )
            {
                return RedirectToAction("Login","Login" );

            }
            else 
            {
                return Logout();

            }

        }
    }
}