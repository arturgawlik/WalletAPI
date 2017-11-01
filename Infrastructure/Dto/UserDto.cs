using System.Collections.Generic;
using Core.Models;

namespace Infrastructure.Dto
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Wallet> Wallets { get; set; }
    }
}