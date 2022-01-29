using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class Context : DbContext
    {
        public Context() : base("name = STRCNN")
        {

        }

        public virtual DbSet<Administrative> Administratives { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<Service_Type> Service_Types { get; set; }

        public virtual DbSet<Vehicle> Vehicles { get; set; }

        public virtual DbSet<Vehicle_Type> Vehicle_Types { get; set; }

        public virtual DbSet<Audit> Audits { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
