using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Vehicle_TypeOperations
    {
        UnitOfWork uow = new UnitOfWork();


        public List<Vehicle_Type> GetAll()
        {
            return uow.Vehicle_Type.GetAll();
        }

        public Vehicle_Type GetId(int id)
        {
            return uow.Vehicle_Type.GetId(id);
        }

        public void Modify(Vehicle_Type v)
        {
            Vehicle_Type vehicle_Type = uow.Vehicle_Type.GetId(v.Id);
            if (vehicle_Type != null)
            {
                uow.DbContext.Entry(vehicle_Type).CurrentValues.SetValues(v);
                uow.Vehicle_Type.Modify(vehicle_Type);
            }
        }

        public void Delete(int id)
        {
            Vehicle_Type vehicle_Type = uow.Vehicle_Type.GetId(id);
            if (vehicle_Type != null)
            {
                uow.Vehicle_Type.Delete(vehicle_Type);
            }
        }

        public void Insert(Vehicle_Type v)
        {
            try
            {
                int id = v.Id;
                string name = v.Name;
                string description = v.Description;


                Audit audit = new Audit(id, name, description);

                uow.Audit.Insert(audit);

                uow.Vehicle_Type.Insert(v);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error Vehicle_TypeOperations.Insert: {exp.Message}");
            }
        }
    }
}
