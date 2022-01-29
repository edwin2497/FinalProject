using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(Context context) : base(context)
        {

        }
        public List<Service> ServiceCustomerList(int cardId)
        {
            List<Service> destinationlist = new List<Service>();

            List<Service> servicelist = GetAll();

            foreach (Service service in servicelist)
            {
                if ( service.IdCustomer == cardId)
                {
                    destinationlist.Add(new Service()
                    {
                        Id = service.Id
                    ,
                        Cost = service.Cost
                    ,
                        ServiceType = service.ServiceType
                    ,
                        IdCustomer = service.IdCustomer
                    ,
                        VehicleId = service.VehicleId


                    });
                }

            }

            return destinationlist;
        }
    }
}
