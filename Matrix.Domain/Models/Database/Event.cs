using System;

namespace Matrix.Domain.Models.Database
{
    public class Event
    {
        public Guid EventId { get; set; }
        public int StreamOrdering { get; set; }
        public long TopologicalOrdering { get; set; }
        public string Type { get; set; }
        public Guid RoomId { get; set; }
        public string Content { get; set; }
        public string UnrecognizedKeys { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsOutlier { get; set; }
        public long Depth { get; set; }

        public Event()
        {
            this.EventId = Guid.NewGuid();
        }
    }
}
