using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repositories
{
    public class SystemAccountRepository : ISystemAccountRepository
    {

        private readonly FunewsManagementContext _context;

        public SystemAccountRepository(FunewsManagementContext context)
        {
            _context = context;
        }

        public Task<SystemAccount> CreateAccount(SystemAccount _account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(short _id)
        {
            throw new NotImplementedException();
        }

        public Task<SystemAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SystemAccount> GetById(short _id)
        {
            throw new NotImplementedException();
        }

        public Task<SystemAccount> Update(short _id, SystemAccount _account)
        {
            throw new NotImplementedException();
        }
    }
}