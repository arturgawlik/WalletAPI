using System;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    public interface IWalletService
    {
         void AddWallet(string name, string description, Guid userId);
    }
}