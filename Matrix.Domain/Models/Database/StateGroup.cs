using System;

namespace Matrix.Domain.Models.Database
{
    public class StateGroup
    {
        public Guid StateGroupId { get; set; }
        public Guid RoomId { get; set; }
        public Guid EventId { get; set; }

        public StateGroup()
        {
            this.StateGroupId = Guid.NewGuid();
        }
    }
}
