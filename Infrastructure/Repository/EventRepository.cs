using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Repository;
using Infrastructure.EF;

namespace Infrastructure.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly WalletContext _dbContext;
        public EventRepository(WalletContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Event Get(Guid id)
        {
            var _event = _dbContext.Events.FirstOrDefault(x => x.Id == id);

            return _event;
        }

        public IEnumerable<Event> GetAll()
        {
            var events = _dbContext.Events.ToList();

            return events;
        }

        public IEnumerable<Event> GetAllForUserId(Guid userId)
        {
            var wallets = _dbContext.Wallets.Where(x => x.UserId == userId);
            List<Event> events = new List<Event>();
            foreach(var wallet in wallets)
            {
                events.AddRange(_dbContext.Events.Where(x => x.WalletId == wallet.Id));
            }    

            return events;
        }

        public IEnumerable<Event> GetAllForWalletId(Guid walletId)
        {
            var events = _dbContext.Events.Where(x => x.WalletId == walletId);

            return events;
        }
    }
}