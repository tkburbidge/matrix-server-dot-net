using System;

namespace Matrix.Domain.Models.Database
{
    public class EventDestination
    {
        public Guid EventDestinationId { get; set; }
        public Guid EventId { get; set; }
        public Guid DestinationId { get; set; }
        public DateTime? DeliveredTimestamp { get; set; }

        public EventDestination()
        {
            this.EventDestinationId = Guid.NewGuid();
        }
    }
}
