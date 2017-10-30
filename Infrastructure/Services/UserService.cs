using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Models;
using Core.Repository;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }
        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var users = await userRepository.GetAllAsync();

            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<UserDto> GetUserAsync(string username)
        {
            var user = await userRepository.GetAsync(username);

            return mapper.Map<UserDto>(user);
        }

        public async Task RegisterUserAsync(string username, string password)
        {
            var user = await userRepository.GetAsync(username);
            
            if(user != null)
                throw new Exception($"User with username '{username}' already exist.");
            if(string.IsNullOrWhiteSpace(username))
                throw new Exception("Username can not be empty");
            if(string.IsNullOrWhiteSpace(password))
                throw new Exception("Password can not be null.");

            user = new User(username, password);

            await userRepository.AddAsync(user);
        }

        public async Task DeleteUserAsync(string username)
        {
            var user = await userRepository.GetAsync(username);

            if(user == null)
                throw new Exception($"User with username '{username}' do not exsist.");

            await userRepository.RemoveAsync(user);
        }
    }
}