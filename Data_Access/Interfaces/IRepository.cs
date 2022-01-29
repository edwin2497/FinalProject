using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IRepository<T> where T : class
    {
        T GetId(object id);

        void Insert(T entity);

        void Modify(T entity);

        void Delete(T entity);

        List<T> GetAll();

        IQueryable<T> Table { get; }
    }
}
