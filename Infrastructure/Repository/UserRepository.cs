using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Infrastructure.EF;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WalletContext _dbContext;
        public UserRepository(WalletContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _dbContext.Users.FirstAsync(x => x.Id == id);
        }

        public async Task<User> GetAsync(string userName)
        {
            return await _dbContext.Users.FirstAsync(x => x.Username == userName);
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task RemoveAsync(User user)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task AddWalletAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }
    }
}