using System;

namespace Matrix.Domain.Models.Database
{
    public class EventBackwardExtremity
    {
        public Guid EventBackwardExtremityId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }

        public EventBackwardExtremity()
        {
            this.EventBackwardExtremityId = Guid.NewGuid();
        }
    }
}
