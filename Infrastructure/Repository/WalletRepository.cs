using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;

namespace Infrastructure.Repository
{
    public class WalletRepository : IWalletRepository
    {
        public Task<IEnumerable<Wallet>> GetAllAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Wallet> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}