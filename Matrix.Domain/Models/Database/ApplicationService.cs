using System;

namespace Matrix.Domain.Models.Database
{
    public class ApplicationService
    {
        public Guid ApplicationServiceId { get; set; }
        public string Url { get; set; }
        public string Token { get; set; }
        public string HsToken { get; set; }
        public string Sender { get; set; }

        public ApplicationService()
        {
            this.ApplicationServiceId = Guid.NewGuid();
        }
    }
}
