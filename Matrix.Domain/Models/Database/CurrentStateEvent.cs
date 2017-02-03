using System;

namespace Matrix.Domain.Models.Database
{
    public class CurrentStateEvent
    {
        public Guid CurrentStateEventId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string Type { get; set; }
        public string StateKey { get; set; }

        public CurrentStateEvent()
        {
            this.CurrentStateEventId = Guid.NewGuid();
        }
    }
}
