using System;

namespace Matrix.Domain.Models.Database
{
    public class Rejection
    {
        public Guid RejectionId { get; set; }
        public Guid EventId { get; set; }
        public string Reason { get; set; }
        public string LastCheck { get; set; }

        public Rejection()
        {
            this.RejectionId = Guid.NewGuid();
        }
    }
}
