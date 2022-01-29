using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VehicleOperations
    {
        IUnitOfWork uow = new UnitOfWork();


        public List<Vehicle> GetAll()
        {
            return uow.Vehicle.GetAll();
        }

        public Vehicle GetId(int id)
        {
            return uow.Vehicle.GetId(id);
        }

        public void Modify(Vehicle v)
        {
            Vehicle vehicle = uow.Vehicle.GetId(v.Id);
            if (vehicle != null)
            {
                uow.DbContext.Entry(vehicle).CurrentValues.SetValues(v);
                uow.Vehicle.Modify(vehicle);
            }
        }

        public void Delete(int id)
        {
            Vehicle vehicle = uow.Vehicle.GetId(id);
            if (vehicle != null)
            {
                uow.Vehicle.Delete(vehicle);
            }
        }

        public void Insert(Vehicle v)
        {
            try
            {
                int id = v.Id;
                string brand = v.Brand;
                string model = v.Model;
                int year = v.Year;
                string plate = v.Plate;
                int type = v.Type;
                int idCustomer = v.IdCustomer;


                Audit audit = new Audit(id, brand, idCustomer, model, year, plate,type);

                uow.Audit.Insert(audit);

                uow.Vehicle.Insert(v);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error VehicleOperations.Insert: {exp.Message}");
            }
        }

        public List<Vehicle> VehicleCustomerList(int cardId)
        {
            return uow.Vehicle.VehicleCustomerList(cardId);
        }
    }
}
