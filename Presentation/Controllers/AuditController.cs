using Presentation.Service7_Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class AuditController : Controller
    {
        // GET: Audit
        public ActionResult Index()
        {
            Service7Client client = new Service7Client();
            AuditList list = client.GetAllAudit();
            return View(list);
        }
    }
}