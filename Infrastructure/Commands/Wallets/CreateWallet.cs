using System;

namespace Infrastructure.Commands.Wallets
{
    public class CreateWallet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}