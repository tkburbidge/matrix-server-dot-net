using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomAliasServer
    {
        public Guid RoomAliasServerId { get; set; }
        public Guid RoomAliasId { get; set; }
        public string Server { get; set; }

        public RoomAliasServer()
        {
            this.RoomAliasServerId = Guid.NewGuid();
        }
    }
}
