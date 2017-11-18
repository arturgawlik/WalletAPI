using System;

namespace Infrastructure.Commands.Wallets
{
    public class ChangeContent
    {
        public int WalletId { get; set; }
        public decimal Content { get; set; }
    }
}