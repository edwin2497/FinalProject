using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class Service_TypeRepository : Repository<Service_Type>, IService_TypeRepository
    {
        public Service_TypeRepository(Context context) : base(context)
        {

        }
    }
}
