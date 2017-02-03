using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrix.Domain.Models.Database
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public bool IsPublic { get; set; }
        public Guid CreatorUserId { get; set; }

        public virtual ICollection<RoomAlias> RoomAliases { get; set; }

        [ForeignKey("CreatorUserId")]
        public virtual User CreatorUser { get; set; }
        
        public Room()
        {
            this.RoomId = Guid.NewGuid();
            this.RoomAliases = new HashSet<RoomAlias>();
        }
    }
}
