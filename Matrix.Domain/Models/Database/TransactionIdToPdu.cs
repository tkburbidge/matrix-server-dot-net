using System;

namespace Matrix.Domain.Models.Database
{
    public class TransactionIdToPdu
    {
        public Guid TransactionIdToPduId { get; set; }
        public Guid TransactionId { get; set; }
        public string Destination { get; set; }
        public Guid PduId { get; set; }
        public string PduOrigin { get; set; }

        public TransactionIdToPdu()
        {
            this.TransactionIdToPduId = Guid.NewGuid();
        }
    }
}
