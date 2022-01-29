using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Service_TypeOperations
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<Service_Type> GetAll()
        {
            return uow.Service_Type.GetAll();
        }

        public Service_Type GetId(int id)
        {
            return uow.Service_Type.GetId(id);
        }

        public void Modify(Service_Type s)
        {
            Service_Type service_Type = uow.Service_Type.GetId(s.Id);
            if (service_Type != null)
            {
                uow.DbContext.Entry(service_Type).CurrentValues.SetValues(s);
                uow.Service_Type.Modify(service_Type);
            }
        }

        public void Delete(int id)
        {
            Service_Type service_Type = uow.Service_Type.GetId(id);
            if (service_Type != null)
            {
                uow.Service_Type.Delete(service_Type);
            }
        }

        public void Insert(Service_Type s)
        {
            try
            {
                int id = s.Id;
                string name = s.Name;
                string description = s.Description;


                Audit audit = new Audit(id, name, description);

                uow.Audit.Insert(audit);
                uow.Service_Type.Insert(s);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error Service_TyeOperations.Insert: {exp.Message}");
            }
        }
    }
}
