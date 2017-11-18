using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IUserRepository
    {
        User Get(int id);
        User Get(String userName);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Remove(User user);
    }
}
