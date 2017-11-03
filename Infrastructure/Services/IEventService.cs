using System;
using System.Collections.Generic;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public interface IEventService
    {
        EventDto Get(Guid id);
        IEnumerable<EventDto> GetAllForWalletId(Guid walletId);
        IEnumerable<EventDto> GetAllForUserId(Guid userId);
        IEnumerable<EventDto> GetAll(); 
    }
}