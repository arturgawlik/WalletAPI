using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IWalletRepository
    {
         Wallet Get(int id);
         Wallet Get(string name);
         IEnumerable<Wallet> GetAll();
        void AddContent(int walletId, decimal content);
        void SubstarctContent(int walletId, decimal content);
         void AddWallet(Wallet wallet);
         void Update(Wallet wallet);
         void Remove(int id);
    }
}