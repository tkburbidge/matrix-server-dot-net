using System;

namespace Matrix.Domain.Models.Database
{
    public class Destination
    {
        public Guid DestinationId { get; set; }
        public string DestinationName { get; set; }
        public DateTime? RetryLastTimestamp { get; set; }
        public int? RetryInterval { get; set; }

        public Destination()
        {
            this.DestinationId = Guid.NewGuid();
        }
    }
}
