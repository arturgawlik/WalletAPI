using System;

namespace Infrastructure.Commands.Users
{
    public class AddWallet
    {
        public Guid UserId { get; set; }
        public string WalletName { get; set; }
        public string WalletDescription { get; set; }
    }
}