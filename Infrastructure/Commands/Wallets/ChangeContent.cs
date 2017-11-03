using System;

namespace Infrastructure.Commands.Wallets
{
    public class ChangeContent
    {
        public Guid WalletId { get; set; }
        public decimal Content { get; set; }
    }
}