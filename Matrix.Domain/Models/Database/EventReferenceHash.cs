using System;

namespace Matrix.Domain.Models.Database
{
    public class EventReferenceHash
    {
        public Guid EventReferenceHashId { get; set; }
        public Guid EventId { get; set; }
        public string Algorithm { get; set; }
        public string Hash { get; set; }

        public EventReferenceHash()
        {
            this.EventReferenceHashId = Guid.NewGuid();
        }
    }
}
