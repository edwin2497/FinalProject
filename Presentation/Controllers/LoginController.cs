using Presentation.Service1_Reference;
using Presentation.Service2_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Presentation.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            ViewBag.Admin = 0;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int cardId, string password)
        {

            bool loginAdmin;
            bool loginCustomer;
            bool admin;

            Service1Client service1 = new Service1Client();
            Service2Client service2 = new Service2Client();

            loginAdmin = service1.LoginAdministrative(cardId, password);
            admin = service1.IsAdministrative(cardId);
            loginCustomer = service2.LoginCustomer(cardId, password);


            if (loginAdmin == true && admin == true)
            {

                AdministrativeDTO administrative;
                administrative = service1.GetAdministrativeCardId(cardId);
                ViewBag.UserName = administrative.Name;
                ViewBag.UserLastName= administrative.FirstLastName;

                ViewBag.Admin = 1;

                //HomeController home = new HomeController();
                //home.HomeAdministrative(administrative);
                //return RedirectToAction("HomeAdministrative", "Home",new {cardId});

                return View();


            }
            else if (loginCustomer == true)
            {

                CustomerDTO customer;
                customer = service2.GetCardIdCustomer(cardId);
                ViewBag.UserName = customer.Name;
                ViewBag.UserLastName = customer.FirstLastName;

                //HomeController home = new HomeController();
                //home.HomeCustomer(customer);
                //return RedirectToAction("HomeAdministrative", "Home");

                ViewBag.Admin = 2;
                return View();

            }
            else
            {
                ViewBag.Admin = 0;
                return RedirectToAction("Login");
            }

        }
    }
}