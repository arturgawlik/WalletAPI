using AutoMapper;
using Core.Models;
using Infrastructure.Dto;

namespace Infrastructure.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            return new MapperConfiguration( cfg => 
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Wallet, WalletDto>();
                cfg.CreateMap<Event, EventDto>();
            })
            .CreateMapper();
        }
    }
}