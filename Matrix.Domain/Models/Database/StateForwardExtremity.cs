using System;

namespace Matrix.Domain.Models.Database
{
    public class StateForwardExtremity
    {
        public Guid StateForwardExtremityId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string Type { get; set; }
        public string StateKey { get; set; }

        public StateForwardExtremity()
        {
            this.StateForwardExtremityId = Guid.NewGuid();
        }
    }
}
