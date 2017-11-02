using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Wallet> GetAll()
        {
            var wallets = _dbContext.Wallets.ToList();

            return wallets;
        }

        public Wallet Get(Guid id)
        {
            var wallet = _dbContext.Wallets.FirstOrDefault(x => x.Id == id);

            return wallet;
        }

        public void Add(Wallet wallet)
        {
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
        }

        public void Update(Wallet wallet)
        {
            _dbContext.Wallets.Update(wallet);
            _dbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            var wallet = Get(id);
            _dbContext.Wallets.Remove(wallet);
            _dbContext.SaveChanges();
        }
    }
}