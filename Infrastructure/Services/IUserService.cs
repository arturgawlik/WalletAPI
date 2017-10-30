using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IUserService
    {
         Task<IEnumerable<UserDto>> GetAllUsers();
         Task<UserDto> GetUserAsync(string username);
         Task RegisterUserAsync(string username, string password);
         Task DeleteUserAsync(string username);
    }
}