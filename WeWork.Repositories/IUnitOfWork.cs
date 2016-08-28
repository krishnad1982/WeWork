using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        WorkDbContext Context { get; }
        void Commit();
    }
}
