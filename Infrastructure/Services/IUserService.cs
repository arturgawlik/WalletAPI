using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IUserService
    {
         IEnumerable<UserDto> GetAllUsers();
         UserDto GetUser(string username);
         void RegisterUser(string username, string password);
         void DeleteUser(string username);
    }
}