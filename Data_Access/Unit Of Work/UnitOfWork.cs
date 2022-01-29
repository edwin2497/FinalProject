using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _db;

        private IAdministrativeRepository _Administrative;
        private ICustomerRepository _Customer;
        private IServiceRepository _Service;
        private IService_TypeRepository _Service_Type;
        private IVehicleRepository _Vehicle;
        private IVehicle_TypeRepository _Vehicle_Type;
        private IAuditRepository _Audit;


        public Context DbContext
        {
            get { return _db; }
        }

        public IAdministrativeRepository Administrative
        {
            get
            {
                if (this._Administrative == null)
                {
                    this._Administrative = new AdministrativeRepository(_db);
                }
                return this._Administrative;
            }
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (this._Customer == null)
                {
                    this._Customer = new CustomerRepository(_db);
                }
                return this._Customer;
            }
        }
        public IServiceRepository Service
        {
            get
            {
                if (this._Service == null)
                {
                    this._Service = new ServiceRepository(_db);
                }
                return this._Service;
            }
        }

        public IService_TypeRepository Service_Type
        {
            get
            {
                if (this._Service_Type == null)
                {
                    this._Service_Type = new Service_TypeRepository(_db);
                }
                return this._Service_Type;
            }
        }


        public IVehicleRepository Vehicle
        {
            get
            {
                if (this._Vehicle == null)
                {
                    this._Vehicle = new VehicleRepository(_db);
                }
                return this._Vehicle;
            }
        }

        public IVehicle_TypeRepository Vehicle_Type
        {
            get
            {
                if (this._Vehicle_Type == null)
                {
                    this._Vehicle_Type = new Vehicle_TypeRepository(_db);
                }
                return this._Vehicle_Type;
            }
        }

        public IAuditRepository Audit
        {
            get
            {
                if (this._Audit == null)
                {
                    this._Audit = new AuditRepository(_db);
                }
                return this._Audit;
            }
        }

        public UnitOfWork()
        {
            _db = new Context();

        }
        public void Dispose()
        {

        }

        public int SaveChanges()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 1;
        }
    }
}
