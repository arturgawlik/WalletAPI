using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IEventRepository
    {
         Event Get(Guid id);
         IEnumerable<Event> GetAllForWalletId(Guid walletId);
         IEnumerable<Event> GetAllForUserId(Guid userId);
         IEnumerable<Event> GetAll();
         //void Add(Event @event);
         //void Update(Event @event);
         //void Remove(Event @event);
    }
}