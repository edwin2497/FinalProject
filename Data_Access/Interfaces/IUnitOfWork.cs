using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IUnitOfWork : IDisposable
    {
        IAuditRepository Audit { get; }

        IAdministrativeRepository Administrative { get; }

        ICustomerRepository Customer { get; }

        IServiceRepository Service { get; }

        IService_TypeRepository Service_Type { get; }

        IVehicleRepository Vehicle { get; }

        IVehicle_TypeRepository Vehicle_Type { get; }

        Context DbContext { get; }

        int SaveChanges();
    }
}
