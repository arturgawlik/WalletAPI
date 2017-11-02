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
        private readonly IMapper _mapper;
        public WalletService(IMapper mapper, IWalletRepository walletRepository)
        {
            _mapper = mapper;
            _walletRepository = walletRepository;
        }


        public IEnumerable<WalletDto> GetAllWallets()
        {
            var wallets = _walletRepository.GetAll();

            return _mapper.Map<IEnumerable<WalletDto>>(wallets);
        }

        public WalletDto GetWallet(Guid id)
        {
            var wallet = _walletRepository.Get(id);

            return _mapper.Map<WalletDto>(wallet);
        }
        public void AddWallet(string name, string description, Guid userId)
        {
            var wallet = new Wallet(name, description, userId);
            _walletRepository.Add(wallet);
        }
        public void DeleteWallet(Guid id)
        {
            _walletRepository.Remove(id);
        }
    }
}