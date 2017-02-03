using System;

namespace Matrix.Domain.Models.Database
{
    public class EventContentHash
    {
        public Guid EventContentHashId { get; set; }
        public Guid? EventId { get; set; }
        public string Algorithm { get; set; }
        public string Hash { get; set; }

        public EventContentHash()
        {
            this.EventContentHashId = Guid.NewGuid();
        }
    }
}
