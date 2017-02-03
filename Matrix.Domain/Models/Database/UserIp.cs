using System;

namespace Matrix.Domain.Models.Database
{
    public class UserIp
    {
        public Guid UserIpId { get; set; }
        public Guid UserId { get; set; }
        public Guid AccessTokenId { get; set; }
        public Guid? DeviceId { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public DateTime LastSeen { get; set; }

        public UserIp()
        {
            this.UserIpId = Guid.NewGuid();
        }
    }
}
