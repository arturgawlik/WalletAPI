using System;
using System.Collections.Generic;
using AutoMapper;
using Core.Repository;
using Infrastructure.Dto;

namespace Infrastructure.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventrepository;
        private readonly IMapper _mapper;
        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventrepository = eventRepository;
            _mapper = mapper;
        }

        public EventDto Get(Guid id)
        {
            var _event = _eventrepository.Get(id);

            return _mapper.Map<EventDto>(_event);
        }

        public IEnumerable<EventDto> GetAll()
        {
            var events = _eventrepository.GetAll();

            return _mapper.Map<IEnumerable<EventDto>>(events);
        }

        public IEnumerable<EventDto> GetAllForUserId(Guid userId)
        {
            var events = _eventrepository.GetAllForUserId(userId);

            return _mapper.Map<IEnumerable<EventDto>>(events);
        }

        public IEnumerable<EventDto> GetAllForWalletId(Guid walletId)
        {
            var events = _eventrepository.GetAllForWalletId(walletId);

            return _mapper.Map<IEnumerable<EventDto>>(events);
        }
    }
}