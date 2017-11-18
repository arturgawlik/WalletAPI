using System;
using System.Collections.Generic;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IWalletService
    {
        IEnumerable<WalletDto> GetAllWallets();
        WalletDto GetWallet(int id);
        WalletDto GetWallet(string name);
        void AddWallet(string name, string description, int userId);
        void DeleteWallet(int id);
        void AddContent(int walletId, decimal AddContent);
        void SubstarctContent(int walletId, decimal content);
    }
}