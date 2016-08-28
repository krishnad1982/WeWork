using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeWork.Logging;
using WeWork.Models;
using WeWork.Repositories;

namespace WeWork.BusinessDomain
{
    public class BdAccountType
    {
        private static IUnitOfWork _uow;
        private static IRepository<AccountType> _repo;

        public BdAccountType()
        {
           
        }

        public static void Save(AccountType obj)
        {
            try
            {
                using (_uow = new UnitOfWork())
                {
                    _repo = new Repository<AccountType>(_uow.Context);
                    _repo.Add(obj);
                    _uow.Commit();
                }
            }
            catch (Exception ex)
            {
                LoggerWrapper.LogError("Business.BdAccountType").Error("Error occured while saving", new Exception(ex.Message));
            }
        }
    }
}
