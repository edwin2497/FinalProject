using Presentation.Service3_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            Service3Client client = new Service3Client();
            VehicleList list = client.GetAllVehicle();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(VehicleDTO vehicle)
        {
            Service3Client client = new Service3Client();
            client.InsertVehicle(vehicle);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service3Client client = new Service3Client();
            VehicleDTO vehicle = client.GetVehicleId(id);
            return View(vehicle);
        }

        [HttpPost]
        public ActionResult Delete(VehicleDTO vehicle)
        {
            Service3Client client = new Service3Client();
            client.DeleteVehicle(vehicle.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service3Client client = new Service3Client();
            VehicleDTO vehicle = client.GetVehicleId(id);
            return View(vehicle);
        }


        [HttpPost]
        public ActionResult Modify(VehicleDTO vehicle)
        {
            Service3Client client = new Service3Client();
            client.ModifyVehicle(vehicle);

            return View();
        }
    }
}