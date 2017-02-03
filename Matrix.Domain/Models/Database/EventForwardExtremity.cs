using System;

namespace Matrix.Domain.Models.Database
{
    public class EventForwardExtremity
    {
        public Guid EventForwardExtremityId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }

        public EventForwardExtremity()
        {
            this.EventForwardExtremityId = Guid.NewGuid();
        }
    }
}
