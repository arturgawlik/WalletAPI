using System;
using System.Collections.Generic;
using System.Linq;
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

        public WalletDto GetWallet(string name)
        {
            var wallet = _walletRepository.Get(name);

            return _mapper.Map<WalletDto>(wallet);
        }

        public void AddWallet(string name, string description, Guid userId)
        {
            var wallet = _walletRepository.Get(name);
            
            if(wallet != null)
                throw new Exception($"Wallet with name: '{name}' already exist.");

            wallet = new Wallet(name, description, userId);
            _walletRepository.AddWallet(wallet);
        }
        public void DeleteWallet(Guid id)
        {
            _walletRepository.Remove(id);
        }

        public void AddContent(Guid walletId, decimal content)
        {
            _walletRepository.AddContent(walletId, content);
        }

        public void SubstarctContent(Guid walletId, decimal content)
        {
            _walletRepository.SubstarctContent(walletId, content);
        }
    }
}