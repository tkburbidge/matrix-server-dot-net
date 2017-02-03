using System;

namespace Matrix.Domain.Models.Database
{
    public class RoomDepth
    {
        public Guid RoomDepthId { get; set; }
        public Guid RoomId { get; set; }
        public int MinDepth { get; set; }

        public RoomDepth()
        {
            this.RoomDepthId = Guid.NewGuid();
        }
    }
}
