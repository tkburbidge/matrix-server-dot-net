using System;

namespace Matrix.Domain.Models.Database
{
    public class PresenceAllowInbound
    {
        public Guid PresenceAllowInboundId { get; set; }
        public Guid ObservedUserId { get; set; }
        public Guid ObserverUserId { get; set; }

        public PresenceAllowInbound()
        {
            this.PresenceAllowInboundId = Guid.NewGuid();
        }
    }
}
