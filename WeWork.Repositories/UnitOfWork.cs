using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected readonly object _lockingobj = new object();
        private WorkDbContext _Context;

        public WorkDbContext Context
        {
            get
            {
                if (_Context == null)
                {
                    lock (_lockingobj)
                    {
                        _Context = new WorkDbContext();
                    }
                }
                return _Context;
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Context != null)
                {
                    _Context.Dispose();
                    _Context = null;
                }
            }
        }
    }
}
