using System;

namespace Infrastructure.Commands.Wallets
{
    public class CreateWallet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}