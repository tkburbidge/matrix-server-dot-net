using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomHost
    {
        public Guid RoomHostId { get; set; }
        public Guid RoomId { get; set; }
        public string Host { get; set; }

        public RoomHost()
        {
            this.RoomHostId = Guid.NewGuid();
        }
    }
}
