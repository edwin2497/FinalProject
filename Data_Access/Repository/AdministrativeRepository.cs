using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Data_Access
{
    public class AdministrativeRepository : Repository<Administrative> , IAdministrativeRepository
    {
        public AdministrativeRepository(Context context) : base(context)
        {

        }

        public bool IsAdmin(int cardId)
        {
            Administrative p;
            p = GetCardId(cardId);
            if (p == null)
            {
                return false;
            }
            else if (p.IsAdmin == true)
            {
                return true;
            }
            return false;
        }

        public bool Login(int cardId, string password)
        {
            Administrative p;
            p = GetCardId(cardId);

            if (p == null)
            {
                return false;
            }
            else if (cardId.Equals(p.CardId) && password.Equals(p.Password))
            {
                return true;
            }

            return false;
        }

        public Administrative GetCardId(int cardId)
        {
            return _context.Administratives.Where(x => x.CardId == cardId).SingleOrDefault();
        }
    }
}
