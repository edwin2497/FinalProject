using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ServiceOperations
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<Service> GetAll()
        {
            return uow.Service.GetAll();
        }

        public Service GetId(int id)
        {
            return uow.Service.GetId(id);
        }

        public void Modify(Service s)
        {
            Service service = uow.Service.GetId(s.Id);
            if (service != null)
            {
                uow.DbContext.Entry(service).CurrentValues.SetValues(s);
                uow.Service.Modify(service);
            }
        }

        public void Delete(int id)
        {
            Service service = uow.Service.GetId(id);
            if (service != null)
            {
                uow.Service.Delete(service);
            }
        }

        public void Insert(Service s)
        {
            try
            {
                int id = s.Id;
                int cost = s.Cost;
                int serviceType = s.ServiceType;
                int idCustomer = s.IdCustomer;
                int vehicleId = s.VehicleId;

                Audit audit = new Audit(id, cost, serviceType, idCustomer, vehicleId);

                uow.Audit.Insert(audit);

                uow.Service.Insert(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error ServiceOperations.Insert: {exp.Message}");
            }
        }

        public List<Service> ServiceCustomerList(int cardId)
        {
            return uow.Service.ServiceCustomerList(cardId);
        }
    }
}
