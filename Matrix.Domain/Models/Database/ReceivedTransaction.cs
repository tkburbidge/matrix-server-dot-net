using System;

namespace Matrix.Domain.Models.Database
{
    public class ReceivedTransaction
    {
        public Guid ReceivedTransactionId { get; set; }
        public Guid TransactionId { get; set; }
        public string Origin { get; set; }
        public DateTime Timestamp { get; set; }
        public int? ResponseCode { get; set; }
        public string ResponseJson { get; set; }
        public bool HasBeenReferenced { get; set; }

        public ReceivedTransaction()
        {
            this.ReceivedTransactionId = Guid.NewGuid();
        }
    }
}
