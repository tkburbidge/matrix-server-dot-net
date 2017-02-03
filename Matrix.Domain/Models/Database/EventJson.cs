using System;

namespace Matrix.Domain.Models.Database
{
    public class EventJson
    {
        public Guid EventJsonId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string InternalMetadata { get; set; }
        public string Json { get; set; }

        public EventJson()
        {
            this.EventJsonId = Guid.NewGuid();
        }
    }
}
