using System;

namespace Matrix.Domain.Models.Database
{
    public class Redaction
    {
        public Guid RedactionId { get; set; }
        public Guid EventId { get; set; }
        public string Redacts { get; set; }

        public Redaction()
        {
            this.RedactionId = Guid.NewGuid();
        }
    }
}
