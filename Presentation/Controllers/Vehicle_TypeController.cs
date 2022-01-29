using Presentation.Service4_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class Vehicle_TypeController : Controller
    {
        // GET: Vehicle_Type
        public ActionResult Index()
        {
            Service4Client client = new Service4Client();
            Vehicle_TypeList list = client.GetAllVehicle_Type();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Vehicle_TypeDTO vehicle_Type)
        {
            Service4Client client = new Service4Client();
            client.InsertVehicle_Type(vehicle_Type);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service4Client client = new Service4Client();
            Vehicle_TypeDTO vehicle_Type = client.GetVehicle_TypeId(id);
            return View(vehicle_Type);
        }

        [HttpPost]
        public ActionResult Delete(Vehicle_TypeDTO vehicle_Type)
        {
            Service4Client client = new Service4Client();
            client.DeleteVehicle_Type(vehicle_Type.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service4Client client = new Service4Client();
            Vehicle_TypeDTO vehicle_Type = client.GetVehicle_TypeId(id);
            return View(vehicle_Type);
        }


        [HttpPost]
        public ActionResult Modify(Vehicle_TypeDTO vehicle_Type)
        {
            Service4Client client = new Service4Client();
            client.ModifyVehicle_Type(vehicle_Type);
            return View();
        }
    }
}