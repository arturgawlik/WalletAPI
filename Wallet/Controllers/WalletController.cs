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


        [HttpGet]
        public IActionResult GetAllWallets()
        {
            var users = _walletService.GetAllWallets();

            return Json(users);
        }


        [HttpGet("{id}")]
        public IActionResult GetWallet(Guid id)
        {
            var users = _walletService.GetWallet(id);

            return Json(users);
        }


        [HttpPost]
        public IActionResult AddWallet([FromBody]CreateWallet command)
        {
            _walletService.AddWallet(command.Name, command.Description, command.UserId);

            return Created("", null);
        }


         [HttpPut("{id}")]
         public IActionResult UpdateUser(int id, [FromBody]CreateUser command)
         {
             throw new NotImplementedException();
         }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            _walletService.DeleteWallet(id);

            return Ok();
        }

        [HttpPost("add")]
        public IActionResult AddContent([FromBody]ChangeContent command)
        {
            _walletService.AddContent(command.WalletId, command.Content);

            return Ok();
        }

        [HttpPost("substract")]
        public IActionResult SubstractContent([FromBody]ChangeContent command)
        {
            _walletService.SubstarctContent(command.WalletId, command.Content);

            return Ok();
        }
    }
}