using System;

namespace Matrix.Domain.Models.Database
{
    public class UserFilter
    {
        public Guid UserFilterId { get; set; }
        public Guid UserId { get; set; }
        public Guid? FilterId { get; set; }
        public string FilterJson { get; set; }

        public UserFilter()
        {
            this.UserFilterId = Guid.NewGuid();
        }
    }
}
