using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(String userName);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task RemoveAsync(User user);
        Task AddWalletAsync(Wallet wallet);
    }
}
