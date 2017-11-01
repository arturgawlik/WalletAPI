using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IWalletRepository
    {
         Task<Wallet> GetAsync(Guid id);
         Task<IEnumerable<Wallet>> GetAllAsync(User user);
         void Add(Wallet wallet);
         Task UpdateAsync(Wallet wallet);
         Task RemoveAsync(Guid id);
    }
}