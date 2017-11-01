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
        
        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User Get(Guid id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Get(string userName)
        {
             return _dbContext.Users.FirstOrDefault(x => x.Username == userName);
        }

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }
        
        public void Remove(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }
}