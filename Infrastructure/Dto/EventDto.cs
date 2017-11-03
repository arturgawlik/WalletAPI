using System;
using Core.Models;

namespace Infrastructure.Dto
{
    public class EventDto
    {
        public string Name { get; set; }
        public decimal WalletBeforeEvent { get; set; }
        public decimal WalletAfterEvent { get; set; }
        public decimal HowMuch { get; set; }
        public EventType OperationType { get; set; }
        public DateTime EventTime { get; set; }
    }
}