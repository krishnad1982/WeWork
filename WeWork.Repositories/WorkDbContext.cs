using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeWork.Models;

namespace WeWork.Repositories
{
    public class WorkDbContext:DbContext
    {
        public WorkDbContext() : base("WeWorkConnection") { }

        public DbSet<AccountType> AccountTypes { get; set; }
    }
}
