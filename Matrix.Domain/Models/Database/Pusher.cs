using System;

namespace Matrix.Domain.Models.Database
{
    public class Pusher
    {
        public Guid PusherId { get; set; }
        public string Username { get; set; }
        public long AccessToken { get; set; }
        public string ProfileTag { get; set; }
        public string Kind { get; set; }
        public Guid AppId { get; set; }
        public string AppDisplayName { get; set; }
        public string DeviceDisplayName { get; set; }
        public string Pushkey { get; set; }
        public DateTime Timestamp { get; set; }
        public string Lang { get; set; }
        public string Data { get; set; }
        public string LastToken { get; set; }
        public DateTime? LastSuccess { get; set; }
        public DateTime? FailingSince { get; set; }

        public Pusher()
        {
            this.PusherId = Guid.NewGuid();
        }
    }
}
