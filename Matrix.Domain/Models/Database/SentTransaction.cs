using System;

namespace Matrix.Domain.Models.Database
{
    public class SentTransaction
    {
        public Guid SentTransactionId { get; set; }
        public Guid TransactionId { get; set; }
        public string Destination { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseJson { get; set; }
        public DateTime Timestamp { get; set; }

        public SentTransaction()
        {
            this.SentTransactionId = Guid.NewGuid();
            this.Timestamp = DateTime.UtcNow;
        }
    }
}
