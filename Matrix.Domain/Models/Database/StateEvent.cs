using System;

namespace Matrix.Domain.Models.Database
{
    public class StateEvent
    {
        public Guid StateEventId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string Type { get; set; }
        public string StateKey { get; set; }
        public string PrevState { get; set; }

        public StateEvent()
        {
            this.StateEventId = Guid.NewGuid();
        }
    }
}
