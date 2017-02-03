using System;

namespace Matrix.Domain.Models.Database
{
    public class EventEdge
    {
        public Guid EventEdgeId { get; set; }
        public Guid EventId { get; set; }
        public Guid PreviousEventId { get; set; }
        public Guid RoomId { get; set; }
        public bool IsState { get; set; }

        public EventEdge()
        {
            this.EventEdgeId = Guid.NewGuid();
        }
    }
}
