using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class AuditRepository : Repository<Audit>, IAuditRepository
    {
        public AuditRepository(Context context) : base(context)
        {

        }
    }
}
