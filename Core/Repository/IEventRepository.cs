using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repository
{
    public interface IEventRepository
    {
         Task<Event> GetAsync(Guid id);
         Task<IEnumerable<Event>> GetAllAsync(Wallet wallet);
         Task AddAsync(Event @event);
         Task UpdateAsync(Event @event);
         Task RemoveAsync(Event @event);
    }
}