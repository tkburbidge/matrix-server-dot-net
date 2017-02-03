using System;

namespace Matrix.Domain.Models.Database
{
    public class ServerTlsCertificate
    {
        public Guid ServerTlsCertificateId { get; set; }
        public string ServerName { get; set; }
        public string Fingerprint { get; set; }
        public string FromServer { get; set; }
        public DateTime TimestampAddedMs { get; set; }

        public ServerTlsCertificate()
        {
            this.ServerTlsCertificateId = Guid.NewGuid();
            this.TimestampAddedMs = DateTime.UtcNow;
        }
    }
}
