using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class Vehicle_TypeRepository : Repository<Vehicle_Type>, IVehicle_TypeRepository
    {
        public Vehicle_TypeRepository(Context context) : base(context)
        {

        }
    }
}
