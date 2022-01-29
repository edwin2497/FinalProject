using Presentation.Service5_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            Service5Client client = new Service5Client();
            ServiceList list = client.GetAllService();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(ServiceDTO service)
        {
            Service5Client client = new Service5Client();
            client.InsertService(service);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service5Client client = new Service5Client();
            ServiceDTO service = client.GetServiceId(id);
            return View(service);
        }

        [HttpPost]
        public ActionResult Delete(ServiceDTO service)
        {
            Service5Client client = new Service5Client();
            client.DeleteService(service.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service5Client client = new Service5Client();
            ServiceDTO service = client.GetServiceId(id);
            return View(service);
        }


        [HttpPost]
        public ActionResult Modify(ServiceDTO service)
        {
            Service5Client client = new Service5Client();
            client.ModifyService(service);
            return View();
        }
    }
}