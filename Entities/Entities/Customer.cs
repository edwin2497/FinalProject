using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Person
    {
        #region Properties

        #endregion

        #region Constructors

        public Customer(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone) : base(id, name, firstLastName, secondLastName, cardId, password, email, phone)
        {

        }

        public Customer()
        {

        }

        #endregion
    }
}
