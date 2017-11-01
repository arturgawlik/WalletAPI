using System;
using AutoMapper;
using Core.Models;
using Core.Repository;

namespace Infrastructure.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper mapper;
        public WalletService(IMapper mapper, IWalletRepository walletRepository)
        {
            this.mapper = mapper;
            _walletRepository = walletRepository;
        }
        public void AddWallet(string name, string description, Guid userId)
        {
            var wallet = new Wallet(name, description, userId);
            _walletRepository.Add(wallet);
        }
    }
}