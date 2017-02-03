using System;

namespace Matrix.Domain.Models.Database
{
    public class ApplicationServiceState
    {
        public Guid ApplicationServiceStateId { get; set; }
        public Guid ApplicationServiceId { get; set; }
        public string State { get; set; }

        public ApplicationServiceState()
        {
            this.ApplicationServiceStateId = Guid.NewGuid();
        }
    }
}
