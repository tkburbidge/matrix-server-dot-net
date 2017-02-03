using System;

namespace Matrix.Domain.Models.Database
{
    public class StateGroupState
    {
        public Guid StateGroupStateId { get; set; }
        public Guid StateGroupId { get; set; }
        public Guid RoomId { get; set; }
        public string Type { get; set; }
        public string StateKey { get; set; }
        public Guid EventId { get; set; }

        public StateGroupState()
        {
            this.StateGroupStateId = Guid.NewGuid();
        }
    }
}
