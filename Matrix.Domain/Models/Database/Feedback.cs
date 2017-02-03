using System;

namespace Matrix.Domain.Models.Database
{
    public class Feedback
    {
        public Guid FeedbackId { get; set; }
        public Guid EventId { get; set; }
        public string FeedbackType { get; set; }
        public Guid? TargetEventId { get; set; }
        public string Sender { get; set; }
        public Guid? RoomId { get; set; }

        public Feedback()
        {
            this.FeedbackId = Guid.NewGuid();
        }
    }
}
