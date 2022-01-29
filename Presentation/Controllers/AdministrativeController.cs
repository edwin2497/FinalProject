using Presentation.Service1_Reference;
using Presentation.Service2_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative

        public ActionResult Index()
        {
            Service1Client client = new Service1Client();
            AdministrativeList list = client.GetAllAdministrative();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(AdministrativeDTO administrative)
        {
            Service1Client client = new Service1Client();
            client.InsertAdministrative(administrative);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service1Client client = new Service1Client();
            AdministrativeDTO administrative = client.GetAdministrativeId(id);
            return View(administrative);
        }

        [HttpPost]
        public ActionResult Delete(AdministrativeDTO administrative)
        {
            Service1Client client = new Service1Client();
            client.DeleteAdministrative(administrative.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service1Client client = new Service1Client();
            AdministrativeDTO administrative = client.GetAdministrativeId(id);
            return View(administrative);
        }


        [HttpPost]
        public ActionResult Modify(AdministrativeDTO administrative)
        {
            Service1Client client = new Service1Client();
            client.ModifyAdministrative(administrative);

            return View();
        }
    }
}