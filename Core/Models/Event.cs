using System;
namespace Core.Models
{
    public class Event : Entity
    {
        public string Name { get; protected set; }
        public decimal WalletBeforeEvent { get; protected set; }
        public decimal WalletAfterEvent { get; protected set; }
        public decimal HowMuch { get; protected set; }
        public EventType OperationType { get; protected set; }
        public DateTime EventTime { get; protected set; }
        public Guid WalletId { get; protected set; }


        public Event()
        {
        }

        public Event(EventType eventType, decimal walletContent, decimal value, Guid walletId)
        {
            Id = Guid.NewGuid();
            WalletId = walletId;
            OperationType = eventType;
            switch(eventType)
            {
                case EventType.adding:
                    {
                        Name = "Adding value";
                        WalletBeforeEvent = walletContent;
                        WalletAfterEvent = WalletBeforeEvent + value;
                        HowMuch = value;
                        EventTime = DateTime.UtcNow;
                        break;
                    }
                case EventType.substacting:
                    {
                        Name = "Substracing value";
                        WalletBeforeEvent = walletContent;
                        WalletAfterEvent = WalletBeforeEvent - value;
                        HowMuch = value;
                        EventTime = DateTime.UtcNow;
                        break;
                    }
                default:
                    {
                        throw new Exception("Unsupported event.");
                    }
            }
        }

    }



    public enum EventType
    {
        adding,
        substacting
    }
}
