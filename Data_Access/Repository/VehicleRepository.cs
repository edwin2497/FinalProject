using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(Context context) : base(context)
        {

        }

        public List<Vehicle> VehicleCustomerList(int cardId)
        {
            List<Vehicle> destinationlist = new List<Vehicle>();

            List<Vehicle> vehiclelist = GetAll();

            foreach (Vehicle vehicle in vehiclelist)
            {
                if (vehicle.IdCustomer == cardId)
                {
                    destinationlist.Add(new Vehicle()
                    {
                        Id = vehicle.Id
                    ,
                        Brand = vehicle.Brand
                    ,
                        Model = vehicle.Model
                    ,
                        Year = vehicle.Year
                    ,
                        Plate = vehicle.Plate
                    ,
                        Type = vehicle.Type
                    ,
                        IdCustomer = vehicle.IdCustomer

                    });
                }
                
            }

            return destinationlist;
        }
    }
}