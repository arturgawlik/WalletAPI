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
        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = userRepository.GetAll();

            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public UserDto GetUser(string username)
        {
            var user = userRepository.Get(username);

            return mapper.Map<UserDto>(user);
        }

        public void RegisterUser(string username, string password)
        {
             var user = userRepository.Get(username);
            
             if(user != null)
                 throw new Exception($"User with username '{username}' already exist.");
             if(string.IsNullOrWhiteSpace(username))
                 throw new Exception("Username can not be empty");
             if(string.IsNullOrWhiteSpace(password))
                 throw new Exception("Password can not be null.");

            user = new User(username, password);

            userRepository.Add(user);
        }

        public void DeleteUser(string username)
        {
            var user = userRepository.Get(username);

            if(user == null)
                throw new Exception($"User with username '{username}' do not exsist.");

            userRepository.Remove(user);
        }
    }
}