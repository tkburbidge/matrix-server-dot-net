using System;

namespace Matrix.Domain.Models.Database
{
    public class PresenceList
    {
        public Guid PresenceListId { get; set; }
        public Guid UserId { get; set; }
        public Guid ObservedUserId { get; set; }
        public bool Accepted { get; set; }

        public PresenceList()
        {
            this.PresenceListId = Guid.NewGuid();
        }
    }
}
