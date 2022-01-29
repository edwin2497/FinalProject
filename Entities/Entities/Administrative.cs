using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Administrative : Person
    {
        #region Properties

        [Required]
        public bool IsAdmin { get; set; }

        #endregion


        #region Constructors

        public Administrative(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone, bool isAdmin) : base(id, name, firstLastName, secondLastName, cardId, password, email, phone)
        {
            this.IsAdmin = isAdmin;
        }

        public Administrative()
        {

        }

        #endregion
    }
}
