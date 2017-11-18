using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IEventRepository
    {
         Event Get(int id);
         IEnumerable<Event> GetAllForWalletId(int walletId);
         IEnumerable<Event> GetAllForUserId(int userId);
         IEnumerable<Event> GetAll();
         //void Add(Event @event);
         //void Update(Event @event);
         //void Remove(Event @event);
    }
}