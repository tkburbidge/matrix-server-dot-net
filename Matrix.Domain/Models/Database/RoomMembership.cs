using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomMembership
    {
        public Guid RoomMembershipId { get; set; }
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public string Sender { get; set; }
        public Guid RoomId { get; set; }
        public string Membership { get; set; }

        public RoomMembership()
        {
            this.RoomMembershipId = Guid.NewGuid();
        }
    }
}
