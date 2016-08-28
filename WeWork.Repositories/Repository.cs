using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly WorkDbContext Context;

        public Repository(WorkDbContext context)
        {
            Context = context;
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void RemoveAll(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Context.Entry<T>(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> ExecWithStoreProcedure(string query, params object[] parameters)
        {
            return Context.Database.SqlQuery<T>(query, parameters);
        }
    }
}
