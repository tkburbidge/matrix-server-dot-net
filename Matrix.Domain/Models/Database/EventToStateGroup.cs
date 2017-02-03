using System;

namespace Matrix.Domain.Models.Database
{
    public class EventToStateGroup
    {
        public Guid EventToStateGroupId { get; set; }
        public Guid EventId { get; set; }
        public Guid StateGroupId { get; set; }

        public EventToStateGroup()
        {
            this.EventToStateGroupId = Guid.NewGuid();
        }
    }
}
