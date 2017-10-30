using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;

namespace Infrastructure.Repository
{
    public class EventRepository : IEventRepository
    {
        public Task<IEnumerable<Event>> GetAllAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Event @event)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Event @event)
        {
            throw new NotImplementedException();
        }
        public Task RemoveAsync(Event @event)
        {
            throw new NotImplementedException();
        }
    }
}