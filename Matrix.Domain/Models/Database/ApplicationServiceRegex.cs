using System;

namespace Matrix.Domain.Models.Database
{
    public class ApplicationServiceRegex
    {
        public Guid ApplicationServiceRegexId { get; set; }
        public Guid ApplicationServiceId { get; set; }
        public int? Namespace { get; set; }
        public string Regex { get; set; }

        public ApplicationServiceRegex()
        {
            this.ApplicationServiceRegexId = Guid.NewGuid();
        }
    }
}
