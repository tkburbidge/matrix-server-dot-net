using System;

namespace Matrix.Domain.Models.Database
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public bool IsPublic { get; set; }
        public string Creator { get; set; }

        public Room()
        {
            this.RoomId = Guid.NewGuid();
        }
    }
}
