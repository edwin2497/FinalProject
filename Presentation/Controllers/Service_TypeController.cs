using Presentation.Service6_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class Service_TypeController : Controller
    {
        // GET: Service_Type
        public ActionResult Index()
        {
            Service6Client client = new Service6Client();
            Service_TypeList list = client.GetAllService_Type();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Service_TypeDTO service_Type)
        {
            Service6Client client = new Service6Client();
            client.InsertService_Type(service_Type);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service6Client client = new Service6Client();
            Service_TypeDTO service_Type = client.GetService_TypeId(id);
            return View(service_Type);
        }

        [HttpPost]
        public ActionResult Delete(Service_TypeDTO service_Type)
        {
            Service6Client client = new Service6Client();
            client.DeleteService_Type(service_Type.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service6Client client = new Service6Client();
            Service_TypeDTO service_Type = client.GetService_TypeId(id);
            return View(service_Type);
        }


        [HttpPost]
        public ActionResult Modify(Service_TypeDTO service_Type)
        {
            Service6Client client = new Service6Client();
            client.ModifyService_Type(service_Type);
            return View();
        }
    }
}