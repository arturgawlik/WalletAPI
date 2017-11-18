using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Wallet : Entity
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Content { get; protected set; }
        public DateTime CreatedTime { get; }
        public DateTime UpdateTime { get; protected set; }
        public int UserId { get; protected set; }


        public Wallet()
        {
        }

        public Wallet(string name, string description, int userId)
        {
            //Id = Guid.NewGuid();
            UserId = userId;
            CreatedTime = DateTime.UtcNow;
            SetName(name);
            SetDescription(description);
        }


        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Wallet name can not be null or white sapce.");

            Name = name;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new Exception("Wallet name can not be null or white sapce.");

            Description = description;
        }

        public void UdateData()
        {
            UpdateTime = DateTime.UtcNow;
        }

        public Event AddContent(decimal value)
        {
            if (value < 0)
                throw new Exception("The adding value to wallet can not be smaller than 0.");

            if (value == 0)
                return null;

            var _event = GetNewEvent(EventType.adding, Content, value, this.Id);
            Content += value;
            UdateData();

            return _event;
        }
        
        public Event SubstractContent(decimal value)
        {
            if (value < 0)
                throw new Exception("The substracted value from wallet can not be smaller than 0.");

            if (value == 0)
                return null;

            if ((Content - value) < 0)
                throw new Exception("Content can not be smaller than 0.");

            var _event = GetNewEvent(EventType.substacting, Content, value, this.Id);
            Content -= value;
            UdateData();

            return _event;
        }
        private Event GetNewEvent(EventType eventType, decimal walletContent, decimal value, int walletId)
        {
            return new Event(eventType, walletContent, value, walletId);
        }
    }
}
