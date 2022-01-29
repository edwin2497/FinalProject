using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        bool Login(int id, string password);

        Customer GetCardId(int cardId);
    }
}
