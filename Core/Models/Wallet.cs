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
        public Guid UserId { get; protected set; }
        public List<Event> Events { get; protected set; }


        public Wallet()
        {
        }

        public Wallet(string name, string description, Guid userId)
        {
            Id = Guid.NewGuid();
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

        public void AddContent(decimal value)
        {
            if (value < 0)
                throw new Exception("The adding value to wallet can not be smaller than 0.");

            if (value == 0)
                return;

            Events.Add(GetNewEvent(EventType.adding, Content, value));
            Content += value;
            UdateData();
        }
        
        public void SubstractContent(decimal value)
        {
            if (value < 0)
                throw new Exception("The substracted value from wallet can not be smaller than 0.");

            if (value == 0)
                return;

            if ((Content - value) < 0)
                throw new Exception("Content can not be smaller than 0.");

            Events.Add(GetNewEvent(EventType.substacting, Content, value));
            Content -= value;
            UdateData();
        }
        private Event GetNewEvent(EventType eventType, decimal walletContent, decimal value)
        {
            return new Event(eventType, walletContent, value);
        }
    }
}
