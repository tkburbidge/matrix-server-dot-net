using System;

namespace Matrix.Domain.Models.Database
{
    public class Profile
    {
        public Guid ProfileId { get; set; }
        public Guid UserId { get; set; }
        public string DisplayName { get; set; }
        public string AvatarUrl { get; set; }

        public Profile()
        {
            this.ProfileId = Guid.NewGuid();
        }
    }
}
