using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repositories
{
    public interface ISystemAccountRepository
    {
        public Task<SystemAccount> CreateAccount(SystemAccount _account);
        public Task<SystemAccount> GetById(short _id);
        public Task<SystemAccount> GetAll();
        public Task<SystemAccount> Update(short _id, SystemAccount _account);
        public Task<bool> Delete(short _id);
    }
}