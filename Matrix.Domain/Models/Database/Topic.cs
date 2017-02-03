using System;

namespace Matrix.Domain.Models.Database
{
    public class Topic
    {
        public Guid TopicId { get; set; }
        public Guid EventId { get; set; }
        public Guid RoomId { get; set; }
        public string TopicText { get; set; }

        public Topic()
        {
            this.TopicId = Guid.NewGuid();
        }
    }
}
