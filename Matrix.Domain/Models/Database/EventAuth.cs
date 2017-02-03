using System;

namespace Matrix.Domain.Models.Database
{
    public class EventAuth
    {
        public Guid EventAuthId { get; set; }
        public Guid EventId { get; set; }
        public Guid AuthId { get; set; }
        public Guid RoomId { get; set; }

        public EventAuth()
        {
            this.EventAuthId = Guid.NewGuid();
        }
    }
}
