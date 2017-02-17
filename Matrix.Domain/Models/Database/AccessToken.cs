using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrix.Domain.Models.Database
{
    public class AccessToken
    {
        public Guid AccessTokenId { get; set; }
        public Guid UserId { get; set; }
        public Guid? DeviceId { get; set; }
        public string Token { get; set; }
        public DateTime LastUsed { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public AccessToken()
        {
            this.AccessTokenId = Guid.NewGuid();
        }
    }
}
