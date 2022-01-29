using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IServiceRepository : IRepository<Service>
    {
        List<Service> ServiceCustomerList(int cardId);
    }
}
