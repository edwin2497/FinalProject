using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IAdministrativeRepository : IRepository<Administrative>
    {
        bool Login(int id, string password);

        bool IsAdmin(int cardId);

        Administrative GetCardId(int cardId);
    }
}
