using Presentation.Service2_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Service2Client client = new Service2Client();
            CustomerList list = client.GetAllCustomer();
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(CustomerDTO customer)
        {
            Service2Client client = new Service2Client();
            client.InsertCustomer(customer);

            return View();
        }

        public ActionResult Delete(int id)
        {
            Service2Client client = new Service2Client();
            CustomerDTO customer = client.GetCustomerId(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(CustomerDTO customer)
        {
            Service2Client client = new Service2Client();
            client.DeleteCustomer(customer.Id);
            return View();
        }

        public ActionResult Modify(int id)
        {
            Service2Client client = new Service2Client();
            CustomerDTO customer = client.GetCustomerId(id);
            return View(customer);
        }


        [HttpPost]
        public ActionResult Modify(CustomerDTO customer)
        {
            Service2Client client = new Service2Client();
            client.ModifyCustomer(customer);

            return View();
        }
    }
}