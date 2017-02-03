using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomAlias
    {
        public Guid RoomAliasId { get; set; }
        public string RoomAliasName { get; set; }
        public Guid RoomId { get; set; }

        public RoomAlias()
        {
            this.RoomAliasId = Guid.NewGuid();
        }
    }
}
