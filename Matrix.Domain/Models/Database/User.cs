using System;

namespace Matrix.Domain.Models.Database
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsAdmin { get; set; }

        public User()
        {
            this.UserId = Guid.NewGuid();
        }
    }
}
