using System;

namespace Matrix.Domain.Models.Database
{
    public class EventSignature
    {
        public Guid EventSignatureId { get; set; }
        public Guid EventId { get; set; }
        public string SignatureName { get; set; }
        public Guid KeyId { get; set; }
        public string Signature { get; set; }

        public EventSignature()
        {
            this.EventSignatureId = Guid.NewGuid();
        }
    }
}
