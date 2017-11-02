using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IWalletRepository
    {
         Wallet Get(Guid id);
         Wallet Get(string name);
         IEnumerable<Wallet> GetAll();
        void AddContent(decimal content);
        void SubstarctContent(decimal content);
         void AddWallet(Wallet wallet);
         void Update(Wallet wallet);
         void Remove(Guid id);
    }
}