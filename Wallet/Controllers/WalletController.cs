using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Commands.Users;
using Infrastructure.Commands.Wallets;
using Infrastructure.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Wallet.Controllers
{
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        private readonly IWalletService _walletService;
        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }


        // [HttpGet]
        // public IActionResult GetAllUsers()
        // {
        //     var users = _walletService.GetAllUsers();

        //     return Json(users);
        // }


        // [HttpGet("{username}")]
        // public IActionResult GetUser(string username)
        // {
        //     var users = _walletService.GetUser(username);

        //     return Json(users);
        // }


        [HttpPost]
        public IActionResult RegisterUser([FromBody]CreateWallet command)
        {
            _walletService.AddWallet(command.Name, command.Description, command.UserId);

            return Created("", null);
        }


        // [HttpPut("{id}")]
        // public IActionResult UpdateUser(int id, [FromBody]CreateUser command)
        // {
        //     throw new NotImplementedException();
        // }


        // [HttpDelete("{username}")]
        // public void DeleteUser(string username)
        // {
        //     _walletService.DeleteUser(username);
        // }

        // [HttpPost("AddWallet")]
        // public IActionResult AddWalletToUser([FromBody]AddWallet command)
        // {
        //     userService.AddWallet(command.UserId, command.WalletName, command.WalletDescription);

        //     return Created("", null);
        // }
    }
}