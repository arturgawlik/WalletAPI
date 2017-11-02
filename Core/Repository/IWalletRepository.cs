using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IWalletRepository
    {
         Wallet Get(Guid id);
         IEnumerable<Wallet> GetAll();
         void Add(Wallet wallet);
         void Update(Wallet wallet);
         void Remove(Guid id);
    }
}