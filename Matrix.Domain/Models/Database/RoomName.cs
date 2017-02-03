using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomName
    {
        public Guid RoomNameId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string Name { get; set; }

        public RoomName()
        {
            this.RoomNameId = Guid.NewGuid();
        }
    }
}
