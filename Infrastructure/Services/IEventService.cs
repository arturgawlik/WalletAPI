using System;
using System.Collections.Generic;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IEventService
    {
        EventDto Get(int id);
        IEnumerable<EventDto> GetAllForWalletId(int walletId);
        IEnumerable<EventDto> GetAllForUserId(int userId);
        IEnumerable<EventDto> GetAll(); 
    }
}