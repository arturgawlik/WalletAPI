using System;
using System.Collections.Generic;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IWalletService
    {
        IEnumerable<WalletDto> GetAllWallets();
        WalletDto GetWallet(Guid id);
        WalletDto GetWallet(string name);
        void AddWallet(string name, string description, Guid userId);
        void DeleteWallet(Guid id);
    }
}