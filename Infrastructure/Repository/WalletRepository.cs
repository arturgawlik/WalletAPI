using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Infrastructure.EF;

namespace Infrastructure.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private readonly WalletContext _dbContext;
        public WalletRepository(WalletContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<IEnumerable<Wallet>> GetAllAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Wallet> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Wallet wallet)
        {
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
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