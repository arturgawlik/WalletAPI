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
        public IEnumerable<Wallet> GetAll(User user)
        {
            throw new NotImplementedException();
        }

        public Wallet Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Wallet wallet)
        {
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
        }

        public void Update(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}