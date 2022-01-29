using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AuditOperations
    {
        IUnitOfWork uow = new UnitOfWork();

        public List<Audit> GetAll()
        {
            return uow.Audit.GetAll();
        }

        public Audit GetId(int id)
        {
            return uow.Audit.GetId(id);
        }

        public void Modify(Audit a)
        {
            Audit audit = uow.Audit.GetId(a.Id);
            if (audit != null)
            {
                uow.DbContext.Entry(audit).CurrentValues.SetValues(a);
                uow.Audit.Modify(audit);
            }
        }

        public void Delete(int id)
        {
            Audit audit = uow.Audit.GetId(id);
            if (audit != null)
            {
                uow.Audit.Delete(audit);
            }
        }

        public void Insert(Audit a)
        {
            try
            {
                uow.Audit.Insert(a);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error AuditOperations.Insert: {exp.Message}");
            }
        }
    }
}
