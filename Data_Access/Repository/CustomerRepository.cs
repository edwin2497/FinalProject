using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context)
        {

        }

        public bool Login(int cardId, string password)
        {
            Customer p;
            p = GetCardId(cardId);

            if(p == null)
            {
                return false;
            }
            else if (cardId.Equals(p.CardId) && password.Equals(p.Password))
            {
                return true;
            }

            return false;
        }

        public Customer GetCardId(int cardId)
        {
            return _context.Customers.Where(x => x.CardId == cardId).SingleOrDefault();
        }
    }
}
