using System;

namespace Matrix.Domain.Models.Database
{
    public class EventEdgeHash
    {
        public Guid EventEdgeHashId { get; set; }
        public Guid EventId { get; set; }
        public Guid? PreviousEventId { get; set; }
        public string Algorithm { get; set; }
        public string Hash { get; set; }

        public EventEdgeHash()
        {
            this.EventEdgeHashId = Guid.NewGuid();
        }
    }
}
