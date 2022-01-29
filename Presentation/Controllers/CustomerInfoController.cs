using Presentation.Service2_Reference;
using Presentation.Service3_Reference;
using Presentation.Service5_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class CustomerInfoController : Controller
    {
        // GET: CustomerVehicles
        public ActionResult MyVehicles()
        {
            Service3Client client = new Service3Client();
            //VehicleList list = client.VehicleCustomerList(int id);
            //return View(list);
            return View();
        }

        public ActionResult MServices()
        {
            Service5Client client = new Service5Client();
            //ServiceList list = client.ServiceCustomerList(int id);
            //return View(list);
            return View();
        }

    }
}