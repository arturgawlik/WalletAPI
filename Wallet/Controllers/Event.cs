using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Commands.Users;
using Infrastructure.Commands.Wallets;
using Infrastructure.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Wallet.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }


        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = _eventService.GetAll();

            return Json(events);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var _event = _eventService.Get(id);

            return Json(_event);
        }

        [HttpGet("{userId}")]
        public IActionResult GetAllForUserId(int userId)
        {
            var events = _eventService.GetAllForUserId(userId);

            return Json(events);
        }

        [HttpGet("{walletId}")]
        public IActionResult GetAllForWalletId(int walletId)
        {
            var events = _eventService.GetAllForWalletId(walletId);

            return Json(events);
        }
    }
}