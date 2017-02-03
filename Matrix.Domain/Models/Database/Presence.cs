using System;

namespace Matrix.Domain.Models.Database
{
    public class Presence
    {
        public Guid PresenceId { get; set; }
        public Guid UserId { get; set; }
        public string State { get; set; }
        public string StatusMsg { get; set; }
        public DateTime? Mtime { get; set; }

        public Presence()
        {
            this.PresenceId = Guid.NewGuid();
        }
    }
}
