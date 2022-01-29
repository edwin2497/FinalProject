using Presentation.Service1_Reference;
using Presentation.Service2_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Presentation.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomeAdministrative(AdministrativeDTO administrativeInfo)
        {
            AdministrativeDTO administrative = administrativeInfo;
            ViewBag.UserName = administrative.Name;
            ViewBag.UserLastName = administrative.FirstLastName;
            return View();
        }

        public ActionResult HomeCustomer(CustomerDTO customerInfo)
        {
            CustomerDTO customer = customerInfo;
            ViewBag.UserName = customer.Name;
            ViewBag.UserLastName = customer.FirstLastName;
            return View();
        }

    }

}
