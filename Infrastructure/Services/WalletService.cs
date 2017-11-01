using System;
using System.Collections.Generic;
using AutoMapper;
using Core.Models;
using Core.Repository;
using Infrastructure.Dto;

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


        public IEnumerable<WalletDto> GetAllWallets()
        {
            throw new NotImplementedException();
        }

        public WalletDto GetWallet(string name)
        {
            throw new NotImplementedException();
        }
        public void AddWallet(string name, string description, Guid userId)
        {
            var wallet = new Wallet(name, description, userId);
            _walletRepository.Add(wallet);
        }
        public void DeleteWallet(string name)
        {
            throw new NotImplementedException();
        }
    }
}