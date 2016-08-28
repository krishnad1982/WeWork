using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Repositories
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);
        void RemoveAll(IEnumerable<T> entities);
        IEnumerable<T> ExecWithStoreProcedure(string query, params object[] parameters);
    }
}
