using System;

namespace Matrix.Domain.Models.Database
{
    public class ApplicationServiceTransaction
    {
        public Guid ApplicationServiceTransactionId { get; set; }
        public Guid ApplicationServiceId { get; set; }
        public Guid TransactionId { get; set; }
        public string EventIds { get; set; }

        public ApplicationServiceTransaction()
        {
            this.ApplicationServiceTransactionId = Guid.NewGuid();
        }
    }
}
