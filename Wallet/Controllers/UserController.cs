using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Commands.Users;
using Infrastructure.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Wallet.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var users = userService.GetAllUsers();

            return Json(users);
        }


        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            var users = userService.GetUser(username);

            return Json(users);
        }


        [HttpPost]
        public IActionResult Post([FromBody]CreateUser command)
        {
            userService.RegisterUser(command.Username, command.Password);

            return Created("", null);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]CreateUser command)
        {
            throw new NotImplementedException();
        }


        [HttpDelete("{username}")]
        public void Delete(string username)
        {
            userService.DeleteUser(username);
        }
    }
}