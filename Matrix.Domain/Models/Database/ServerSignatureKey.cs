using System;

namespace Matrix.Domain.Models.Database
{
    public class ServerSignatureKey
    {
        public Guid ServerSignatureKeyId { get; set; }
        public string ServerName { get; set; }
        public Guid KeyId { get; set; }
        public string FromServer { get; set; }
        public DateTime TimestampAddedMs { get; set; }
        public string VerifyKey { get; set; }

        public ServerSignatureKey()
        {
            this.ServerSignatureKeyId = Guid.NewGuid();
            this.TimestampAddedMs = DateTime.UtcNow;
        }
    }
}
