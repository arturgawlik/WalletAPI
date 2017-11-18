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

        public Wallet Get(int id)
        {
            var wallet = _dbContext.Wallets.FirstOrDefault(x => x.Id == id);

            return wallet;
        }

        public Wallet Get(string name)
        {
            var wallet = _dbContext.Wallets.FirstOrDefault(x => x.Name == name);

            return wallet;
        }

        public void AddWallet(Wallet wallet)
        {
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
        }

        public void Update(Wallet wallet)
        {
            _dbContext.Wallets.Update(wallet);
            _dbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var wallet = Get(id);
            _dbContext.Wallets.Remove(wallet);
            _dbContext.SaveChanges();
        }

        public void AddContent(int walletId, decimal content)
        {
            var wallet = Get(walletId);
            var _event = wallet.AddContent(content);

            Update(wallet);
            _dbContext.Events.Add(_event);
            _dbContext.SaveChanges();
        }

        public void SubstarctContent(int walletId, decimal content)
        {
            var wallet = Get(walletId);
            var _event = wallet.SubstractContent(content);

            Update(wallet);
            _dbContext.Events.Add(_event);
            _dbContext.SaveChanges();
        }
    }
}